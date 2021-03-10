namespace StudyAdvisor
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxModules = new System.Windows.Forms.ListBox();
            this.buttonAdvice = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownMark = new System.Windows.Forms.NumericUpDown();
            this.textBoxEC = new System.Windows.Forms.TextBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.buttonAddModule = new System.Windows.Forms.Button();
            this.checkBoxPractical = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMark8 = new System.Windows.Forms.Label();
            this.labelMark7 = new System.Windows.Forms.Label();
            this.labelMark5 = new System.Windows.Forms.Label();
            this.labelMark4 = new System.Windows.Forms.Label();
            this.labelMark3 = new System.Windows.Forms.Label();
            this.labelMark2 = new System.Windows.Forms.Label();
            this.labelMark1 = new System.Windows.Forms.Label();
            this.labelMark6 = new System.Windows.Forms.Label();
            this.labelMark9 = new System.Windows.Forms.Label();
            this.labelMark10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.labelTotalGainedEC = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxMaxPossibeEC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelRecommendation = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonRecommendation = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMark)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "modules";
            // 
            // listBoxModules
            // 
            this.listBoxModules.FormattingEnabled = true;
            this.listBoxModules.Location = new System.Drawing.Point(12, 25);
            this.listBoxModules.Name = "listBoxModules";
            this.listBoxModules.Size = new System.Drawing.Size(426, 199);
            this.listBoxModules.TabIndex = 1;
            // 
            // buttonAdvice
            // 
            this.buttonAdvice.Location = new System.Drawing.Point(105, 404);
            this.buttonAdvice.Name = "buttonAdvice";
            this.buttonAdvice.Size = new System.Drawing.Size(155, 25);
            this.buttonAdvice.TabIndex = 41;
            this.buttonAdvice.TabStop = false;
            this.buttonAdvice.Text = "analyze my study results";
            this.buttonAdvice.UseVisualStyleBackColor = true;
            this.buttonAdvice.Click += new System.EventHandler(this.buttonAdvice_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(444, 197);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(169, 27);
            this.buttonRemove.TabIndex = 42;
            this.buttonRemove.Text = "remove selected module";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numericUpDownMark);
            this.panel1.Controls.Add(this.textBoxEC);
            this.panel1.Controls.Add(this.textBoxCode);
            this.panel1.Controls.Add(this.buttonAddModule);
            this.panel1.Controls.Add(this.checkBoxPractical);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Location = new System.Drawing.Point(444, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 157);
            this.panel1.TabIndex = 44;
            // 
            // numericUpDownMark
            // 
            this.numericUpDownMark.Location = new System.Drawing.Point(45, 77);
            this.numericUpDownMark.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMark.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMark.Name = "numericUpDownMark";
            this.numericUpDownMark.Size = new System.Drawing.Size(101, 20);
            this.numericUpDownMark.TabIndex = 36;
            this.numericUpDownMark.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // textBoxEC
            // 
            this.textBoxEC.Location = new System.Drawing.Point(46, 48);
            this.textBoxEC.Name = "textBoxEC";
            this.textBoxEC.Size = new System.Drawing.Size(100, 20);
            this.textBoxEC.TabIndex = 35;
            this.textBoxEC.Text = "3";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(45, 21);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxCode.TabIndex = 34;
            this.textBoxCode.Text = "EDB1";
            // 
            // buttonAddModule
            // 
            this.buttonAddModule.Location = new System.Drawing.Point(46, 126);
            this.buttonAddModule.Name = "buttonAddModule";
            this.buttonAddModule.Size = new System.Drawing.Size(75, 24);
            this.buttonAddModule.TabIndex = 33;
            this.buttonAddModule.Text = "add module";
            this.buttonAddModule.UseVisualStyleBackColor = true;
            this.buttonAddModule.Click += new System.EventHandler(this.buttonAddModule_Click);
            // 
            // checkBoxPractical
            // 
            this.checkBoxPractical.AutoSize = true;
            this.checkBoxPractical.Location = new System.Drawing.Point(42, 103);
            this.checkBoxPractical.Name = "checkBoxPractical";
            this.checkBoxPractical.Size = new System.Drawing.Size(103, 17);
            this.checkBoxPractical.TabIndex = 31;
            this.checkBoxPractical.Text = "passed practical";
            this.checkBoxPractical.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(11, 77);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 13);
            this.label20.TabIndex = 30;
            this.label20.Text = "mark";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 51);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "EC\'s";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "code";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(42, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "ADD MODULE";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelMark8);
            this.panel2.Controls.Add(this.labelMark7);
            this.panel2.Controls.Add(this.labelMark5);
            this.panel2.Controls.Add(this.labelMark4);
            this.panel2.Controls.Add(this.labelMark3);
            this.panel2.Controls.Add(this.labelMark2);
            this.panel2.Controls.Add(this.labelMark1);
            this.panel2.Controls.Add(this.labelMark6);
            this.panel2.Controls.Add(this.labelMark9);
            this.panel2.Controls.Add(this.labelMark10);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.labelTotalGainedEC);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(12, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 158);
            this.panel2.TabIndex = 46;
            // 
            // labelMark8
            // 
            this.labelMark8.AutoSize = true;
            this.labelMark8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMark8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelMark8.Location = new System.Drawing.Point(155, 101);
            this.labelMark8.Name = "labelMark8";
            this.labelMark8.Size = new System.Drawing.Size(69, 13);
            this.labelMark8.TabIndex = 100;
            this.labelMark8.Text = "labelMark8";
            // 
            // labelMark7
            // 
            this.labelMark7.AutoSize = true;
            this.labelMark7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMark7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelMark7.Location = new System.Drawing.Point(155, 119);
            this.labelMark7.Name = "labelMark7";
            this.labelMark7.Size = new System.Drawing.Size(69, 13);
            this.labelMark7.TabIndex = 99;
            this.labelMark7.Text = "labelMark7";
            // 
            // labelMark5
            // 
            this.labelMark5.AutoSize = true;
            this.labelMark5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMark5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelMark5.Location = new System.Drawing.Point(264, 65);
            this.labelMark5.Name = "labelMark5";
            this.labelMark5.Size = new System.Drawing.Size(69, 13);
            this.labelMark5.TabIndex = 98;
            this.labelMark5.Text = "labelMark5";
            // 
            // labelMark4
            // 
            this.labelMark4.AutoSize = true;
            this.labelMark4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMark4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelMark4.Location = new System.Drawing.Point(264, 83);
            this.labelMark4.Name = "labelMark4";
            this.labelMark4.Size = new System.Drawing.Size(69, 13);
            this.labelMark4.TabIndex = 97;
            this.labelMark4.Text = "labelMark4";
            // 
            // labelMark3
            // 
            this.labelMark3.AutoSize = true;
            this.labelMark3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMark3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelMark3.Location = new System.Drawing.Point(264, 101);
            this.labelMark3.Name = "labelMark3";
            this.labelMark3.Size = new System.Drawing.Size(69, 13);
            this.labelMark3.TabIndex = 96;
            this.labelMark3.Text = "labelMark3";
            // 
            // labelMark2
            // 
            this.labelMark2.AutoSize = true;
            this.labelMark2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMark2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelMark2.Location = new System.Drawing.Point(264, 119);
            this.labelMark2.Name = "labelMark2";
            this.labelMark2.Size = new System.Drawing.Size(69, 13);
            this.labelMark2.TabIndex = 95;
            this.labelMark2.Text = "labelMark2";
            // 
            // labelMark1
            // 
            this.labelMark1.AutoSize = true;
            this.labelMark1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMark1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelMark1.Location = new System.Drawing.Point(264, 137);
            this.labelMark1.Name = "labelMark1";
            this.labelMark1.Size = new System.Drawing.Size(69, 13);
            this.labelMark1.TabIndex = 94;
            this.labelMark1.Text = "labelMark1";
            // 
            // labelMark6
            // 
            this.labelMark6.AutoSize = true;
            this.labelMark6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMark6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelMark6.Location = new System.Drawing.Point(155, 137);
            this.labelMark6.Name = "labelMark6";
            this.labelMark6.Size = new System.Drawing.Size(69, 13);
            this.labelMark6.TabIndex = 93;
            this.labelMark6.Text = "labelMark6";
            // 
            // labelMark9
            // 
            this.labelMark9.AutoSize = true;
            this.labelMark9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMark9.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelMark9.Location = new System.Drawing.Point(155, 83);
            this.labelMark9.Name = "labelMark9";
            this.labelMark9.Size = new System.Drawing.Size(69, 13);
            this.labelMark9.TabIndex = 92;
            this.labelMark9.Text = "labelMark9";
            // 
            // labelMark10
            // 
            this.labelMark10.AutoSize = true;
            this.labelMark10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMark10.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelMark10.Location = new System.Drawing.Point(155, 65);
            this.labelMark10.Name = "labelMark10";
            this.labelMark10.Size = new System.Drawing.Size(76, 13);
            this.labelMark10.TabIndex = 91;
            this.labelMark10.Text = "labelMark10";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(236, 137);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 13);
            this.label15.TabIndex = 90;
            this.label15.Text = "1 -";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(236, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 89;
            this.label14.Text = "2 -";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(236, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 88;
            this.label13.Text = "3 -";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(236, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 87;
            this.label12.Text = "4 - ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 86;
            this.label9.Text = "5 - ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(130, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 85;
            this.label10.Text = "6 - ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(130, 119);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(22, 13);
            this.label21.TabIndex = 84;
            this.label21.Text = "7 - ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(130, 101);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 13);
            this.label22.TabIndex = 83;
            this.label22.Text = "8 - ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(130, 83);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(22, 13);
            this.label23.TabIndex = 82;
            this.label23.Text = "9 - ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(124, 65);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(25, 13);
            this.label24.TabIndex = 81;
            this.label24.Text = "10 -";
            // 
            // labelTotalGainedEC
            // 
            this.labelTotalGainedEC.AutoSize = true;
            this.labelTotalGainedEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalGainedEC.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelTotalGainedEC.Location = new System.Drawing.Point(132, 38);
            this.labelTotalGainedEC.Name = "labelTotalGainedEC";
            this.labelTotalGainedEC.Size = new System.Drawing.Size(119, 13);
            this.labelTotalGainedEC.TabIndex = 79;
            this.labelTotalGainedEC.Text = "labelTotalGainedEC";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(5, 65);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(116, 13);
            this.label26.TabIndex = 78;
            this.label26.Text = "nr of courses with mark";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.SystemColors.Control;
            this.label27.Location = new System.Drawing.Point(30, 38);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(104, 13);
            this.label27.TabIndex = 77;
            this.label27.Text = "total achieved EC\'s -";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(87, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "BASIC ANALYSIS";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBoxMaxPossibeEC);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.labelRecommendation);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Location = new System.Drawing.Point(359, 241);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 157);
            this.panel3.TabIndex = 47;
            // 
            // textBoxMaxPossibeEC
            // 
            this.textBoxMaxPossibeEC.Location = new System.Drawing.Point(137, 33);
            this.textBoxMaxPossibeEC.Name = "textBoxMaxPossibeEC";
            this.textBoxMaxPossibeEC.Size = new System.Drawing.Size(112, 20);
            this.textBoxMaxPossibeEC.TabIndex = 57;
            this.textBoxMaxPossibeEC.Text = "textBoxMaxPossibeEC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "maximum possible EC\'s -";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "STUDY RECOMMENDATION";
            // 
            // labelRecommendation
            // 
            this.labelRecommendation.AutoSize = true;
            this.labelRecommendation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecommendation.ForeColor = System.Drawing.Color.Orange;
            this.labelRecommendation.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelRecommendation.Location = new System.Drawing.Point(30, 81);
            this.labelRecommendation.Name = "labelRecommendation";
            this.labelRecommendation.Size = new System.Drawing.Size(219, 24);
            this.labelRecommendation.TabIndex = 34;
            this.labelRecommendation.Text = "labelRecommendation";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "study recommendation is -";
            // 
            // buttonRecommendation
            // 
            this.buttonRecommendation.Location = new System.Drawing.Point(418, 404);
            this.buttonRecommendation.Name = "buttonRecommendation";
            this.buttonRecommendation.Size = new System.Drawing.Size(164, 23);
            this.buttonRecommendation.TabIndex = 48;
            this.buttonRecommendation.Text = "calculate my recommedation";
            this.buttonRecommendation.UseVisualStyleBackColor = true;
            this.buttonRecommendation.Click += new System.EventHandler(this.buttonRecommendation_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 435);
            this.Controls.Add(this.buttonRecommendation);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdvice);
            this.Controls.Add(this.listBoxModules);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMark)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxModules;
        private System.Windows.Forms.Button buttonAdvice;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDownMark;
        private System.Windows.Forms.TextBox textBoxEC;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button buttonAddModule;
        private System.Windows.Forms.CheckBox checkBoxPractical;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelRecommendation;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelMark8;
        private System.Windows.Forms.Label labelMark7;
        private System.Windows.Forms.Label labelMark5;
        private System.Windows.Forms.Label labelMark4;
        private System.Windows.Forms.Label labelMark3;
        private System.Windows.Forms.Label labelMark2;
        private System.Windows.Forms.Label labelMark1;
        private System.Windows.Forms.Label labelMark6;
        private System.Windows.Forms.Label labelMark9;
        private System.Windows.Forms.Label labelMark10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label labelTotalGainedEC;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBoxMaxPossibeEC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRecommendation;
    }
}

