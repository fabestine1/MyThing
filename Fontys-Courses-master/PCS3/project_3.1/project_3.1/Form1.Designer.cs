namespace project_3._1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxFamily = new System.Windows.Forms.ListBox();
            this.lblDayOfTheWeek = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.btnGoodMorning = new System.Windows.Forms.Button();
            this.btnGoodNight = new System.Windows.Forms.Button();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDay = new System.Windows.Forms.NumericUpDown();
            this.lblMyFamily = new System.Windows.Forms.Label();
            this.lblGoodMorning = new System.Windows.Forms.Label();
            this.lblGoodNight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxFamily
            // 
            this.lbxFamily.FormattingEnabled = true;
            this.lbxFamily.Location = new System.Drawing.Point(12, 24);
            this.lbxFamily.Name = "lbxFamily";
            this.lbxFamily.Size = new System.Drawing.Size(120, 95);
            this.lbxFamily.TabIndex = 0;
            // 
            // lblDayOfTheWeek
            // 
            this.lblDayOfTheWeek.AutoSize = true;
            this.lblDayOfTheWeek.Location = new System.Drawing.Point(146, 26);
            this.lblDayOfTheWeek.Name = "lblDayOfTheWeek";
            this.lblDayOfTheWeek.Size = new System.Drawing.Size(137, 13);
            this.lblDayOfTheWeek.TabIndex = 1;
            this.lblDayOfTheWeek.Text = "day of the week (1, 2, ..., 7)";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(172, 69);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(111, 13);
            this.lblHours.TabIndex = 3;
            this.lblHours.Text = "hours (1, 2, ..., 23, 24)";
            // 
            // btnGoodMorning
            // 
            this.btnGoodMorning.Location = new System.Drawing.Point(339, 21);
            this.btnGoodMorning.Name = "btnGoodMorning";
            this.btnGoodMorning.Size = new System.Drawing.Size(109, 23);
            this.btnGoodMorning.TabIndex = 4;
            this.btnGoodMorning.Text = "Good morning";
            this.btnGoodMorning.UseVisualStyleBackColor = true;
            this.btnGoodMorning.Click += new System.EventHandler(this.btnGoodMorning_Click);
            // 
            // btnGoodNight
            // 
            this.btnGoodNight.Location = new System.Drawing.Point(339, 64);
            this.btnGoodNight.Name = "btnGoodNight";
            this.btnGoodNight.Size = new System.Drawing.Size(109, 23);
            this.btnGoodNight.TabIndex = 5;
            this.btnGoodNight.Text = "Good night";
            this.btnGoodNight.UseVisualStyleBackColor = true;
            this.btnGoodNight.Click += new System.EventHandler(this.btnGoodNight_Click);
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Location = new System.Drawing.Point(289, 67);
            this.numericUpDownHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(34, 20);
            this.numericUpDownHours.TabIndex = 6;
            // 
            // numericUpDownDay
            // 
            this.numericUpDownDay.Location = new System.Drawing.Point(289, 24);
            this.numericUpDownDay.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDay.Name = "numericUpDownDay";
            this.numericUpDownDay.Size = new System.Drawing.Size(34, 20);
            this.numericUpDownDay.TabIndex = 7;
            this.numericUpDownDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMyFamily
            // 
            this.lblMyFamily.AutoSize = true;
            this.lblMyFamily.Location = new System.Drawing.Point(12, 8);
            this.lblMyFamily.Name = "lblMyFamily";
            this.lblMyFamily.Size = new System.Drawing.Size(49, 13);
            this.lblMyFamily.TabIndex = 8;
            this.lblMyFamily.Text = "my family";
            // 
            // lblGoodMorning
            // 
            this.lblGoodMorning.AutoSize = true;
            this.lblGoodMorning.Location = new System.Drawing.Point(466, 26);
            this.lblGoodMorning.Name = "lblGoodMorning";
            this.lblGoodMorning.Size = new System.Drawing.Size(0, 13);
            this.lblGoodMorning.TabIndex = 9;
            // 
            // lblGoodNight
            // 
            this.lblGoodNight.AutoSize = true;
            this.lblGoodNight.Location = new System.Drawing.Point(466, 69);
            this.lblGoodNight.Name = "lblGoodNight";
            this.lblGoodNight.Size = new System.Drawing.Size(0, 13);
            this.lblGoodNight.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 141);
            this.Controls.Add(this.lblGoodNight);
            this.Controls.Add(this.lblGoodMorning);
            this.Controls.Add(this.lblMyFamily);
            this.Controls.Add(this.numericUpDownDay);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.btnGoodNight);
            this.Controls.Add(this.btnGoodMorning);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblDayOfTheWeek);
            this.Controls.Add(this.lbxFamily);
            this.Name = "Form1";
            this.Text = "Family Form";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxFamily;
        private System.Windows.Forms.Label lblDayOfTheWeek;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Button btnGoodMorning;
        private System.Windows.Forms.Button btnGoodNight;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.NumericUpDown numericUpDownDay;
        private System.Windows.Forms.Label lblMyFamily;
        private System.Windows.Forms.Label lblGoodMorning;
        private System.Windows.Forms.Label lblGoodNight;
    }
}

