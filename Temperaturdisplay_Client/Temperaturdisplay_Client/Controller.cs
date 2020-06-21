using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturdisplay_Client
{
    public class Controller
    {
        private ModelSocket model;
        public Controller(ModelSocket model)
        {
            this.model = model;
        }

        public string send(IPAddress ip, int port, string message)
        {
            return model.send(ip, port, message);
        }
    }
}
