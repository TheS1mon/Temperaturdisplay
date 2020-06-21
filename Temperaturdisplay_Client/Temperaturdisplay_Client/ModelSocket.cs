using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Temperaturdisplay_Client
{
    public class ModelSocket
    {
        private static ManualResetEvent connectDone = new ManualResetEvent(false);
        private static ManualResetEvent sendDone = new ManualResetEvent(false);
        private static ManualResetEvent receiveDone = new ManualResetEvent(false);
        private Thread sending = null;

        private static String response = String.Empty;

        public string send(IPAddress ip, int port, string message)
        {
            string msg = String.Empty;
            sending = new Thread(unused => msg=StartClient(port, ip, message));
            sending.Start();
            sending.Join();
            string tmp = "";
            if(msg.Length >= 5)
            {
                tmp = msg.Substring(0, msg.Length - 5);
            }
            return tmp;
        }

        private string StartClient(int serverPort, IPAddress serverIP, string message)
        {
            IPEndPoint server = new IPEndPoint(serverIP, serverPort);

            // Es wird ein Socket mit IPv4, TCP und dem Stream Typ erstellt
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // Verbindet sich mit dem Server
            client.BeginConnect(server, new AsyncCallback(ConnectCallback), client);
            connectDone.WaitOne();
                    //!!!listBoxLog.Items.Add("Verbindung wird hergestellt mit " + client.RemoteEndPoint.ToString());

            //Sendet die Nachricht an den Server
            Send(client, message + "<EOF>");
            sendDone.WaitOne();
            //!!!listBoxLog.Items.Add("Text " + textBoxMessage.Text + " erfolgreich gesendet");

            Receive(client);
            receiveDone.WaitOne();

            // Release the socket.  
            //client.Shutdown(SocketShutdown.Both);
            //client.Close();

            return response;
        }

        private void ConnectCallback(IAsyncResult ar)
        {
            // Empfängt den Socket  
            Socket client = (Socket)ar.AsyncState;

            // Beendet die Verbindungsherstellung 
            client.EndConnect(ar);

            // Signalisiert, dass die Verbindung besteht 
            connectDone.Set();
        }

        private void Send(Socket client, String data)
        {
            // Konvertiert den String in Bytes mit ASCII Encoding  
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Startet das Senden der Daten  
            client.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallback), client);
        }

        private void SendCallback(IAsyncResult ar)
        {
            // Empfängt den Socket
            Socket client = (Socket)ar.AsyncState;

            // Beendet das Senden
            client.EndSend(ar);

            // Signalisiert, dass das Senden erfolgreich zu Ende ist
            sendDone.Set();
        }

        private static void Receive(Socket client)
        {

           StateObject state = new StateObject();
           state.workSocket = client;

           // Startet mit dem Empfangen der Daten 
           client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
               new AsyncCallback(ReceiveCallback), state);
        }

        private static void ReceiveCallback(IAsyncResult ar)
        {
            StateObject state = (StateObject)ar.AsyncState;
            Socket client = state.workSocket;

            // Liest die empfangenen Daten  
            int bytesRead = client.EndReceive(ar);

            if (bytesRead > 0)
            {
                // Liest weiter wenn noch mehr Daten empfangen werden
                state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));
 
                client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReceiveCallback), state);
            }
            else
            {
                // Alle Daten wurden empfangen
                if (state.sb.Length > 1)
                {
                    response = state.sb.ToString();
                }
                // Gibt das Signal, dass alles empfangen wurde  
                receiveDone.Set();
            }
        }
    }

    public class StateObject
    {
        // Client socket.  
        public Socket workSocket = null;
        // Size of receive buffer.  
        public const int BufferSize = 256;
        // Receive buffer.  
        public byte[] buffer = new byte[BufferSize];
        // Received data string.  
        public StringBuilder sb = new StringBuilder();
    }
}
