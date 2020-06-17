using System;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Threading;

namespace Temperaturdisplay_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperaturserver by Simon." +
                "\nBeginne mit dem Einrichtungsvorgang." +
                "\nGeben Sie zuerst die erforderlichen Informationen für die Verbindung zum Mikrocontroller ein.");
            // Einlesen der Daten
            string portName = SerialPortReader.getPortName();
            int baudRate = SerialPortReader.getBaudRate();
            Parity parity = SerialPortReader.getParity();
            int dataBits = SerialPortReader.getDataBits();
            StopBits stopBits = SerialPortReader.getStopBits();
            // Konfiguration der seriellen Schnittstelle
            SerialPortReader.setSerialSettings(portName, baudRate, parity, dataBits, stopBits);
            Console.WriteLine("Initialisierung der seriellen Schnittstelle abgeschlossen. Beginne Datenübertragung.");
            Thread.Sleep(3000);
            Console.Clear();
            while (true)
            {
                Console.WriteLine(SerialPortReader.read()); 
            }
        }
    }
}
