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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEinstellungen = new System.Windows.Forms.Button();
            this.buttonStartseite = new System.Windows.Forms.Button();
            this.buttonDatenarchiv = new System.Windows.Forms.Button();
            this.buttonAktDaten = new System.Windows.Forms.Button();
            this.buttonVerbindungsmanager = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-8, 61);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 1);
            this.panel1.TabIndex = 13;
            // 
            // buttonEinstellungen
            // 
            this.buttonEinstellungen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEinstellungen.ForeColor = System.Drawing.Color.Black;
            this.buttonEinstellungen.Location = new System.Drawing.Point(847, 13);
            this.buttonEinstellungen.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEinstellungen.Name = "buttonEinstellungen";
            this.buttonEinstellungen.Size = new System.Drawing.Size(191, 34);
            this.buttonEinstellungen.TabIndex = 12;
            this.buttonEinstellungen.Text = "Einstellungen";
            this.buttonEinstellungen.UseVisualStyleBackColor = true;
            this.buttonEinstellungen.Click += new System.EventHandler(this.buttonEinstellungen_Click);
            // 
            // buttonStartseite
            // 
            this.buttonStartseite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartseite.ForeColor = System.Drawing.Color.Olive;
            this.buttonStartseite.Location = new System.Drawing.Point(52, 13);
            this.buttonStartseite.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartseite.Name = "buttonStartseite";
            this.buttonStartseite.Size = new System.Drawing.Size(191, 34);
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
            this.buttonDatenarchiv.Location = new System.Drawing.Point(648, 13);
            this.buttonDatenarchiv.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDatenarchiv.Name = "buttonDatenarchiv";
            this.buttonDatenarchiv.Size = new System.Drawing.Size(191, 34);
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
            this.buttonAktDaten.Location = new System.Drawing.Point(449, 13);
            this.buttonAktDaten.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAktDaten.Name = "buttonAktDaten";
            this.buttonAktDaten.Size = new System.Drawing.Size(191, 34);
            this.buttonAktDaten.TabIndex = 9;
            this.buttonAktDaten.Text = "Aktuelle Daten";
            this.buttonAktDaten.UseVisualStyleBackColor = true;
            this.buttonAktDaten.Click += new System.EventHandler(this.buttonAktDaten_Click);
            // 
            // buttonVerbindungsmanager
            // 
            this.buttonVerbindungsmanager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerbindungsmanager.ForeColor = System.Drawing.Color.Black;
            this.buttonVerbindungsmanager.Location = new System.Drawing.Point(251, 13);
            this.buttonVerbindungsmanager.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVerbindungsmanager.Name = "buttonVerbindungsmanager";
            this.buttonVerbindungsmanager.Size = new System.Drawing.Size(191, 34);
            this.buttonVerbindungsmanager.TabIndex = 8;
            this.buttonVerbindungsmanager.Text = "Verbindungsmanager";
            this.buttonVerbindungsmanager.UseVisualStyleBackColor = true;
            this.buttonVerbindungsmanager.Click += new System.EventHandler(this.buttonVerbindungsmanager_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 614);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1112, 26);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(118, 20);
            this.toolStripStatusLabelStatus.Text = "Nicht verbunden";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 640);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEinstellungen);
            this.Controls.Add(this.buttonStartseite);
            this.Controls.Add(this.buttonDatenarchiv);
            this.Controls.Add(this.buttonAktDaten);
            this.Controls.Add(this.buttonVerbindungsmanager);
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
    }
}

