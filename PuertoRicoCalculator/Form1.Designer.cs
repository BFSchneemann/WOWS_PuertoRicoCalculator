namespace PuertoRicoCalculator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCalc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.numPPM = new System.Windows.Forms.NumericUpDown();
            this.numTarget = new System.Windows.Forms.NumericUpDown();
            this.numCurrentPoints = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemainingDateTime = new System.Windows.Forms.TextBox();
            this.txtNeededTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPPMMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentPoints)).BeginInit();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Punkte pro Minute (PPM):";
            // 
            // cmdCalc
            // 
            this.cmdCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCalc.Location = new System.Drawing.Point(16, 377);
            this.cmdCalc.Name = "cmdCalc";
            this.cmdCalc.Size = new System.Drawing.Size(158, 42);
            this.cmdCalc.TabIndex = 1;
            this.cmdCalc.Text = "Berechnen";
            this.cmdCalc.UseVisualStyleBackColor = true;
            this.cmdCalc.Click += new System.EventHandler(this.CmdCalc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aktueller Punktestand:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.endTimePicker);
            this.groupBox1.Controls.Add(this.endDatePicker);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 139);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ende des Events";
            // 
            // endTimePicker
            // 
            this.endTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTimePicker.Location = new System.Drawing.Point(364, 67);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(186, 26);
            this.endTimePicker.TabIndex = 7;
            this.endTimePicker.Value = new System.DateTime(2020, 1, 14, 6, 0, 0, 0);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePicker.Location = new System.Drawing.Point(21, 67);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(327, 26);
            this.endDatePicker.TabIndex = 6;
            this.endDatePicker.Value = new System.DateTime(2020, 1, 14, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(459, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gesamtpunktzahl (Ziel):";
            // 
            // numPPM
            // 
            this.numPPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPPM.Location = new System.Drawing.Point(16, 52);
            this.numPPM.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numPPM.Name = "numPPM";
            this.numPPM.Size = new System.Drawing.Size(378, 29);
            this.numPPM.TabIndex = 8;
            this.numPPM.ThousandsSeparator = true;
            this.numPPM.Value = new decimal(new int[] {
            236,
            0,
            0,
            0});
            // 
            // numTarget
            // 
            this.numTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTarget.Location = new System.Drawing.Point(463, 52);
            this.numTarget.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numTarget.Name = "numTarget";
            this.numTarget.Size = new System.Drawing.Size(346, 29);
            this.numTarget.TabIndex = 9;
            this.numTarget.ThousandsSeparator = true;
            this.numTarget.Value = new decimal(new int[] {
            51300000,
            0,
            0,
            0});
            // 
            // numCurrentPoints
            // 
            this.numCurrentPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCurrentPoints.Location = new System.Drawing.Point(16, 156);
            this.numCurrentPoints.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numCurrentPoints.Name = "numCurrentPoints";
            this.numCurrentPoints.Size = new System.Drawing.Size(378, 29);
            this.numCurrentPoints.TabIndex = 10;
            this.numCurrentPoints.ThousandsSeparator = true;
            this.numCurrentPoints.Value = new decimal(new int[] {
            1345000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "verbleibende Zeit:";
            // 
            // txtRemainingDateTime
            // 
            this.txtRemainingDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemainingDateTime.Location = new System.Drawing.Point(400, 374);
            this.txtRemainingDateTime.Name = "txtRemainingDateTime";
            this.txtRemainingDateTime.Size = new System.Drawing.Size(396, 29);
            this.txtRemainingDateTime.TabIndex = 12;
            // 
            // txtNeededTime
            // 
            this.txtNeededTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNeededTime.Location = new System.Drawing.Point(400, 409);
            this.txtNeededTime.Name = "txtNeededTime";
            this.txtNeededTime.Size = new System.Drawing.Size(396, 29);
            this.txtNeededTime.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(250, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "benötigte Zeit:";
            // 
            // txtPPMMin
            // 
            this.txtPPMMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPPMMin.Location = new System.Drawing.Point(400, 444);
            this.txtPPMMin.Name = "txtPPMMin";
            this.txtPPMMin.Size = new System.Drawing.Size(396, 29);
            this.txtPPMMin.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "PPM zum Erreichen (mindestens):";
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(821, 24);
            this.menuMain.TabIndex = 17;
            this.menuMain.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speichernToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.SpeichernToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 489);
            this.Controls.Add(this.txtPPMMin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNeededTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRemainingDateTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numCurrentPoints);
            this.Controls.Add(this.numTarget);
            this.Controls.Add(this.numPPM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdCalc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "Form1";
            this.Text = "Punkterechner";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentPoints)).EndInit();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdCalc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numPPM;
        private System.Windows.Forms.NumericUpDown numTarget;
        private System.Windows.Forms.NumericUpDown numCurrentPoints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRemainingDateTime;
        private System.Windows.Forms.TextBox txtNeededTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPPMMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
    }
}

