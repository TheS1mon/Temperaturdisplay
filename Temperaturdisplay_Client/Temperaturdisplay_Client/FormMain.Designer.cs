namespace Temperaturdisplay_Client
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEinstellungen = new System.Windows.Forms.Button();
            this.buttonStartseite = new System.Windows.Forms.Button();
            this.buttonDatenarchiv = new System.Windows.Forms.Button();
            this.buttonAktDaten = new System.Windows.Forms.Button();
            this.buttonVerbindungsmanager = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.userControlAktDaten1 = new Temperaturdisplay_Client.UserControlAktDaten();
            this.userControlConnectionManager1 = new Temperaturdisplay_Client.UserControlConnectionManager();
            this.userControlStartseite1 = new Temperaturdisplay_Client.UserControlStartseite();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-6, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 1);
            this.panel1.TabIndex = 13;
            // 
            // buttonEinstellungen
            // 
            this.buttonEinstellungen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEinstellungen.ForeColor = System.Drawing.Color.Black;
            this.buttonEinstellungen.Location = new System.Drawing.Point(635, 11);
            this.buttonEinstellungen.Name = "buttonEinstellungen";
            this.buttonEinstellungen.Size = new System.Drawing.Size(143, 28);
            this.buttonEinstellungen.TabIndex = 12;
            this.buttonEinstellungen.Text = "Einstellungen";
            this.buttonEinstellungen.UseVisualStyleBackColor = true;
            this.buttonEinstellungen.Click += new System.EventHandler(this.buttonEinstellungen_Click);
            // 
            // buttonStartseite
            // 
            this.buttonStartseite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartseite.ForeColor = System.Drawing.Color.Olive;
            this.buttonStartseite.Location = new System.Drawing.Point(39, 11);
            this.buttonStartseite.Name = "buttonStartseite";
            this.buttonStartseite.Size = new System.Drawing.Size(143, 28);
            this.buttonStartseite.TabIndex = 11;
            this.buttonStartseite.Text = "Startseite";
            this.buttonStartseite.UseVisualStyleBackColor = true;
            this.buttonStartseite.Click += new System.EventHandler(this.buttonStartseite_Click);
            // 
            // buttonDatenarchiv
            // 
            this.buttonDatenarchiv.Enabled = false;
            this.buttonDatenarchiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDatenarchiv.ForeColor = System.Drawing.Color.DimGray;
            this.buttonDatenarchiv.Location = new System.Drawing.Point(486, 11);
            this.buttonDatenarchiv.Name = "buttonDatenarchiv";
            this.buttonDatenarchiv.Size = new System.Drawing.Size(143, 28);
            this.buttonDatenarchiv.TabIndex = 10;
            this.buttonDatenarchiv.Text = "Datenarchiv";
            this.buttonDatenarchiv.UseVisualStyleBackColor = true;
            this.buttonDatenarchiv.Click += new System.EventHandler(this.buttonDatenarchiv_Click);
            // 
            // buttonAktDaten
            // 
            this.buttonAktDaten.Enabled = false;
            this.buttonAktDaten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAktDaten.ForeColor = System.Drawing.Color.DimGray;
            this.buttonAktDaten.Location = new System.Drawing.Point(337, 11);
            this.buttonAktDaten.Name = "buttonAktDaten";
            this.buttonAktDaten.Size = new System.Drawing.Size(143, 28);
            this.buttonAktDaten.TabIndex = 9;
            this.buttonAktDaten.Text = "Aktuelle Daten";
            this.buttonAktDaten.UseVisualStyleBackColor = true;
            this.buttonAktDaten.Click += new System.EventHandler(this.buttonAktDaten_Click);
            // 
            // buttonVerbindungsmanager
            // 
            this.buttonVerbindungsmanager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerbindungsmanager.ForeColor = System.Drawing.Color.Black;
            this.buttonVerbindungsmanager.Location = new System.Drawing.Point(188, 11);
            this.buttonVerbindungsmanager.Name = "buttonVerbindungsmanager";
            this.buttonVerbindungsmanager.Size = new System.Drawing.Size(143, 28);
            this.buttonVerbindungsmanager.TabIndex = 8;
            this.buttonVerbindungsmanager.Text = "Verbindungsmanager";
            this.buttonVerbindungsmanager.UseVisualStyleBackColor = true;
            this.buttonVerbindungsmanager.Click += new System.EventHandler(this.buttonVerbindungsmanager_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelConnection});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(834, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelConnection
            // 
            this.toolStripStatusLabelConnection.Name = "toolStripStatusLabelConnection";
            this.toolStripStatusLabelConnection.Size = new System.Drawing.Size(96, 17);
            this.toolStripStatusLabelConnection.Text = "Nicht verbunden";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // userControlAktDaten1
            // 
            this.userControlAktDaten1.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlAktDaten1.Location = new System.Drawing.Point(41, 57);
            this.userControlAktDaten1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlAktDaten1.Name = "userControlAktDaten1";
            this.userControlAktDaten1.Size = new System.Drawing.Size(737, 371);
            this.userControlAktDaten1.TabIndex = 18;
            this.userControlAktDaten1.Visible = false;
            // 
            // userControlConnectionManager1
            // 
            this.userControlConnectionManager1.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlConnectionManager1.Location = new System.Drawing.Point(41, 57);
            this.userControlConnectionManager1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlConnectionManager1.Name = "userControlConnectionManager1";
            this.userControlConnectionManager1.Size = new System.Drawing.Size(739, 373);
            this.userControlConnectionManager1.TabIndex = 16;
            this.userControlConnectionManager1.Visible = false;
            // 
            // userControlStartseite1
            // 
            this.userControlStartseite1.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlStartseite1.Location = new System.Drawing.Point(41, 57);
            this.userControlStartseite1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlStartseite1.Name = "userControlStartseite1";
            this.userControlStartseite1.Size = new System.Drawing.Size(739, 373);
            this.userControlStartseite1.TabIndex = 15;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.userControlAktDaten1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.userControlConnectionManager1);
            this.Controls.Add(this.userControlStartseite1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEinstellungen);
            this.Controls.Add(this.buttonStartseite);
            this.Controls.Add(this.buttonDatenarchiv);
            this.Controls.Add(this.buttonAktDaten);
            this.Controls.Add(this.buttonVerbindungsmanager);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperaturdisplay";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonEinstellungen;
        private System.Windows.Forms.Button buttonStartseite;
        private System.Windows.Forms.Button buttonDatenarchiv;
        private System.Windows.Forms.Button buttonAktDaten;
        private System.Windows.Forms.Button buttonVerbindungsmanager;
        private UserControlStartseite userControlStartseite1;
        private UserControlConnectionManager userControlConnectionManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConnection;
        private System.Windows.Forms.Timer timer1;
        private UserControlAktDaten userControlAktDaten1;
    }
}

