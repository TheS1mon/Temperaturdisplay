using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperaturdisplay_Client
{
    public partial class UserControlAktDaten : UserControl
    {
        private Controller controller;
        string lastID = "0";

        public UserControlAktDaten()
        {
            InitializeComponent();
        }

        public void giveMeController(Controller controller)
        {
            this.controller = controller;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (buttonStart.Text.Equals("Aufzeichnung starten"))
            {
                timer1.Enabled = true;
                buttonStart.Text = "Aufzeichnung stoppen"; 
            }
            else
            {
                timer1.Enabled = false;
                buttonStart.Text = "Aufzeichnung starten";
            }
        }

        public void stoppeAufzeichnung()
        {
            timer1.Enabled = false;
            buttonStart.Text = "Aufzeichnung starten";
        }

        private string[] messe()
        {
            string[] tempData;
            do
            {
                string tmp = controller.sendIfConnected("akt");
                tempData = tmp.Split(';'); 
            } 
            while (tempData[0].Equals("Verbindung erfolgreich"));
            return tempData;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] tempData = messe();
            if (!lastID.Equals(tempData[0]))
            {
                listBoxID.Items.Add(tempData[0]);
                listBoxTemp.Items.Add(tempData[1] + " °C");
                string[] tmp = tempData[2].Split(' '); // Uhrzeit vom Datum entfernen
                listBoxDate.Items.Add(tmp[0]);
                listBoxTime.Items.Add(tempData[3]);
                labelTempAkt.Text = tempData[1];
                lastID = tempData[0];
                listBoxID.TopIndex = listBoxID.Items.Count - 1;
                listBoxTemp.TopIndex = listBoxTemp.Items.Count - 1;
                listBoxDate.TopIndex = listBoxDate.Items.Count - 1;
                listBoxTime.TopIndex = listBoxTime.Items.Count - 1;
            }
            lastID = tempData[0];
        }

        private void listBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxTemp.SelectedIndex = listBoxID.SelectedIndex;
            listBoxDate.SelectedIndex = listBoxID.SelectedIndex;
            listBoxTime.SelectedIndex = listBoxID.SelectedIndex;
        }

        private void listBoxTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxID.SelectedIndex = listBoxTemp.SelectedIndex;
            listBoxDate.SelectedIndex = listBoxTemp.SelectedIndex;
            listBoxTime.SelectedIndex = listBoxTemp.SelectedIndex;
        }

        private void listBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxTemp.SelectedIndex = listBoxDate.SelectedIndex;
            listBoxID.SelectedIndex = listBoxDate.SelectedIndex;
            listBoxTime.SelectedIndex = listBoxDate.SelectedIndex;
        }

        private void listBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxTemp.SelectedIndex = listBoxTime.SelectedIndex;
            listBoxDate.SelectedIndex = listBoxTime.SelectedIndex;
            listBoxID.SelectedIndex = listBoxTime.SelectedIndex;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (listBoxID.SelectedIndex != -1)
            {
                int index = listBoxID.SelectedIndex;
                listBoxID.Items.RemoveAt(index);
                listBoxTemp.Items.RemoveAt(index);
                listBoxDate.Items.RemoveAt(index);
                listBoxTime.Items.RemoveAt(index); 
            }
        }
    }
}
