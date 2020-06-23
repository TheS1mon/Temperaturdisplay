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
        Controller controller;
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
                    //userControlVerbindungsmanager1.Visible = false;
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
                    userControlStartseite1.Visible = false;
                    //userControlVerbindungsmanager1.Visible = true;
                    break;
                case 2: // AktDaten
                    buttonStartseite.ForeColor = Color.Black;
                    buttonVerbindungsmanager.ForeColor = Color.Black;
                    buttonAktDaten.ForeColor = Color.Olive;
                    buttonDatenarchiv.ForeColor = Color.Black;
                    buttonEinstellungen.ForeColor = Color.Black;
                    userControlStartseite1.Visible = false;
                    //userControlVerbindungsmanager1.Visible = false;
                    break;
                case 3: // Datenarchiv
                    buttonStartseite.ForeColor = Color.Black;
                    buttonVerbindungsmanager.ForeColor = Color.Black;
                    buttonAktDaten.ForeColor = Color.Black;
                    buttonDatenarchiv.ForeColor = Color.Olive;
                    buttonEinstellungen.ForeColor = Color.Black;
                    userControlStartseite1.Visible = false;
                    //userControlVerbindungsmanager1.Visible = false;
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
                    //userControlVerbindungsmanager1.Visible = false;
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
            this.changeMenu(4);
        }
    }
}
