namespace AppForAShop
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbWCArticle = new System.Windows.Forms.RadioButton();
            this.rbDepositArticle = new System.Windows.Forms.RadioButton();
            this.rbWine = new System.Windows.Forms.RadioButton();
            this.btnAddArticle = new System.Windows.Forms.Button();
            this.cbDiscount = new System.Windows.Forms.CheckBox();
            this.tbDeposit = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbInStock = new System.Windows.Forms.TextBox();
            this.tbBasicPrice = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowAllArticles = new System.Windows.Forms.Button();
            this.btnShowOldWine = new System.Windows.Forms.Button();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.btnSellSome = new System.Windows.Forms.Button();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(12, 15);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(827, 220);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.rbWCArticle);
            this.groupBox1.Controls.Add(this.rbDepositArticle);
            this.groupBox1.Controls.Add(this.rbWine);
            this.groupBox1.Controls.Add(this.btnAddArticle);
            this.groupBox1.Controls.Add(this.cbDiscount);
            this.groupBox1.Controls.Add(this.tbDeposit);
            this.groupBox1.Controls.Add(this.tbYear);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbInStock);
            this.groupBox1.Controls.Add(this.tbBasicPrice);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 236);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "about  article";
            // 
            // rbWCArticle
            // 
            this.rbWCArticle.AutoSize = true;
            this.rbWCArticle.Location = new System.Drawing.Point(17, 195);
            this.rbWCArticle.Name = "rbWCArticle";
            this.rbWCArticle.Size = new System.Drawing.Size(88, 22);
            this.rbWCArticle.TabIndex = 16;
            this.rbWCArticle.TabStop = true;
            this.rbWCArticle.Text = "wc article";
            this.rbWCArticle.UseVisualStyleBackColor = true;
            // 
            // rbDepositArticle
            // 
            this.rbDepositArticle.AutoSize = true;
            this.rbDepositArticle.Location = new System.Drawing.Point(16, 167);
            this.rbDepositArticle.Name = "rbDepositArticle";
            this.rbDepositArticle.Size = new System.Drawing.Size(117, 22);
            this.rbDepositArticle.TabIndex = 15;
            this.rbDepositArticle.TabStop = true;
            this.rbDepositArticle.Text = "deposit article";
            this.rbDepositArticle.UseVisualStyleBackColor = true;
            // 
            // rbWine
            // 
            this.rbWine.AutoSize = true;
            this.rbWine.Location = new System.Drawing.Point(17, 136);
            this.rbWine.Name = "rbWine";
            this.rbWine.Size = new System.Drawing.Size(56, 22);
            this.rbWine.TabIndex = 14;
            this.rbWine.TabStop = true;
            this.rbWine.Text = "wine";
            this.rbWine.UseVisualStyleBackColor = true;
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAddArticle.Location = new System.Drawing.Point(332, 135);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(109, 82);
            this.btnAddArticle.TabIndex = 13;
            this.btnAddArticle.Text = "add article";
            this.btnAddArticle.UseVisualStyleBackColor = false;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // cbDiscount
            // 
            this.cbDiscount.AutoSize = true;
            this.cbDiscount.Location = new System.Drawing.Point(206, 203);
            this.cbDiscount.Name = "cbDiscount";
            this.cbDiscount.Size = new System.Drawing.Size(104, 22);
            this.cbDiscount.TabIndex = 12;
            this.cbDiscount.Text = "on discount";
            this.cbDiscount.UseVisualStyleBackColor = true;
            // 
            // tbDeposit
            // 
            this.tbDeposit.Location = new System.Drawing.Point(206, 167);
            this.tbDeposit.Name = "tbDeposit";
            this.tbDeposit.Size = new System.Drawing.Size(85, 24);
            this.tbDeposit.TabIndex = 11;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(207, 135);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(84, 24);
            this.tbYear.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "deposit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "year";
            // 
            // tbInStock
            // 
            this.tbInStock.Location = new System.Drawing.Point(380, 63);
            this.tbInStock.Name = "tbInStock";
            this.tbInStock.Size = new System.Drawing.Size(60, 24);
            this.tbInStock.TabIndex = 7;
            // 
            // tbBasicPrice
            // 
            this.tbBasicPrice.Location = new System.Drawing.Point(380, 33);
            this.tbBasicPrice.Name = "tbBasicPrice";
            this.tbBasicPrice.Size = new System.Drawing.Size(60, 24);
            this.tbBasicPrice.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(93, 64);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(115, 24);
            this.tbName.TabIndex = 5;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(93, 30);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(115, 24);
            this.tbID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "in stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "basic price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // btnShowAllArticles
            // 
            this.btnShowAllArticles.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnShowAllArticles.Location = new System.Drawing.Point(571, 256);
            this.btnShowAllArticles.Name = "btnShowAllArticles";
            this.btnShowAllArticles.Size = new System.Drawing.Size(170, 35);
            this.btnShowAllArticles.TabIndex = 2;
            this.btnShowAllArticles.Text = "show all articles";
            this.btnShowAllArticles.UseVisualStyleBackColor = false;
            this.btnShowAllArticles.Click += new System.EventHandler(this.btnShowAllArticles_Click);
            // 
            // btnShowOldWine
            // 
            this.btnShowOldWine.BackColor = System.Drawing.Color.SpringGreen;
            this.btnShowOldWine.Location = new System.Drawing.Point(575, 380);
            this.btnShowOldWine.Name = "btnShowOldWine";
            this.btnShowOldWine.Size = new System.Drawing.Size(167, 36);
            this.btnShowOldWine.TabIndex = 3;
            this.btnShowOldWine.Text = "show old wine";
            this.btnShowOldWine.UseVisualStyleBackColor = false;
            this.btnShowOldWine.Click += new System.EventHandler(this.btnShowOldWine_Click);
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.BackColor = System.Drawing.Color.SpringGreen;
            this.btnLoadFromFile.Location = new System.Drawing.Point(575, 437);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(166, 43);
            this.btnLoadFromFile.TabIndex = 4;
            this.btnLoadFromFile.Text = "load from file";
            this.btnLoadFromFile.UseVisualStyleBackColor = false;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // btnSellSome
            // 
            this.btnSellSome.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSellSome.Location = new System.Drawing.Point(571, 330);
            this.btnSellSome.Name = "btnSellSome";
            this.btnSellSome.Size = new System.Drawing.Size(163, 37);
            this.btnSellSome.TabIndex = 5;
            this.btnSellSome.Text = "sell some";
            this.btnSellSome.UseVisualStyleBackColor = false;
            this.btnSellSome.Click += new System.EventHandler(this.btnSellSome_Click);
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(740, 336);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(76, 24);
            this.tbAmount.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 492);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.btnSellSome);
            this.Controls.Add(this.btnLoadFromFile);
            this.Controls.Add(this.btnShowOldWine);
            this.Controls.Add(this.btnShowAllArticles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbWCArticle;
        private System.Windows.Forms.RadioButton rbDepositArticle;
        private System.Windows.Forms.RadioButton rbWine;
        private System.Windows.Forms.Button btnAddArticle;
        private System.Windows.Forms.CheckBox cbDiscount;
        private System.Windows.Forms.TextBox tbDeposit;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbInStock;
        private System.Windows.Forms.TextBox tbBasicPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowAllArticles;
        private System.Windows.Forms.Button btnShowOldWine;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.Button btnSellSome;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

