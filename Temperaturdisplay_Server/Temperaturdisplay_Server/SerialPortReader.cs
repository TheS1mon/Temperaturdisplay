using System;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace Temperaturdisplay_Server
{
    class SerialPortReader
    {
        static SerialPort _serialPort = new SerialPort();

        /// <summary>
        /// Legt die Einstellungen für eine Verbindung via serieller Schnittstelle fest
        /// </summary>
        /// <param name="portName"></param>
        /// <param name="baudRate"></param>
        /// <param name="parity"></param>
        /// <param name="dataBits"></param>
        /// <param name="stopBits"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public static void setSerialSettings(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
        {
            // Festlegen von Eigenschaften
            _serialPort.PortName = portName;
            _serialPort.BaudRate = baudRate;
            _serialPort.Parity = parity;
            _serialPort.DataBits = dataBits;
            _serialPort.StopBits = stopBits;

            // Setze Schreib / Lese Timeouts
            _serialPort.ReadTimeout = 1500;
            _serialPort.WriteTimeout = 1500;

            _serialPort.Open();
        }

        /// <summary>
        /// Liest einen Wert via serieller Schnittstelle und gibt diesen zurück
        /// </summary>
        /// <returns>Wert von serieller Schnittstelle</returns>
        /// <exception cref="TimeoutException"></exception>
        public static string read()
        {
            // Liest den übertragenen Wert und gibt diesen zurück
            return _serialPort.ReadLine();
        }

        public static string getPortName()
        {
            string portName;
            Console.WriteLine("\nVerfügbare Ports:");
            foreach (string s in SerialPort.GetPortNames())
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("\nGeben Sie den gewünschten Portnamen ein:");
            do
            {
                portName = Console.ReadLine();
                if (!Regex.IsMatch(portName, "^[cC][oO][mM][1-9]$"))
                {
                    Console.Write("Bitte gültigen Portnamen eingeben: ");
                }
            }
            while (!Regex.IsMatch(portName, "^[cC][oO][mM][1-9]$"));
            return portName;
        }

        public static int getBaudRate()
        {
            string baudRateStr;
            int baudRate;
            Console.Write("Geben Sie nun die Baudrate ein: ");
            do
            {
                baudRateStr = Console.ReadLine();
                if (!Int32.TryParse(baudRateStr, out baudRate))
                {
                    Console.Write("Bitte nur Zahlen eingeben: ");
                }
            }
            while (!Int32.TryParse(baudRateStr, out baudRate));
            return baudRate;
        }

        public static Parity getParity()
        {
            string selector;
            Console.WriteLine("Verfügbare Paritätswerte:" +
                "\n(1) None" +
                "\n(2) Odd" +
                "\n(3) Even" +
                "\n(4) Mark " +
                "\n(5) Space");

            Console.Write("Geben Sie eine Nummer ein: ");
            do
            {
                selector = Console.ReadLine();
                if (!Regex.IsMatch(selector, "^[1-5]$"))
                {
                    Console.Write("Bitte nur Nummern von 1 bis 5 eingeben: ");
                }
            }
            while (!Regex.IsMatch(selector, "^[1-5]$"));

            switch (Int32.Parse(selector))
            {
                case 1:
                    return Parity.None;
                case 2:
                    return Parity.Odd;
                case 3:
                    return Parity.Even;
                case 4:
                    return Parity.Mark;
                case 5:
                    return Parity.Space;
            }
            return Parity.None;
        }

        public static int getDataBits()
        {
            string dataBits;
            Console.Write("Geben Sie die Anzahl an Databits ein (5-8): ");
            do
            {
                dataBits = Console.ReadLine();
                if (!Regex.IsMatch(dataBits, "^[5-8]$"))
                {
                    Console.Write("Bitte nur Nummern von 5 bis 8 eingeben: ");
                }
            }
            while (!Regex.IsMatch(dataBits, "^[5-8]$"));
            return Int32.Parse(dataBits);
        }

        public static StopBits getStopBits()
        {
            string stopBits;
            Console.Write("Geben Sie die Anzahl an Stoppbits ein (1 oder 2): ");
            do
            {
                stopBits = Console.ReadLine();
                if (!Regex.IsMatch(stopBits, "^[1-2]$"))
                {
                    Console.Write("Bitte nur 1 oder 2 eingeben: ");
                }
            }
            while (!Regex.IsMatch(stopBits, "^[1-2]$"));
            switch (Int32.Parse(stopBits))
            {
                case 1:
                    return StopBits.One;
                case 2:
                    return StopBits.Two;
            }
            return StopBits.One;
        }
    }
}
