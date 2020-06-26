using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperaturdisplay_Client
{
    public partial class FormMain : Form
    {
        private Controller controller = null;
        private bool connectionEstablished = false;

        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(Controller controller) : this()
        {
            this.controller = controller;
        }

        private void changeMenu(int selectedMenu /* 0=Startseite 1=Verbindungsmanager 2=aktuelle_Daten 3=Datenarchiv 4=Einstellungen */)
        {
            switch (selectedMenu)
            {
                case 0: // Startseite
                    buttonStartseite.ForeColor = Color.Olive;
                    buttonVerbindungsmanager.ForeColor = Color.Black;
                    if (this.connectionEstablished)
                    {
                        buttonAktDaten.ForeColor = Color.Black;
                        buttonDatenarchiv.ForeColor = Color.Black;
                    }
                    else
                    {
                        buttonAktDaten.ForeColor = Color.DimGray;
                        buttonDatenarchiv.ForeColor = Color.DimGray;
                    }
                    buttonEinstellungen.ForeColor = Color.Black;
                    userControlStartseite1.Visible = true;
                    userControlConnectionManager1.Visible = false;
                    userControlAktDaten1.Visible = false;
                    userControlAktDaten1.stoppeAufzeichnung();
                    userControlDatenarchiv1.Visible = false;
                    break;
                case 1: // Verbindungsmanager
                    buttonStartseite.ForeColor = Color.Black;
                    buttonVerbindungsmanager.ForeColor = Color.Olive;
                    if (this.connectionEstablished)
                    {
                        buttonAktDaten.ForeColor = Color.Black;
                        buttonDatenarchiv.ForeColor = Color.Black;
                    }
                    else
                    {
                        buttonAktDaten.ForeColor = Color.DimGray;
                        buttonDatenarchiv.ForeColor = Color.DimGray;
                    }
                    buttonEinstellungen.ForeColor = Color.Black;
                    userControlConnectionManager1.giveMeController(controller);
                    userControlStartseite1.Visible = false;
                    userControlConnectionManager1.Visible = true;
                    userControlAktDaten1.Visible = false;
                    userControlAktDaten1.stoppeAufzeichnung();
                    userControlDatenarchiv1.Visible = false;
                    break;
                case 2: // AktDaten
                    buttonStartseite.ForeColor = Color.Black;
                    buttonVerbindungsmanager.ForeColor = Color.Black;
                    buttonAktDaten.ForeColor = Color.Olive;
                    buttonDatenarchiv.ForeColor = Color.Black;
                    buttonEinstellungen.ForeColor = Color.Black;
                    userControlStartseite1.Visible = false;
                    userControlConnectionManager1.Visible = false;
                    userControlAktDaten1.giveMeController(controller);
                    userControlAktDaten1.Visible = true;
                    userControlDatenarchiv1.Visible = false;
                    break;
                case 3: // Datenarchiv
                    buttonStartseite.ForeColor = Color.Black;
                    buttonVerbindungsmanager.ForeColor = Color.Black;
                    buttonAktDaten.ForeColor = Color.Black;
                    buttonDatenarchiv.ForeColor = Color.Olive;
                    buttonEinstellungen.ForeColor = Color.Black;
                    userControlStartseite1.Visible = false;
                    userControlConnectionManager1.Visible = false;
                    userControlAktDaten1.Visible = false;
                    userControlAktDaten1.stoppeAufzeichnung();
                    userControlDatenarchiv1.Visible = true;
                    userControlDatenarchiv1.giveMeController(controller);
                    break;
                case 4: // Einstellungen
                    buttonStartseite.ForeColor = Color.Black;
                    buttonVerbindungsmanager.ForeColor = Color.Black;
                    if (this.connectionEstablished)
                    {
                        buttonAktDaten.ForeColor = Color.Black;
                        buttonDatenarchiv.ForeColor = Color.Black;
                    }
                    else
                    {
                        buttonAktDaten.ForeColor = Color.DimGray;
                        buttonDatenarchiv.ForeColor = Color.DimGray;
                    }
                    buttonEinstellungen.ForeColor = Color.Olive;
                    userControlStartseite1.Visible = false;
                    userControlConnectionManager1.Visible = false;
                    userControlAktDaten1.Visible = false;
                    userControlAktDaten1.stoppeAufzeichnung();
                    userControlDatenarchiv1.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void buttonStartseite_Click(object sender, EventArgs e)
        {
            this.changeMenu(0);
        }

        private void buttonVerbindungsmanager_Click(object sender, EventArgs e)
        {
            this.changeMenu(1);
        }

        private void buttonAktDaten_Click(object sender, EventArgs e)
        {
            this.changeMenu(2);
        }

        private void buttonDatenarchiv_Click(object sender, EventArgs e)
        {
            this.changeMenu(3);
        }

        private void buttonEinstellungen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.connectedTo.Equals("noone"))
            {
                this.toolStripStatusLabelConnection.Text = "Verbunden mit: " + Properties.Settings.Default.connectedTo;
                userControlStartseite1.enableControls();
                userControlStartseite1.checkFirstBox();
                buttonAktDaten.Enabled = true;
                buttonDatenarchiv.Enabled = true;
                if(buttonAktDaten.ForeColor == Color.DimGray)
                {
                    buttonAktDaten.ForeColor = Color.Black;
                    buttonDatenarchiv.ForeColor = Color.Black;
                }
                this.connectionEstablished = true;
            }
            else
            {
                
            }
        }
    }
}
