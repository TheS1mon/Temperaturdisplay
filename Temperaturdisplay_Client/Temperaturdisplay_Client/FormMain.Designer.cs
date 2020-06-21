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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonVerbindungsmanager = new System.Windows.Forms.Button();
            this.buttonAktDaten = new System.Windows.Forms.Button();
            this.buttonDatenarchiv = new System.Windows.Forms.Button();
            this.buttonStartseite = new System.Windows.Forms.Button();
            this.buttonEinstellungen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControlStartseite1 = new Temperaturdisplay_Client.UserControlStartseite();
            this.userControlVerbindungsmanager1 = new Temperaturdisplay_Client.UserControlVerbindungsmanager(controller);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(96, 17);
            this.toolStripStatusLabelStatus.Text = "Nicht verbunden";
            // 
            // buttonVerbindungsmanager
            // 
            this.buttonVerbindungsmanager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerbindungsmanager.ForeColor = System.Drawing.Color.Black;
            this.buttonVerbindungsmanager.Location = new System.Drawing.Point(179, 12);
            this.buttonVerbindungsmanager.Name = "buttonVerbindungsmanager";
            this.buttonVerbindungsmanager.Size = new System.Drawing.Size(143, 28);
            this.buttonVerbindungsmanager.TabIndex = 2;
            this.buttonVerbindungsmanager.Text = "Verbindungsmanager";
            this.buttonVerbindungsmanager.UseVisualStyleBackColor = true;
            this.buttonVerbindungsmanager.Click += new System.EventHandler(this.buttonVerbindungsmanager_Click);
            // 
            // buttonAktDaten
            // 
            this.buttonAktDaten.Enabled = false;
            this.buttonAktDaten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAktDaten.ForeColor = System.Drawing.Color.DimGray;
            this.buttonAktDaten.Location = new System.Drawing.Point(328, 12);
            this.buttonAktDaten.Name = "buttonAktDaten";
            this.buttonAktDaten.Size = new System.Drawing.Size(143, 28);
            this.buttonAktDaten.TabIndex = 3;
            this.buttonAktDaten.Text = "Aktuelle Daten";
            this.buttonAktDaten.UseVisualStyleBackColor = true;
            this.buttonAktDaten.Click += new System.EventHandler(this.buttonAktDaten_Click);
            // 
            // buttonDatenarchiv
            // 
            this.buttonDatenarchiv.Enabled = false;
            this.buttonDatenarchiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDatenarchiv.ForeColor = System.Drawing.Color.DimGray;
            this.buttonDatenarchiv.Location = new System.Drawing.Point(477, 12);
            this.buttonDatenarchiv.Name = "buttonDatenarchiv";
            this.buttonDatenarchiv.Size = new System.Drawing.Size(143, 28);
            this.buttonDatenarchiv.TabIndex = 4;
            this.buttonDatenarchiv.Text = "Datenarchiv";
            this.buttonDatenarchiv.UseVisualStyleBackColor = true;
            this.buttonDatenarchiv.Click += new System.EventHandler(this.buttonDatenarchiv_Click);
            // 
            // buttonStartseite
            // 
            this.buttonStartseite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartseite.ForeColor = System.Drawing.Color.Olive;
            this.buttonStartseite.Location = new System.Drawing.Point(30, 12);
            this.buttonStartseite.Name = "buttonStartseite";
            this.buttonStartseite.Size = new System.Drawing.Size(143, 28);
            this.buttonStartseite.TabIndex = 5;
            this.buttonStartseite.Text = "Startseite";
            this.buttonStartseite.UseVisualStyleBackColor = true;
            this.buttonStartseite.Click += new System.EventHandler(this.buttonStartseite_Click);
            // 
            // buttonEinstellungen
            // 
            this.buttonEinstellungen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEinstellungen.ForeColor = System.Drawing.Color.Black;
            this.buttonEinstellungen.Location = new System.Drawing.Point(626, 12);
            this.buttonEinstellungen.Name = "buttonEinstellungen";
            this.buttonEinstellungen.Size = new System.Drawing.Size(143, 28);
            this.buttonEinstellungen.TabIndex = 6;
            this.buttonEinstellungen.Text = "Einstellungen";
            this.buttonEinstellungen.UseVisualStyleBackColor = true;
            this.buttonEinstellungen.Click += new System.EventHandler(this.buttonEinstellungen_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-15, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 1);
            this.panel1.TabIndex = 7;
            // 
            // userControlStartseite1
            // 
            this.userControlStartseite1.BackColor = System.Drawing.SystemColors.Control;
            this.userControlStartseite1.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlStartseite1.Location = new System.Drawing.Point(7, 56);
            this.userControlStartseite1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlStartseite1.Name = "userControlStartseite1";
            this.userControlStartseite1.Size = new System.Drawing.Size(786, 365);
            this.userControlStartseite1.TabIndex = 8;
            // 
            // userControlVerbindungsmanager1
            // 
            this.userControlVerbindungsmanager1.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlVerbindungsmanager1.Location = new System.Drawing.Point(7, 56);
            this.userControlVerbindungsmanager1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlVerbindungsmanager1.Name = "userControlVerbindungsmanager1";
            this.userControlVerbindungsmanager1.Size = new System.Drawing.Size(786, 365);
            this.userControlVerbindungsmanager1.TabIndex = 9;
            this.userControlVerbindungsmanager1.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControlVerbindungsmanager1);
            this.Controls.Add(this.userControlStartseite1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEinstellungen);
            this.Controls.Add(this.buttonStartseite);
            this.Controls.Add(this.buttonDatenarchiv);
            this.Controls.Add(this.buttonAktDaten);
            this.Controls.Add(this.buttonVerbindungsmanager);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Temperaturdisplay";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.Button buttonVerbindungsmanager;
        private System.Windows.Forms.Button buttonAktDaten;
        private System.Windows.Forms.Button buttonDatenarchiv;
        private System.Windows.Forms.Button buttonStartseite;
        private System.Windows.Forms.Button buttonEinstellungen;
        private System.Windows.Forms.Panel panel1;
        private UserControlStartseite userControlStartseite1;
        private UserControlVerbindungsmanager userControlVerbindungsmanager1;
    }
}

