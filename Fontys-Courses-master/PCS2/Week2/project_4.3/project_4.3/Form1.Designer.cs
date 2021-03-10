namespace project_4._3
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
            this.gbxLotterySettings = new System.Windows.Forms.GroupBox();
            this.tbxNrWanted = new System.Windows.Forms.TextBox();
            this.tbxMaxValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.btnCreateLotteryObject = new System.Windows.Forms.Button();
            this.btnDrawNextNumber = new System.Windows.Forms.Button();
            this.btnDrawAllNumbers = new System.Windows.Forms.Button();
            this.lbxInfo = new System.Windows.Forms.ListBox();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.btnFlashyAnimation = new System.Windows.Forms.Button();
            this.timerFlashy = new System.Windows.Forms.Timer(this.components);
            this.pbxNumber = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gbxLotterySettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxLotterySettings
            // 
            this.gbxLotterySettings.Controls.Add(this.tbxNrWanted);
            this.gbxLotterySettings.Controls.Add(this.tbxMaxValue);
            this.gbxLotterySettings.Controls.Add(this.label2);
            this.gbxLotterySettings.Controls.Add(this.lblMaxValue);
            this.gbxLotterySettings.Location = new System.Drawing.Point(22, 16);
            this.gbxLotterySettings.Name = "gbxLotterySettings";
            this.gbxLotterySettings.Size = new System.Drawing.Size(238, 109);
            this.gbxLotterySettings.TabIndex = 0;
            this.gbxLotterySettings.TabStop = false;
            this.gbxLotterySettings.Text = "Lottery settings";
            // 
            // tbxNrWanted
            // 
            this.tbxNrWanted.Location = new System.Drawing.Point(123, 63);
            this.tbxNrWanted.Name = "tbxNrWanted";
            this.tbxNrWanted.Size = new System.Drawing.Size(77, 20);
            this.tbxNrWanted.TabIndex = 3;
            // 
            // tbxMaxValue
            // 
            this.tbxMaxValue.Location = new System.Drawing.Point(71, 23);
            this.tbxMaxValue.Name = "tbxMaxValue";
            this.tbxMaxValue.Size = new System.Drawing.Size(81, 20);
            this.tbxMaxValue.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nr of wanted numbers";
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.AutoSize = true;
            this.lblMaxValue.Location = new System.Drawing.Point(6, 26);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(59, 13);
            this.lblMaxValue.TabIndex = 0;
            this.lblMaxValue.Text = "Max value:";
            // 
            // btnCreateLotteryObject
            // 
            this.btnCreateLotteryObject.Location = new System.Drawing.Point(22, 131);
            this.btnCreateLotteryObject.Name = "btnCreateLotteryObject";
            this.btnCreateLotteryObject.Size = new System.Drawing.Size(238, 23);
            this.btnCreateLotteryObject.TabIndex = 1;
            this.btnCreateLotteryObject.Text = "Create lottery object";
            this.btnCreateLotteryObject.UseVisualStyleBackColor = true;
            this.btnCreateLotteryObject.Click += new System.EventHandler(this.btnCreateLotteryObject_Click);
            // 
            // btnDrawNextNumber
            // 
            this.btnDrawNextNumber.Enabled = false;
            this.btnDrawNextNumber.Location = new System.Drawing.Point(22, 168);
            this.btnDrawNextNumber.Name = "btnDrawNextNumber";
            this.btnDrawNextNumber.Size = new System.Drawing.Size(238, 23);
            this.btnDrawNextNumber.TabIndex = 2;
            this.btnDrawNextNumber.Text = "Draw next number";
            this.btnDrawNextNumber.UseVisualStyleBackColor = true;
            this.btnDrawNextNumber.Click += new System.EventHandler(this.btnDrawNextNumber_Click);
            // 
            // btnDrawAllNumbers
            // 
            this.btnDrawAllNumbers.Enabled = false;
            this.btnDrawAllNumbers.Location = new System.Drawing.Point(22, 205);
            this.btnDrawAllNumbers.Name = "btnDrawAllNumbers";
            this.btnDrawAllNumbers.Size = new System.Drawing.Size(238, 23);
            this.btnDrawAllNumbers.TabIndex = 3;
            this.btnDrawAllNumbers.Text = "Draw all numbers at once";
            this.btnDrawAllNumbers.UseVisualStyleBackColor = true;
            this.btnDrawAllNumbers.Click += new System.EventHandler(this.btnDrawAllNumbers_Click);
            // 
            // lbxInfo
            // 
            this.lbxInfo.FormattingEnabled = true;
            this.lbxInfo.Location = new System.Drawing.Point(294, 16);
            this.lbxInfo.Name = "lbxInfo";
            this.lbxInfo.Size = new System.Drawing.Size(163, 264);
            this.lbxInfo.TabIndex = 4;
            this.lbxInfo.Visible = false;
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(22, 245);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(238, 23);
            this.btnShowInfo.TabIndex = 5;
            this.btnShowInfo.Text = "Show info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Visible = false;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // btnFlashyAnimation
            // 
            this.btnFlashyAnimation.Location = new System.Drawing.Point(22, 274);
            this.btnFlashyAnimation.Name = "btnFlashyAnimation";
            this.btnFlashyAnimation.Size = new System.Drawing.Size(238, 23);
            this.btnFlashyAnimation.TabIndex = 6;
            this.btnFlashyAnimation.Text = "Perform a flashy animation";
            this.btnFlashyAnimation.UseVisualStyleBackColor = true;
            this.btnFlashyAnimation.Click += new System.EventHandler(this.btnFlashyAnimation_Click);
            // 
            // timerFlashy
            // 
            this.timerFlashy.Interval = 1000;
            this.timerFlashy.Tick += new System.EventHandler(this.timerFlashy_Tick);
            // 
            // pbxNumber
            // 
            this.pbxNumber.Location = new System.Drawing.Point(555, 16);
            this.pbxNumber.Name = "pbxNumber";
            this.pbxNumber.Size = new System.Drawing.Size(281, 281);
            this.pbxNumber.TabIndex = 7;
            this.pbxNumber.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "P00.png");
            this.imageList1.Images.SetKeyName(1, "P01.png");
            this.imageList1.Images.SetKeyName(2, "P02.png");
            this.imageList1.Images.SetKeyName(3, "P03.png");
            this.imageList1.Images.SetKeyName(4, "P04.png");
            this.imageList1.Images.SetKeyName(5, "P05.png");
            this.imageList1.Images.SetKeyName(6, "P06.png");
            this.imageList1.Images.SetKeyName(7, "P07.png");
            this.imageList1.Images.SetKeyName(8, "P08.png");
            this.imageList1.Images.SetKeyName(9, "P09.png");
            this.imageList1.Images.SetKeyName(10, "P10.png");
            this.imageList1.Images.SetKeyName(11, "P11.png");
            this.imageList1.Images.SetKeyName(12, "P12.png");
            this.imageList1.Images.SetKeyName(13, "P13.png");
            this.imageList1.Images.SetKeyName(14, "P14.png");
            this.imageList1.Images.SetKeyName(15, "P15.png");
            this.imageList1.Images.SetKeyName(16, "P16.png");
            this.imageList1.Images.SetKeyName(17, "P17.png");
            this.imageList1.Images.SetKeyName(18, "P18.png");
            this.imageList1.Images.SetKeyName(19, "P19.png");
            this.imageList1.Images.SetKeyName(20, "P20.png");
            this.imageList1.Images.SetKeyName(21, "P21.png");
            this.imageList1.Images.SetKeyName(22, "P22.png");
            this.imageList1.Images.SetKeyName(23, "P23.png");
            this.imageList1.Images.SetKeyName(24, "P24.png");
            this.imageList1.Images.SetKeyName(25, "P25.png");
            this.imageList1.Images.SetKeyName(26, "P26.png");
            this.imageList1.Images.SetKeyName(27, "P27.png");
            this.imageList1.Images.SetKeyName(28, "P28.png");
            this.imageList1.Images.SetKeyName(29, "P29.png");
            this.imageList1.Images.SetKeyName(30, "P30.png");
            this.imageList1.Images.SetKeyName(31, "P31.png");
            this.imageList1.Images.SetKeyName(32, "P32.png");
            this.imageList1.Images.SetKeyName(33, "P33.png");
            this.imageList1.Images.SetKeyName(34, "P34.png");
            this.imageList1.Images.SetKeyName(35, "P35.png");
            this.imageList1.Images.SetKeyName(36, "P36.png");
            this.imageList1.Images.SetKeyName(37, "P37.png");
            this.imageList1.Images.SetKeyName(38, "P38.png");
            this.imageList1.Images.SetKeyName(39, "P39.png");
            this.imageList1.Images.SetKeyName(40, "P40.png");
            this.imageList1.Images.SetKeyName(41, "P41.png");
            this.imageList1.Images.SetKeyName(42, "P42.png");
            this.imageList1.Images.SetKeyName(43, "P43.png");
            this.imageList1.Images.SetKeyName(44, "P44.png");
            this.imageList1.Images.SetKeyName(45, "P45.png");
            this.imageList1.Images.SetKeyName(46, "P46.png");
            this.imageList1.Images.SetKeyName(47, "P47.png");
            this.imageList1.Images.SetKeyName(48, "P48.png");
            this.imageList1.Images.SetKeyName(49, "P49.png");
            this.imageList1.Images.SetKeyName(50, "P50.png");
            this.imageList1.Images.SetKeyName(51, "P51.png");
            this.imageList1.Images.SetKeyName(52, "P52.png");
            this.imageList1.Images.SetKeyName(53, "P53.png");
            this.imageList1.Images.SetKeyName(54, "P54.png");
            this.imageList1.Images.SetKeyName(55, "P55.png");
            this.imageList1.Images.SetKeyName(56, "P56.png");
            this.imageList1.Images.SetKeyName(57, "P57.png");
            this.imageList1.Images.SetKeyName(58, "P58.png");
            this.imageList1.Images.SetKeyName(59, "P59.png");
            this.imageList1.Images.SetKeyName(60, "P60.png");
            this.imageList1.Images.SetKeyName(61, "P61.png");
            this.imageList1.Images.SetKeyName(62, "P62.png");
            this.imageList1.Images.SetKeyName(63, "P63.png");
            this.imageList1.Images.SetKeyName(64, "P64.png");
            this.imageList1.Images.SetKeyName(65, "P65.png");
            this.imageList1.Images.SetKeyName(66, "P66.png");
            this.imageList1.Images.SetKeyName(67, "P67.png");
            this.imageList1.Images.SetKeyName(68, "P68.png");
            this.imageList1.Images.SetKeyName(69, "P69.png");
            this.imageList1.Images.SetKeyName(70, "P70.png");
            this.imageList1.Images.SetKeyName(71, "P71.png");
            this.imageList1.Images.SetKeyName(72, "P72.png");
            this.imageList1.Images.SetKeyName(73, "P73.png");
            this.imageList1.Images.SetKeyName(74, "P74.png");
            this.imageList1.Images.SetKeyName(75, "P75.png");
            this.imageList1.Images.SetKeyName(76, "P76.png");
            this.imageList1.Images.SetKeyName(77, "P77.png");
            this.imageList1.Images.SetKeyName(78, "P78.png");
            this.imageList1.Images.SetKeyName(79, "P79.png");
            this.imageList1.Images.SetKeyName(80, "P80.png");
            this.imageList1.Images.SetKeyName(81, "P81.png");
            this.imageList1.Images.SetKeyName(82, "P82.png");
            this.imageList1.Images.SetKeyName(83, "P83.png");
            this.imageList1.Images.SetKeyName(84, "P84.png");
            this.imageList1.Images.SetKeyName(85, "P85.png");
            this.imageList1.Images.SetKeyName(86, "P86.png");
            this.imageList1.Images.SetKeyName(87, "P87.png");
            this.imageList1.Images.SetKeyName(88, "P88.png");
            this.imageList1.Images.SetKeyName(89, "P89.png");
            this.imageList1.Images.SetKeyName(90, "P90.png");
            this.imageList1.Images.SetKeyName(91, "P91.png");
            this.imageList1.Images.SetKeyName(92, "P92.png");
            this.imageList1.Images.SetKeyName(93, "P93.png");
            this.imageList1.Images.SetKeyName(94, "P94.png");
            this.imageList1.Images.SetKeyName(95, "P95.png");
            this.imageList1.Images.SetKeyName(96, "P96.png");
            this.imageList1.Images.SetKeyName(97, "P97.png");
            this.imageList1.Images.SetKeyName(98, "P98.png");
            this.imageList1.Images.SetKeyName(99, "P99.png");
            this.imageList1.Images.SetKeyName(100, "PXX.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 338);
            this.Controls.Add(this.pbxNumber);
            this.Controls.Add(this.btnFlashyAnimation);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.lbxInfo);
            this.Controls.Add(this.btnDrawAllNumbers);
            this.Controls.Add(this.btnDrawNextNumber);
            this.Controls.Add(this.btnCreateLotteryObject);
            this.Controls.Add(this.gbxLotterySettings);
            this.Name = "Form1";
            this.Text = "Lottery";
            this.gbxLotterySettings.ResumeLayout(false);
            this.gbxLotterySettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLotterySettings;
        private System.Windows.Forms.TextBox tbxNrWanted;
        private System.Windows.Forms.TextBox tbxMaxValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaxValue;
        private System.Windows.Forms.Button btnCreateLotteryObject;
        private System.Windows.Forms.Button btnDrawNextNumber;
        private System.Windows.Forms.Button btnDrawAllNumbers;
        private System.Windows.Forms.ListBox lbxInfo;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Button btnFlashyAnimation;
        private System.Windows.Forms.Timer timerFlashy;
        private System.Windows.Forms.PictureBox pbxNumber;
        private System.Windows.Forms.ImageList imageList1;
    }
}

