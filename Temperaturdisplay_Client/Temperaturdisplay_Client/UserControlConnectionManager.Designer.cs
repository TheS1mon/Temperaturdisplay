namespace Temperaturdisplay_Client
{
    partial class UserControlConnectionManager
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFehlgeschlagen = new System.Windows.Forms.Label();
            this.labelErfolgreich = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "Verbindungsmanager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(605, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hier können Sie die erforderlichen Verbindungsdaten eingeben und eine Verbindung " +
    "herstellen";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelFehlgeschlagen);
            this.panel1.Controls.Add(this.labelErfolgreich);
            this.panel1.Controls.Add(this.pictureBoxLoading);
            this.panel1.Controls.Add(this.buttonConnect);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxPort);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxIP);
            this.panel1.Location = new System.Drawing.Point(38, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 117);
            this.panel1.TabIndex = 15;
            // 
            // labelFehlgeschlagen
            // 
            this.labelFehlgeschlagen.AutoSize = true;
            this.labelFehlgeschlagen.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFehlgeschlagen.Location = new System.Drawing.Point(354, 87);
            this.labelFehlgeschlagen.Name = "labelFehlgeschlagen";
            this.labelFehlgeschlagen.Size = new System.Drawing.Size(84, 13);
            this.labelFehlgeschlagen.TabIndex = 17;
            this.labelFehlgeschlagen.Text = "Fehlgeschlagen!";
            this.labelFehlgeschlagen.Visible = false;
            // 
            // labelErfolgreich
            // 
            this.labelErfolgreich.AutoSize = true;
            this.labelErfolgreich.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErfolgreich.Location = new System.Drawing.Point(374, 87);
            this.labelErfolgreich.Name = "labelErfolgreich";
            this.labelErfolgreich.Size = new System.Drawing.Size(64, 13);
            this.labelErfolgreich.TabIndex = 16;
            this.labelErfolgreich.Text = "Erfolgreich!";
            this.labelErfolgreich.Visible = false;
            // 
            // buttonConnect
            // 
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Location = new System.Drawing.Point(444, 79);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(167, 27);
            this.buttonConnect.TabIndex = 12;
            this.buttonConnect.Text = "Verbindung herstellen";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "IP-Adresse:";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(106, 60);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(57, 27);
            this.textBoxPort.TabIndex = 11;
            this.textBoxPort.Text = "11000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Port:";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(106, 27);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(119, 27);
            this.textBoxIP.TabIndex = 7;
            this.textBoxIP.Text = "10.10.0.194";
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Image = global::Temperaturdisplay_Client.Properties.Resources.Loadingwheel;
            this.pictureBoxLoading.Location = new System.Drawing.Point(411, 79);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoading.TabIndex = 15;
            this.pictureBoxLoading.TabStop = false;
            this.pictureBoxLoading.Visible = false;
            // 
            // UserControlConnectionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControlConnectionManager";
            this.Size = new System.Drawing.Size(741, 375);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFehlgeschlagen;
        private System.Windows.Forms.Label labelErfolgreich;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIP;
    }
}
