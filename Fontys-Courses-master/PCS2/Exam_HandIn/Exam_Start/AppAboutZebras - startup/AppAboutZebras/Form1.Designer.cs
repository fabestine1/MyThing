namespace AppAboutZebras
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
            this.btnShowAllZebras = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.btnShowZebrasWithFather = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDz = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbUnknownGender = new System.Windows.Forms.RadioButton();
            this.rbMare = new System.Windows.Forms.RadioButton();
            this.rbStallion = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFatherId = new System.Windows.Forms.TextBox();
            this.tbMotherId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddZebra = new System.Windows.Forms.Button();
            this.btnShowZebrasInMotherline = new System.Windows.Forms.Button();
            this.btnShowInfoOf1Zebra = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOthers = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowAllZebras
            // 
            this.btnShowAllZebras.Location = new System.Drawing.Point(18, 370);
            this.btnShowAllZebras.Name = "btnShowAllZebras";
            this.btnShowAllZebras.Size = new System.Drawing.Size(108, 206);
            this.btnShowAllZebras.TabIndex = 0;
            this.btnShowAllZebras.Text = "show all zebras";
            this.btnShowAllZebras.UseVisualStyleBackColor = true;
            this.btnShowAllZebras.Click += new System.EventHandler(this.btnShowAllZebras_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.ItemHeight = 18;
            this.lbInfo.Location = new System.Drawing.Point(18, 10);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(916, 346);
            this.lbInfo.TabIndex = 1;
            // 
            // btnShowZebrasWithFather
            // 
            this.btnShowZebrasWithFather.Location = new System.Drawing.Point(14, 104);
            this.btnShowZebrasWithFather.Name = "btnShowZebrasWithFather";
            this.btnShowZebrasWithFather.Size = new System.Drawing.Size(300, 40);
            this.btnShowZebrasWithFather.TabIndex = 2;
            this.btnShowZebrasWithFather.Text = "show all zebras with father";
            this.btnShowZebrasWithFather.UseVisualStyleBackColor = true;
            this.btnShowZebrasWithFather.Click += new System.EventHandler(this.btnShowZebrasWithFather_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox1.Controls.Add(this.tbDz);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rbUnknownGender);
            this.groupBox1.Controls.Add(this.rbMare);
            this.groupBox1.Controls.Add(this.rbStallion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbFatherId);
            this.groupBox1.Controls.Add(this.tbMotherId);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddZebra);
            this.groupBox1.Location = new System.Drawing.Point(132, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 211);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "add a zebra";
            // 
            // tbDz
            // 
            this.tbDz.BackColor = System.Drawing.Color.Yellow;
            this.tbDz.Location = new System.Drawing.Point(118, 98);
            this.tbDz.Name = "tbDz";
            this.tbDz.Size = new System.Drawing.Size(99, 24);
            this.tbDz.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "dz-value";
            // 
            // rbUnknownGender
            // 
            this.rbUnknownGender.AutoSize = true;
            this.rbUnknownGender.Checked = true;
            this.rbUnknownGender.Location = new System.Drawing.Point(249, 112);
            this.rbUnknownGender.Name = "rbUnknownGender";
            this.rbUnknownGender.Size = new System.Drawing.Size(174, 22);
            this.rbUnknownGender.TabIndex = 14;
            this.rbUnknownGender.TabStop = true;
            this.rbUnknownGender.Text = "gender not known yet !";
            this.rbUnknownGender.UseVisualStyleBackColor = true;
            // 
            // rbMare
            // 
            this.rbMare.AutoSize = true;
            this.rbMare.Location = new System.Drawing.Point(249, 80);
            this.rbMare.Name = "rbMare";
            this.rbMare.Size = new System.Drawing.Size(86, 22);
            this.rbMare.TabIndex = 13;
            this.rbMare.Text = "it\'s a girl !";
            this.rbMare.UseVisualStyleBackColor = true;
            this.rbMare.CheckedChanged += new System.EventHandler(this.rbMare_CheckedChanged);
            // 
            // rbStallion
            // 
            this.rbStallion.AutoSize = true;
            this.rbStallion.Location = new System.Drawing.Point(249, 48);
            this.rbStallion.Name = "rbStallion";
            this.rbStallion.Size = new System.Drawing.Size(91, 22);
            this.rbStallion.TabIndex = 12;
            this.rbStallion.Text = "it\'s a boy !";
            this.rbStallion.UseVisualStyleBackColor = true;
            this.rbStallion.CheckedChanged += new System.EventHandler(this.rbStallion_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "gender";
            // 
            // tbFatherId
            // 
            this.tbFatherId.BackColor = System.Drawing.Color.Yellow;
            this.tbFatherId.Location = new System.Drawing.Point(118, 165);
            this.tbFatherId.Name = "tbFatherId";
            this.tbFatherId.Size = new System.Drawing.Size(100, 24);
            this.tbFatherId.TabIndex = 9;
            // 
            // tbMotherId
            // 
            this.tbMotherId.BackColor = System.Drawing.Color.Yellow;
            this.tbMotherId.Location = new System.Drawing.Point(118, 131);
            this.tbMotherId.Name = "tbMotherId";
            this.tbMotherId.Size = new System.Drawing.Size(100, 24);
            this.tbMotherId.TabIndex = 8;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(118, 62);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 24);
            this.tbName.TabIndex = 7;
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.Yellow;
            this.tbId.Location = new System.Drawing.Point(118, 29);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 24);
            this.tbId.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "id of father";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "id of mother";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "id";
            // 
            // btnAddZebra
            // 
            this.btnAddZebra.Location = new System.Drawing.Point(251, 143);
            this.btnAddZebra.Name = "btnAddZebra";
            this.btnAddZebra.Size = new System.Drawing.Size(153, 54);
            this.btnAddZebra.TabIndex = 0;
            this.btnAddZebra.Text = "add zebra";
            this.btnAddZebra.UseVisualStyleBackColor = true;
            this.btnAddZebra.Click += new System.EventHandler(this.btnAddZebra_Click);
            // 
            // btnShowZebrasInMotherline
            // 
            this.btnShowZebrasInMotherline.Location = new System.Drawing.Point(14, 154);
            this.btnShowZebrasInMotherline.Name = "btnShowZebrasInMotherline";
            this.btnShowZebrasInMotherline.Size = new System.Drawing.Size(300, 40);
            this.btnShowZebrasInMotherline.TabIndex = 4;
            this.btnShowZebrasInMotherline.Text = "show zebras in motherline";
            this.btnShowZebrasInMotherline.UseVisualStyleBackColor = true;
            this.btnShowZebrasInMotherline.Click += new System.EventHandler(this.btnShowZebrasInMotherline_Click);
            // 
            // btnShowInfoOf1Zebra
            // 
            this.btnShowInfoOf1Zebra.Location = new System.Drawing.Point(14, 59);
            this.btnShowInfoOf1Zebra.Name = "btnShowInfoOf1Zebra";
            this.btnShowInfoOf1Zebra.Size = new System.Drawing.Size(300, 40);
            this.btnShowInfoOf1Zebra.TabIndex = 5;
            this.btnShowInfoOf1Zebra.Text = "show info of a particular zebra";
            this.btnShowInfoOf1Zebra.UseVisualStyleBackColor = true;
            this.btnShowInfoOf1Zebra.Click += new System.EventHandler(this.btnShowInfoOf1Zebra_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbOthers);
            this.groupBox2.Controls.Add(this.btnShowInfoOf1Zebra);
            this.groupBox2.Controls.Add(this.btnShowZebrasInMotherline);
            this.groupBox2.Controls.Add(this.btnShowZebrasWithFather);
            this.groupBox2.Location = new System.Drawing.Point(590, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 211);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "other functionality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "id of particular zebra";
            // 
            // tbOthers
            // 
            this.tbOthers.Location = new System.Drawing.Point(215, 29);
            this.tbOthers.Name = "tbOthers";
            this.tbOthers.Size = new System.Drawing.Size(99, 24);
            this.tbOthers.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(943, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnShowAllZebras);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowAllZebras;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.Button btnShowZebrasWithFather;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFatherId;
        private System.Windows.Forms.TextBox tbMotherId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddZebra;
        private System.Windows.Forms.RadioButton rbUnknownGender;
        private System.Windows.Forms.RadioButton rbMare;
        private System.Windows.Forms.RadioButton rbStallion;
        private System.Windows.Forms.Button btnShowZebrasInMotherline;
        private System.Windows.Forms.Button btnShowInfoOf1Zebra;
        private System.Windows.Forms.TextBox tbDz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbOthers;
        private System.Windows.Forms.Label label5;
    }
}

