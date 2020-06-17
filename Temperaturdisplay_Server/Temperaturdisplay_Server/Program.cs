using MySql.Data.MySqlClient;
using System;
using System.IO.Ports;
using System.Threading;

namespace Temperaturdisplay_Server
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
