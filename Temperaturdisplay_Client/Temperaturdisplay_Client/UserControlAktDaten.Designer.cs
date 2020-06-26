namespace Temperaturdisplay_Client
{
    partial class UserControlAktDaten
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTempAkt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.listBoxTemp = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxDate = new System.Windows.Forms.ListBox();
            this.listBoxTime = new System.Windows.Forms.ListBox();
            this.listBoxID = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 48);
            this.label1.TabIndex = 8;
            this.label1.Text = "Aktuelle Daten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Temperatur im Moment: ";
            // 
            // labelTempAkt
            // 
            this.labelTempAkt.AutoSize = true;
            this.labelTempAkt.Font = new System.Drawing.Font("PMingLiU-ExtB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempAkt.Location = new System.Drawing.Point(553, 65);
            this.labelTempAkt.Name = "labelTempAkt";
            this.labelTempAkt.Size = new System.Drawing.Size(72, 35);
            this.labelTempAkt.TabIndex = 10;
            this.labelTempAkt.Text = "--.--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(618, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "°C";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(605, 312);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(119, 47);
            this.buttonStart.TabIndex = 12;
            this.buttonStart.Text = "Aufzeichnung starten";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // listBoxTemp
            // 
            this.listBoxTemp.FormattingEnabled = true;
            this.listBoxTemp.ItemHeight = 16;
            this.listBoxTemp.Location = new System.Drawing.Point(127, 128);
            this.listBoxTemp.Name = "listBoxTemp";
            this.listBoxTemp.Size = new System.Drawing.Size(89, 212);
            this.listBoxTemp.TabIndex = 13;
            this.listBoxTemp.SelectedIndexChanged += new System.EventHandler(this.listBoxTemp_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Aufzeichnung";
            // 
            // listBoxDate
            // 
            this.listBoxDate.FormattingEnabled = true;
            this.listBoxDate.ItemHeight = 16;
            this.listBoxDate.Location = new System.Drawing.Point(215, 128);
            this.listBoxDate.Name = "listBoxDate";
            this.listBoxDate.Size = new System.Drawing.Size(102, 212);
            this.listBoxDate.TabIndex = 15;
            this.listBoxDate.SelectedIndexChanged += new System.EventHandler(this.listBoxDate_SelectedIndexChanged);
            // 
            // listBoxTime
            // 
            this.listBoxTime.FormattingEnabled = true;
            this.listBoxTime.ItemHeight = 16;
            this.listBoxTime.Location = new System.Drawing.Point(316, 128);
            this.listBoxTime.Name = "listBoxTime";
            this.listBoxTime.Size = new System.Drawing.Size(90, 212);
            this.listBoxTime.TabIndex = 16;
            this.listBoxTime.SelectedIndexChanged += new System.EventHandler(this.listBoxTime_SelectedIndexChanged);
            // 
            // listBoxID
            // 
            this.listBoxID.FormattingEnabled = true;
            this.listBoxID.ItemHeight = 16;
            this.listBoxID.Location = new System.Drawing.Point(40, 128);
            this.listBoxID.Name = "listBoxID";
            this.listBoxID.Size = new System.Drawing.Size(88, 212);
            this.listBoxID.TabIndex = 17;
            this.listBoxID.SelectedIndexChanged += new System.EventHandler(this.listBoxID_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 3500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(410, 128);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(38, 28);
            this.buttonDel.TabIndex = 18;
            this.buttonDel.Text = "X";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // UserControlAktDaten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.listBoxID);
            this.Controls.Add(this.listBoxTime);
            this.Controls.Add(this.listBoxDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxTemp);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTempAkt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlAktDaten";
            this.Size = new System.Drawing.Size(739, 373);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTempAkt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ListBox listBoxTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxDate;
        private System.Windows.Forms.ListBox listBoxTime;
        private System.Windows.Forms.ListBox listBoxID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonDel;
    }
}
