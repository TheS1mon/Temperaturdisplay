using System;
using System.IO.Ports;

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
        }

        /// <summary>
        /// Liest einen Wert via serieller Schnittstelle und gibt diesen zurück
        /// </summary>
        /// <returns>Wert von serieller Schnittstelle</returns>
        /// <exception cref="TimeoutException"></exception>
        public static string read()
        {
            _serialPort.Open();

            // Liest den übertragenen Wert und gibt diesen zurück
            return _serialPort.ReadLine();
        }
    }
}
