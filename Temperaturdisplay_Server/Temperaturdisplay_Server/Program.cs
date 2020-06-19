using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.IO.Ports;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading;

namespace Temperaturdisplay_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Temperaturserver by Simon.\nBeginne mit dem Einrichtungsvorgang.");
                Thread.Sleep(3000);
                Console.Clear();

                //Serielle Schnittstelle
                Console.WriteLine("Geben Sie zuerst die erforderlichen Informationen für die Verbindung via serieller Schnittstelle ein.");
                // Einlesen der Daten
                string portName = SerialPortReader.getPortName();
                int baudRate = SerialPortReader.getBaudRate();
                Parity parity = SerialPortReader.getParity();
                int dataBits = SerialPortReader.getDataBits();
                StopBits stopBits = SerialPortReader.getStopBits();
                // Konfiguration der seriellen Schnittstelle
                SerialPortReader.setSerialSettings(portName, baudRate, parity, dataBits, stopBits);
                Console.WriteLine("Initialisierung der seriellen Schnittstelle abgeschlossen. Weiter gehts mit der Verbindung zum SQL-Server.");
                Thread.Sleep(3000);

                // MySQL-Anbindung
                while (!dbSetup()) { } // Stellt die Verbindung zum MySql Server her.
                Console.WriteLine("Erfolgreich! Ab jetzt werden die Temperaturwerte in der Datenbank gespeichert.");
                Thread.Sleep(3000);
                Console.Clear();

                // Empfangen der Temperaturen und Speicherung in der DB (in eigenem Thread)
                Thread readAndSave = new Thread(new ThreadStart(readTempAndSaveToDB));
                readAndSave.Start();

                // Socket Server starten
                SocketServer.startServer();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ein Fehler ist aufgetregen, drücke eine beliebige Taste, um das Programm zu schließen.\nFehlermeldung: {0}", ex.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        private static bool dbSetup()
        {
            Console.Clear();
            Console.WriteLine("Verbindungsassistent zum Verbinden mit einem MySql Server.");
            SQLConnector.makeConnectionString();
            Console.WriteLine("Verbindung wird hergestellt..");
            Thread.Sleep(2000);
            try
            {
                SQLConnector.connectToDB();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Verbindung fehlgeschlagen: " + ex.Message + "\nWiederhole Prozedur, einen Moment bitte..");
                Thread.Sleep(5000);
                return false;
            }
            Console.WriteLine("Verbindung erfolgreich hergestellt!" + "\nDatenbank wird erstellt..");
            try
            {
                SQLConnector.setupDB();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erstellung fehlgeschlagen: " + ex.Message + "\nWiederhole Prozedur, einen Moment bitte..");
                Thread.Sleep(5000);
                return false;
            }
            Console.WriteLine("Datenbank erfolgreich erstellt!");
            return true;
        }

        private static void readTempAndSaveToDB()
        {
            //Empfangen und speichern in DB
            int counter = 0;
            while (true)
            {
                if (counter == 9) // Nur jede 10. Messung in DB speichern aufgrund der Auslastung
                {
                    SQLConnector.insertToDB(SerialPortReader.read());
                    counter = 0;
                    Console.WriteLine("(" + DateTime.Now.ToString("hh:mm:ss") + ") Neuer Wert empfangen und in Datenbank gespeichert.");
                }
                else
                {
                    SerialPortReader.read();
                    counter++;
                }
            }
        }

        public static void newIncommingCommand(String command, Socket handler)
        {
            ArrayList answer = null;
            if(command.Equals("akt"))
            {
                answer = SQLConnector.runQueryAllData("SELECT *  FROM `temperatur` ORDER BY `temp_id` DESC LIMIT 1;");
                Console.WriteLine("(" + DateTime.Now.ToString("hh:mm:ss") + ") Folgende Daten wurden vom Client angefordert: {0}", answer[0].ToString());
                SocketServer.Send(handler, answer[0].ToString());
            }
            else // Uhrzeit
            if(Regex.IsMatch(command, @"^[F][R][A][M][;][0-9]{2}[\:][0-9]{2}[\:][0-9]{2}[;][T][O][;][0-9]{2}[\:][0-9]{2}[\:][0-9]{2}[;]$")) // Format: FRAM;hh:mm:ss;TO;hh:mm:ss;
            {
                string answerString = "";
                string[] values = command.Split(';');
                answer = SQLConnector.runQueryAllData("SELECT *  FROM `temperatur` WHERE `zeit` BETWEEN \"" + values[1] + "\" AND \"" + values[3] + "\"");
                foreach(object value in answer)
                {
                    answerString += value + "I";
                }
                SocketServer.Send(handler, answerString);
            }
            else // Datum
            if (Regex.IsMatch(command, @"^[F][R][A][M][;][0-9]{4}[\-][0-9]{2}[\-][0-9]{2}[;][T][O][;][0-9]{4}[\-][0-9]{2}[\-][0-9]{2}[;]$")) // Format: FRAM;yyyy-mm-dd;TO;yyyy-mm-dd;
            {
                string answerString = "";
                string[] values = command.Split(';');
                answer = SQLConnector.runQueryAllData("SELECT *  FROM `temperatur` WHERE `datum` BETWEEN \"" + values[1] + "\" AND \"" + values[3] + "\"");
                foreach (object value in answer)
                {
                    answerString += value + "I";
                }
                SocketServer.Send(handler, answerString);
            }
            else
            {
                Console.WriteLine("(" + DateTime.Now.ToString("hh:mm:ss") + ") Ungültiger Befehl vom Clienten!");
            }
        }
    }
}
