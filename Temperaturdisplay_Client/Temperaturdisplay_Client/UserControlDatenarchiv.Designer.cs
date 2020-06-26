namespace Temperaturdisplay_Client
{
    partial class UserControlDatenarchiv
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
            this.buttonDel = new System.Windows.Forms.Button();
            this.listBoxID = new System.Windows.Forms.ListBox();
            this.listBoxTime = new System.Windows.Forms.ListBox();
            this.listBoxDate = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxTemp = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFirstDate = new System.Windows.Forms.TextBox();
            this.textBoxLastDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxLastTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFirstTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxToday = new System.Windows.Forms.CheckBox();
            this.checkBoxAllDay = new System.Windows.Forms.CheckBox();
            this.buttonPlot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 48);
            this.label1.TabIndex = 9;
            this.label1.Text = "Datenarchiv";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(40, 344);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(366, 24);
            this.buttonDel.TabIndex = 24;
            this.buttonDel.Text = "Ausgewählten Eintrag löschen";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // listBoxID
            // 
            this.listBoxID.FormattingEnabled = true;
            this.listBoxID.ItemHeight = 16;
            this.listBoxID.Location = new System.Drawing.Point(40, 128);
            this.listBoxID.Name = "listBoxID";
            this.listBoxID.Size = new System.Drawing.Size(88, 212);
            this.listBoxID.TabIndex = 23;
            this.listBoxID.SelectedIndexChanged += new System.EventHandler(this.listBoxID_SelectedIndexChanged);
            // 
            // listBoxTime
            // 
            this.listBoxTime.FormattingEnabled = true;
            this.listBoxTime.ItemHeight = 16;
            this.listBoxTime.Location = new System.Drawing.Point(316, 128);
            this.listBoxTime.Name = "listBoxTime";
            this.listBoxTime.Size = new System.Drawing.Size(90, 212);
            this.listBoxTime.TabIndex = 22;
            this.listBoxTime.SelectedIndexChanged += new System.EventHandler(this.listBoxTime_SelectedIndexChanged);
            // 
            // listBoxDate
            // 
            this.listBoxDate.FormattingEnabled = true;
            this.listBoxDate.ItemHeight = 16;
            this.listBoxDate.Location = new System.Drawing.Point(215, 128);
            this.listBoxDate.Name = "listBoxDate";
            this.listBoxDate.Size = new System.Drawing.Size(102, 212);
            this.listBoxDate.TabIndex = 21;
            this.listBoxDate.SelectedIndexChanged += new System.EventHandler(this.listBoxDate_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Angeforderte Daten";
            // 
            // listBoxTemp
            // 
            this.listBoxTemp.FormattingEnabled = true;
            this.listBoxTemp.ItemHeight = 16;
            this.listBoxTemp.Location = new System.Drawing.Point(127, 128);
            this.listBoxTemp.Name = "listBoxTemp";
            this.listBoxTemp.Size = new System.Drawing.Size(89, 212);
            this.listBoxTemp.TabIndex = 19;
            this.listBoxTemp.SelectedIndexChanged += new System.EventHandler(this.listBoxTemp_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Von:";
            // 
            // textBoxFirstDate
            // 
            this.textBoxFirstDate.Location = new System.Drawing.Point(499, 131);
            this.textBoxFirstDate.Name = "textBoxFirstDate";
            this.textBoxFirstDate.Size = new System.Drawing.Size(231, 27);
            this.textBoxFirstDate.TabIndex = 27;
            // 
            // textBoxLastDate
            // 
            this.textBoxLastDate.Location = new System.Drawing.Point(499, 164);
            this.textBoxLastDate.Name = "textBoxLastDate";
            this.textBoxLastDate.Size = new System.Drawing.Size(231, 27);
            this.textBoxLastDate.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Bis:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(645, 314);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(85, 26);
            this.buttonSearch.TabIndex = 30;
            this.buttonSearch.Text = "Suchen";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxLastTime
            // 
            this.textBoxLastTime.Location = new System.Drawing.Point(499, 267);
            this.textBoxLastTime.Name = "textBoxLastTime";
            this.textBoxLastTime.Size = new System.Drawing.Size(231, 27);
            this.textBoxLastTime.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Bis:";
            // 
            // textBoxFirstTime
            // 
            this.textBoxFirstTime.Location = new System.Drawing.Point(499, 234);
            this.textBoxFirstTime.Name = "textBoxFirstTime";
            this.textBoxFirstTime.Size = new System.Drawing.Size(231, 27);
            this.textBoxFirstTime.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Von:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Datum (yyyy-mm-dd):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(449, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Uhrzeit (hh-mm-ss):";
            // 
            // checkBoxToday
            // 
            this.checkBoxToday.AutoSize = true;
            this.checkBoxToday.Location = new System.Drawing.Point(630, 108);
            this.checkBoxToday.Name = "checkBoxToday";
            this.checkBoxToday.Size = new System.Drawing.Size(64, 20);
            this.checkBoxToday.TabIndex = 37;
            this.checkBoxToday.Text = "Heute";
            this.checkBoxToday.UseVisualStyleBackColor = true;
            this.checkBoxToday.CheckedChanged += new System.EventHandler(this.checkBoxToday_CheckedChanged);
            // 
            // checkBoxAllDay
            // 
            this.checkBoxAllDay.AutoSize = true;
            this.checkBoxAllDay.Location = new System.Drawing.Point(630, 211);
            this.checkBoxAllDay.Name = "checkBoxAllDay";
            this.checkBoxAllDay.Size = new System.Drawing.Size(100, 20);
            this.checkBoxAllDay.TabIndex = 38;
            this.checkBoxAllDay.Text = "Ganzer Tag";
            this.checkBoxAllDay.UseVisualStyleBackColor = true;
            this.checkBoxAllDay.CheckedChanged += new System.EventHandler(this.checkBoxAllDay_CheckedChanged);
            // 
            // buttonPlot
            // 
            this.buttonPlot.Location = new System.Drawing.Point(554, 314);
            this.buttonPlot.Name = "buttonPlot";
            this.buttonPlot.Size = new System.Drawing.Size(85, 26);
            this.buttonPlot.TabIndex = 39;
            this.buttonPlot.Text = "Plotten";
            this.buttonPlot.UseVisualStyleBackColor = true;
            this.buttonPlot.Click += new System.EventHandler(this.buttonPlot_Click);
            // 
            // UserControlDatenarchiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonPlot);
            this.Controls.Add(this.checkBoxAllDay);
            this.Controls.Add(this.checkBoxToday);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxLastTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFirstTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxLastDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFirstDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.listBoxID);
            this.Controls.Add(this.listBoxTime);
            this.Controls.Add(this.listBoxDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxTemp);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlDatenarchiv";
            this.Size = new System.Drawing.Size(739, 373);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ListBox listBoxID;
        private System.Windows.Forms.ListBox listBoxTime;
        private System.Windows.Forms.ListBox listBoxDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFirstDate;
        private System.Windows.Forms.TextBox textBoxLastDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxLastTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFirstTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxToday;
        private System.Windows.Forms.CheckBox checkBoxAllDay;
        private System.Windows.Forms.Button buttonPlot;
    }
}
