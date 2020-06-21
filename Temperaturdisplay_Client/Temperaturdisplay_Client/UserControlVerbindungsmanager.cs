using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Temperaturdisplay_Client
{
    public partial class UserControlVerbindungsmanager : UserControl
    {
        private Controller controller;
        private bool connectionSuccessfull = false;
        public UserControlVerbindungsmanager(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 2500;
            timer.Tick += timer_Tick;
            pictureBoxLoading.Visible = true;
            labelErfolgreich.Visible = false;
            labelFehlgeschlagen.Visible = false;
            timer.Start();
            IPAddress ip;
            int port;
            IPAddress.TryParse(textBoxIP.Text, out ip);
            Int32.TryParse(textBoxPort.Text, out port);

            try
            {
                if (controller.send(ip, port, "test").Equals("Verbindung erfolgreich"))
                {
                    connectionSuccessfull = true;
                }
                else
                {
                    connectionSuccessfull = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Interner Fehler: " + ex.Message);
            }
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            if(connectionSuccessfull)
            {
                labelErfolgreich.Visible = true;
                pictureBoxLoading.Visible = false;
            }
            else
            {
                labelFehlgeschlagen.Visible = true;
                pictureBoxLoading.Visible = false;
            }
        }
    }
}
