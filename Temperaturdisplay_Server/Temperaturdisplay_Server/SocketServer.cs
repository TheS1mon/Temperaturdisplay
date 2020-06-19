using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Temperaturdisplay_Server
{
    class SocketServer
    {
        public static ManualResetEvent allDone = new ManualResetEvent(false);
        private static IPEndPoint localEndPoint;
        private static Thread listener;

        public static void startServer()
        {
            setIP();
            Console.WriteLine("(" + DateTime.Now.ToString("hh:mm:ss") + ") IP-Adresse und Port wurden erfolgreich ermittelt: {0}", localEndPoint.ToString());
            listener = new Thread(new ThreadStart(StartListening));
            listener.Start();
        }

        private static void setIP()
        {
            // Holt die IP Adressen des Rechners und zieht sich die IPv4 da raus
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress myIP = null;
            foreach (IPAddress ip in ipHostInfo.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    myIP = ip;
                }
            }
            if (myIP == null)
            {
                throw new Exception("Keine IPv4 Adresse gefunden!");
            }

            //Legt die IP Adresse und den Port fest
            localEndPoint = new IPEndPoint(myIP, 11000);
        }

        private static void StartListening()
        {
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // Verbindet den Socket mit de localEndPoint und wartet auf eingehende Verbindungen
            listener.Bind(localEndPoint);
            listener.Listen(200);

            while (true)
            {
                // Event zurücksetzen um zu Warten 
                allDone.Reset();

                // Wartet auf Asyncrone Verbindungen 
                listener.BeginAccept(new AsyncCallback(AcceptCallback), listener);

                // Wartet auf Fertigstellung der Verbindung 
                allDone.WaitOne();
            }
        }

        public static void AcceptCallback(IAsyncResult ar)
        {
            // Gibt das Weiter-Signal
            allDone.Set();

            Console.WriteLine("(" + DateTime.Now.ToString("hh:mm:ss") + ") Eingehende Verbindung erkannt, versuche die Nachricht zu empfangen");

            // Empfängt den Socket
            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);

            // Beginnt mit dem Empfangen der Daten
            StateObject state = new StateObject();
            state.workSocket = handler;
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReadCallback), state);
        }

        public static void ReadCallback(IAsyncResult ar)
        {
            String content = String.Empty;

            // Empfängt state und den handler  
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;

            // Empfängt die Daten vom Klienten
            int bytesRead = handler.EndReceive(ar);

            if (bytesRead > 0)
            {
                // Bisher empfangene Daten speichern
                state.sb.Append(Encoding.ASCII.GetString(
                    state.buffer, 0, bytesRead));

                // Solange weiter speichern und empfangen, bis <EOF> empfangen wird
                content = state.sb.ToString();
                if (content.IndexOf("<EOF>") > -1)
                {
                    // Zeige die gelesenen Daten an
                    Console.WriteLine("(" + DateTime.Now.ToString("hh:mm:ss") + ") {0} Bytes an Daten erfolgreich empfangen von {1}", content.Length - 5, localEndPoint.ToString());
                    Program.newIncommingCommand(content.Substring(0, content.Length - 5), handler);
                }
                else
                {
                    // Weiter rekursiv Daten empfangen 
                    handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReadCallback), state);
                }
            }
        }

        public static void Send(Socket handler, String data)
        {
            // Daten in ASCII Code speichern für die Übertragung  
            byte[] byteData = Encoding.ASCII.GetBytes(data + "<EOF>");

            // Startet das Senden der Daten 
            handler.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), handler);
        }


        private static void SendCallback(IAsyncResult ar)
        {
            Socket handler = (Socket)ar.AsyncState;

            // Sendet die Daten an den Clienten zurück
            int bytesSent = handler.EndSend(ar);
            Console.WriteLine("(" + DateTime.Now.ToString("hh:mm:ss") + ") {0} Bytes an Daten an {1} zurückgeschickt.", bytesSent - 5, localEndPoint.ToString());

            handler.Shutdown(SocketShutdown.Both);
            handler.Close();
        }
    }
        
    public class StateObject
    {
        // Client  socket.  
        public Socket workSocket = null;
        // Size of receive buffer.  
        public const int BufferSize = 1024;
        // Receive buffer.  
        public byte[] buffer = new byte[BufferSize];
        // Received data string.  
        public StringBuilder sb = new StringBuilder();
    }
}
