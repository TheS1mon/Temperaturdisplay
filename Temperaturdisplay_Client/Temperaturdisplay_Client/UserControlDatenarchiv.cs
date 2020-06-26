using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Temperaturdisplay_Client
{
    public partial class UserControlDatenarchiv : UserControl
    {
        private Controller controller;
        private string lastID;
        List<Temperatur> tempList = new List<Temperatur>();

        public UserControlDatenarchiv()
        {
            InitializeComponent();
        }

        public void giveMeController(Controller controller)
        {
            this.controller = controller;
        }

        private string[] messe(string firstDate, string lastDate)
        {
            string[] tempData;
            do
            {
                string tmp = controller.sendIfConnected("FRAM;" + firstDate + ";TO;" + lastDate + ";");
                tempData = tmp.Split('I');
            }
            while (tempData[0].Equals("Verbindung erfolgreich") || tempData[0].Equals(""));
            return tempData;
        }

        private string[] messe(string firstDate, string lastDate, string firstTime, string lastTime)
        {
            string[] tempData;
            do
            {
                string tmp = controller.sendIfConnected("FRAM;" + firstTime + ";TO;" + lastTime + ";AND;" + firstDate + ";TO;" + lastDate + ";");
                tempData = tmp.Split('I');
            }
            while (tempData[0].Equals("Verbindung erfolgreich") || tempData[0].Equals(""));
            return tempData;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
                if (checkBoxAllDay.Checked) // ohne Berücksichtigung der Uhrzeit
                {
                    if (Regex.IsMatch(textBoxFirstDate.Text, "^[0-9]{4}[-][0-9]{2}[-][0-9]{2}$") && Regex.IsMatch(textBoxLastDate.Text, "^[0-9]{4}[-][0-9]{2}[-][0-9]{2}$")) //Prüft, ob das Format des Datums stimmt
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            listBoxID.Items.Clear();
                            listBoxTemp.Items.Clear();
                            listBoxDate.Items.Clear();
                            listBoxTime.Items.Clear();
                            try
                            {
                                string[] tempData = messe(textBoxFirstDate.Text, textBoxLastDate.Text);
                                foreach (string s in tempData)
                                {
                                    string[] oneTempData = s.Split(';');
                                    listBoxID.Items.Add(oneTempData[0]);
                                    listBoxTemp.Items.Add(oneTempData[1] + " °C");
                                    string[] tmp = oneTempData[2].Split(' '); // Uhrzeit vom Datum entfernen
                                    listBoxDate.Items.Add(tmp[0]);
                                    listBoxTime.Items.Add(oneTempData[3]);
                                    lastID = oneTempData[0];
                                    listBoxID.TopIndex = listBoxID.Items.Count - 1;
                                    listBoxTemp.TopIndex = listBoxTemp.Items.Count - 1;
                                    listBoxDate.TopIndex = listBoxDate.Items.Count - 1;
                                    listBoxTime.TopIndex = listBoxTime.Items.Count - 1;
                                Temperatur tmpTemperatur = new Temperatur(Double.Parse(oneTempData[1]), DateTime.Parse(oneTempData[3]));
                                tempList.Add(tmpTemperatur);
                            }
                            }
                            catch (Exception)
                            {
                                listBoxID.Items.RemoveAt(listBoxID.Items.Count - 1);
                                listBoxID.TopIndex = listBoxID.Items.Count - 1;
                            }  
                        }
                    }
                    else
                    {
                        MessageBox.Show("Daten richtig eingeben!");
                    }
                }
                else // Wenn die Uhrzeit mit berücksichtigs werden soll
                {
                    if (Regex.IsMatch(textBoxFirstDate.Text, "^[0-9]{4}[-][0-9]{2}[-][0-9]{2}$") && Regex.IsMatch(textBoxLastDate.Text, "^[0-9]{4}[-][0-9]{2}[-][0-9]{2}$") && Regex.IsMatch(textBoxFirstTime.Text, @"^[0-9]{2}[\:][0-9]{2}[\:][0-9]{2}$") && Regex.IsMatch(textBoxLastTime.Text, @"^[0-9]{2}[\:][0-9]{2}[\:][0-9]{2}$"))
                    {
                    for (int i = 0; i < 2; i++)
                    {
                        listBoxID.Items.Clear();
                        listBoxTemp.Items.Clear();
                        listBoxDate.Items.Clear();
                        listBoxTime.Items.Clear();
                        try
                        {
                            string[] tempData = messe(textBoxFirstDate.Text, textBoxLastDate.Text, textBoxFirstTime.Text, textBoxLastTime.Text);
                            foreach (string s in tempData)
                            {
                                string[] oneTempData = s.Split(';');
                                listBoxID.Items.Add(oneTempData[0]);
                                listBoxTemp.Items.Add(oneTempData[1] + " °C");
                                string[] tmp = oneTempData[2].Split(' '); // Uhrzeit vom Datum entfernen
                                listBoxDate.Items.Add(tmp[0]);
                                listBoxTime.Items.Add(oneTempData[3]);
                                lastID = oneTempData[0];
                                listBoxID.TopIndex = listBoxID.Items.Count - 1;
                                listBoxTemp.TopIndex = listBoxTemp.Items.Count - 1;
                                listBoxDate.TopIndex = listBoxDate.Items.Count - 1;
                                listBoxTime.TopIndex = listBoxTime.Items.Count - 1;
                                Temperatur tmpTemperatur = new Temperatur(Double.Parse(oneTempData[1]), DateTime.Parse(oneTempData[3]));
                                tempList.Add(tmpTemperatur);
                            }
                        }
                        catch (Exception)
                        {
                            listBoxID.Items.RemoveAt(listBoxID.Items.Count - 1);
                            listBoxID.TopIndex = listBoxID.Items.Count - 1;
                        }  
                    }
                    }
                    else
                    {
                        MessageBox.Show("Daten richtig eingeben!");
                    }
                
            }
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

        private void checkBoxAllDay_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAllDay.Checked)
            {
                textBoxFirstTime.Text = "";
                textBoxLastTime.Text = "";
                textBoxFirstTime.Enabled = false;
                textBoxLastTime.Enabled = false;
            }
            else
            {
                textBoxFirstTime.Text = "";
                textBoxLastTime.Text = "";
                textBoxFirstTime.Enabled = true;
                textBoxLastTime.Enabled = true;
            }
        }

        private void checkBoxToday_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxToday.Checked)
            {
                textBoxFirstDate.Text = DateTime.Parse(DateTime.Today.ToString().Split(' ')[0]).ToString("yyyy-MM-dd");
                textBoxLastDate.Text = DateTime.Parse(DateTime.Today.ToString().Split(' ')[0]).ToString("yyyy-MM-dd");
                textBoxFirstDate.Enabled = false;
                textBoxLastDate.Enabled = false;
            }
            else
            {
                textBoxFirstDate.Text = "";
                textBoxLastDate.Text = "";
                textBoxFirstDate.Enabled = true;
                textBoxLastDate.Enabled = true;
            }
        }

        private void buttonPlot_Click(object sender, EventArgs e)
        {
            FormPictureBox formPictureBox = new FormPictureBox(tempList, DateTime.Parse(textBoxFirstDate.Text), DateTime.Parse(textBoxLastDate.Text));
            formPictureBox.Show(); 
        }
    }
}
