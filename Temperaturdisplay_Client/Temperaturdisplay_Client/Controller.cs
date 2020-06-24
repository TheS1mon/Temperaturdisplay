using System;
using System.Net;

namespace Temperaturdisplay_Client
{
    public class Controller
    {
        Model model;

        public Controller(Model model)
        {
            this.model = model;
        }

        /// <summary>
        /// Sendet eine Nachricht an den Server und gibt die Antwort zurück
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        /// <param name="message"></param>
        /// <returns>Antwort vom Server</returns>
        public string send(IPAddress ip, int port, string message)
        {
            return model.send(ip, port, message);
        }

        /// <summary>
        /// Sendet eine Nachricht an den Server und gibt die Antwort zurück. Nimmt die IP-Addresse und den Port aus den Settings
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        /// <param name="message"></param>
        /// <returns>Antwort vom Server</returns>
        public string sendIfConnected(string message)
        {
            string tmp = Properties.Settings.Default.connectedTo;
            string[] connectionDetails= tmp.Split(':');
            return model.send(IPAddress.Parse(connectionDetails[0]), Int32.Parse(connectionDetails[1]), message);
        }
    }
}
