namespace _4._3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.lbSettings = new System.Windows.Forms.Label();
            this.lbMaxValue = new System.Windows.Forms.Label();
            this.lbMaxDrawn = new System.Windows.Forms.Label();
            this.tbMaxValue = new System.Windows.Forms.TextBox();
            this.tbMaxDrawn = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.lsbDrawnNumbers = new System.Windows.Forms.ListBox();
            this.btnTimer = new System.Windows.Forms.Button();
            this.tmDraw = new System.Windows.Forms.Timer(this.components);
            this.pbNumber = new System.Windows.Forms.PictureBox();
            this.ilNumbers = new System.Windows.Forms.ImageList(this.components);
            this.tmRandom = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(54, 137);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(186, 33);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbSettings
            // 
            this.lbSettings.AutoSize = true;
            this.lbSettings.Location = new System.Drawing.Point(51, 31);
            this.lbSettings.Name = "lbSettings";
            this.lbSettings.Size = new System.Drawing.Size(68, 16);
            this.lbSettings.TabIndex = 1;
            this.lbSettings.Text = "Settings:";
            // 
            // lbMaxValue
            // 
            this.lbMaxValue.AutoSize = true;
            this.lbMaxValue.Location = new System.Drawing.Point(51, 69);
            this.lbMaxValue.Name = "lbMaxValue";
            this.lbMaxValue.Size = new System.Drawing.Size(80, 16);
            this.lbMaxValue.TabIndex = 2;
            this.lbMaxValue.Text = "Max Value";
            // 
            // lbMaxDrawn
            // 
            this.lbMaxDrawn.AutoSize = true;
            this.lbMaxDrawn.Location = new System.Drawing.Point(51, 107);
            this.lbMaxDrawn.Name = "lbMaxDrawn";
            this.lbMaxDrawn.Size = new System.Drawing.Size(83, 16);
            this.lbMaxDrawn.TabIndex = 3;
            this.lbMaxDrawn.Text = "Max Drawn";
            // 
            // tbMaxValue
            // 
            this.tbMaxValue.Location = new System.Drawing.Point(140, 66);
            this.tbMaxValue.Name = "tbMaxValue";
            this.tbMaxValue.Size = new System.Drawing.Size(100, 22);
            this.tbMaxValue.TabIndex = 4;
            // 
            // tbMaxDrawn
            // 
            this.tbMaxDrawn.Location = new System.Drawing.Point(140, 104);
            this.tbMaxDrawn.Name = "tbMaxDrawn";
            this.tbMaxDrawn.Size = new System.Drawing.Size(100, 22);
            this.tbMaxDrawn.TabIndex = 5;
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(54, 176);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(186, 33);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Draw Next Number";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAll
            // 
            this.btnAll.Enabled = false;
            this.btnAll.Location = new System.Drawing.Point(54, 215);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(186, 33);
            this.btnAll.TabIndex = 7;
            this.btnAll.Text = "Draw All Numbers";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // lsbDrawnNumbers
            // 
            this.lsbDrawnNumbers.ForeColor = System.Drawing.Color.Teal;
            this.lsbDrawnNumbers.FormattingEnabled = true;
            this.lsbDrawnNumbers.ItemHeight = 16;
            this.lsbDrawnNumbers.Location = new System.Drawing.Point(536, 31);
            this.lsbDrawnNumbers.Name = "lsbDrawnNumbers";
            this.lsbDrawnNumbers.Size = new System.Drawing.Size(141, 260);
            this.lsbDrawnNumbers.TabIndex = 8;
            // 
            // btnTimer
            // 
            this.btnTimer.Enabled = false;
            this.btnTimer.Location = new System.Drawing.Point(54, 254);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(186, 33);
            this.btnTimer.TabIndex = 9;
            this.btnTimer.Text = "Use timer";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // tmDraw
            // 
            this.tmDraw.Tick += new System.EventHandler(this.tmDraw_Tick);
            // 
            // pbNumber
            // 
            this.pbNumber.Location = new System.Drawing.Point(261, 31);
            this.pbNumber.Name = "pbNumber";
            this.pbNumber.Size = new System.Drawing.Size(256, 256);
            this.pbNumber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbNumber.TabIndex = 10;
            this.pbNumber.TabStop = false;
            // 
            // ilNumbers
            // 
            this.ilNumbers.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilNumbers.ImageStream")));
            this.ilNumbers.TransparentColor = System.Drawing.Color.Transparent;
            this.ilNumbers.Images.SetKeyName(0, "P00.png");
            this.ilNumbers.Images.SetKeyName(1, "P01.png");
            this.ilNumbers.Images.SetKeyName(2, "P02.png");
            this.ilNumbers.Images.SetKeyName(3, "P03.png");
            this.ilNumbers.Images.SetKeyName(4, "P04.png");
            this.ilNumbers.Images.SetKeyName(5, "P05.png");
            this.ilNumbers.Images.SetKeyName(6, "P06.png");
            this.ilNumbers.Images.SetKeyName(7, "P07.png");
            this.ilNumbers.Images.SetKeyName(8, "P08.png");
            this.ilNumbers.Images.SetKeyName(9, "P09.png");
            this.ilNumbers.Images.SetKeyName(10, "P10.png");
            this.ilNumbers.Images.SetKeyName(11, "P11.png");
            this.ilNumbers.Images.SetKeyName(12, "P12.png");
            this.ilNumbers.Images.SetKeyName(13, "P13.png");
            this.ilNumbers.Images.SetKeyName(14, "P14.png");
            this.ilNumbers.Images.SetKeyName(15, "P15.png");
            this.ilNumbers.Images.SetKeyName(16, "P16.png");
            this.ilNumbers.Images.SetKeyName(17, "P17.png");
            this.ilNumbers.Images.SetKeyName(18, "P18.png");
            this.ilNumbers.Images.SetKeyName(19, "P19.png");
            this.ilNumbers.Images.SetKeyName(20, "P20.png");
            this.ilNumbers.Images.SetKeyName(21, "P21.png");
            this.ilNumbers.Images.SetKeyName(22, "P22.png");
            this.ilNumbers.Images.SetKeyName(23, "P23.png");
            this.ilNumbers.Images.SetKeyName(24, "P24.png");
            this.ilNumbers.Images.SetKeyName(25, "P25.png");
            this.ilNumbers.Images.SetKeyName(26, "P26.png");
            this.ilNumbers.Images.SetKeyName(27, "P27.png");
            this.ilNumbers.Images.SetKeyName(28, "P28.png");
            this.ilNumbers.Images.SetKeyName(29, "P29.png");
            this.ilNumbers.Images.SetKeyName(30, "P30.png");
            this.ilNumbers.Images.SetKeyName(31, "P31.png");
            this.ilNumbers.Images.SetKeyName(32, "P32.png");
            this.ilNumbers.Images.SetKeyName(33, "P33.png");
            this.ilNumbers.Images.SetKeyName(34, "P34.png");
            this.ilNumbers.Images.SetKeyName(35, "P35.png");
            this.ilNumbers.Images.SetKeyName(36, "P36.png");
            this.ilNumbers.Images.SetKeyName(37, "P37.png");
            this.ilNumbers.Images.SetKeyName(38, "P38.png");
            this.ilNumbers.Images.SetKeyName(39, "P39.png");
            this.ilNumbers.Images.SetKeyName(40, "P40.png");
            this.ilNumbers.Images.SetKeyName(41, "P41.png");
            this.ilNumbers.Images.SetKeyName(42, "P42.png");
            this.ilNumbers.Images.SetKeyName(43, "P43.png");
            this.ilNumbers.Images.SetKeyName(44, "P44.png");
            this.ilNumbers.Images.SetKeyName(45, "P45.png");
            this.ilNumbers.Images.SetKeyName(46, "P46.png");
            this.ilNumbers.Images.SetKeyName(47, "P47.png");
            this.ilNumbers.Images.SetKeyName(48, "P48.png");
            this.ilNumbers.Images.SetKeyName(49, "P49.png");
            this.ilNumbers.Images.SetKeyName(50, "P50.png");
            this.ilNumbers.Images.SetKeyName(51, "P51.png");
            this.ilNumbers.Images.SetKeyName(52, "P52.png");
            this.ilNumbers.Images.SetKeyName(53, "P53.png");
            this.ilNumbers.Images.SetKeyName(54, "P54.png");
            this.ilNumbers.Images.SetKeyName(55, "P55.png");
            this.ilNumbers.Images.SetKeyName(56, "P56.png");
            this.ilNumbers.Images.SetKeyName(57, "P57.png");
            this.ilNumbers.Images.SetKeyName(58, "P58.png");
            this.ilNumbers.Images.SetKeyName(59, "P59.png");
            this.ilNumbers.Images.SetKeyName(60, "P60.png");
            this.ilNumbers.Images.SetKeyName(61, "P61.png");
            this.ilNumbers.Images.SetKeyName(62, "P62.png");
            this.ilNumbers.Images.SetKeyName(63, "P63.png");
            this.ilNumbers.Images.SetKeyName(64, "P64.png");
            this.ilNumbers.Images.SetKeyName(65, "P65.png");
            this.ilNumbers.Images.SetKeyName(66, "P66.png");
            this.ilNumbers.Images.SetKeyName(67, "P67.png");
            this.ilNumbers.Images.SetKeyName(68, "P68.png");
            this.ilNumbers.Images.SetKeyName(69, "P69.png");
            this.ilNumbers.Images.SetKeyName(70, "P70.png");
            this.ilNumbers.Images.SetKeyName(71, "P71.png");
            this.ilNumbers.Images.SetKeyName(72, "P72.png");
            this.ilNumbers.Images.SetKeyName(73, "P73.png");
            this.ilNumbers.Images.SetKeyName(74, "P74.png");
            this.ilNumbers.Images.SetKeyName(75, "P75.png");
            this.ilNumbers.Images.SetKeyName(76, "P76.png");
            this.ilNumbers.Images.SetKeyName(77, "P77.png");
            this.ilNumbers.Images.SetKeyName(78, "P78.png");
            this.ilNumbers.Images.SetKeyName(79, "P79.png");
            this.ilNumbers.Images.SetKeyName(80, "P80.png");
            this.ilNumbers.Images.SetKeyName(81, "P81.png");
            this.ilNumbers.Images.SetKeyName(82, "P82.png");
            this.ilNumbers.Images.SetKeyName(83, "P83.png");
            this.ilNumbers.Images.SetKeyName(84, "P84.png");
            this.ilNumbers.Images.SetKeyName(85, "P85.png");
            this.ilNumbers.Images.SetKeyName(86, "P86.png");
            this.ilNumbers.Images.SetKeyName(87, "P87.png");
            this.ilNumbers.Images.SetKeyName(88, "P88.png");
            this.ilNumbers.Images.SetKeyName(89, "P89.png");
            this.ilNumbers.Images.SetKeyName(90, "P90.png");
            this.ilNumbers.Images.SetKeyName(91, "P91.png");
            this.ilNumbers.Images.SetKeyName(92, "P92.png");
            this.ilNumbers.Images.SetKeyName(93, "P93.png");
            this.ilNumbers.Images.SetKeyName(94, "P94.png");
            this.ilNumbers.Images.SetKeyName(95, "P95.png");
            this.ilNumbers.Images.SetKeyName(96, "P96.png");
            this.ilNumbers.Images.SetKeyName(97, "P97.png");
            this.ilNumbers.Images.SetKeyName(98, "P98.png");
            this.ilNumbers.Images.SetKeyName(99, "P99.png");
            this.ilNumbers.Images.SetKeyName(100, "PXX.png");
            // 
            // tmRandom
            // 
            this.tmRandom.Tick += new System.EventHandler(this.tmRandom_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(715, 308);
            this.Controls.Add(this.pbNumber);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.lsbDrawnNumbers);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tbMaxDrawn);
            this.Controls.Add(this.tbMaxValue);
            this.Controls.Add(this.lbMaxDrawn);
            this.Controls.Add(this.lbMaxValue);
            this.Controls.Add(this.lbSettings);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Teal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Lottery";
            ((System.ComponentModel.ISupportInitialize)(this.pbNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbSettings;
        private System.Windows.Forms.Label lbMaxValue;
        private System.Windows.Forms.Label lbMaxDrawn;
        private System.Windows.Forms.TextBox tbMaxValue;
        private System.Windows.Forms.TextBox tbMaxDrawn;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.ListBox lsbDrawnNumbers;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Timer tmDraw;
        private System.Windows.Forms.PictureBox pbNumber;
        private System.Windows.Forms.ImageList ilNumbers;
        private System.Windows.Forms.Timer tmRandom;
    }
}

