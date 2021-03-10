namespace AppForCandyStore
{
    partial class FormForCandyStore
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
            this.gbPackedCandy = new System.Windows.Forms.GroupBox();
            this.lbPackedCandy = new System.Windows.Forms.ListBox();
            this.tbNumberOfBags = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.btnChangePrice = new System.Windows.Forms.Button();
            this.gbMixedCandy = new System.Windows.Forms.GroupBox();
            this.tbWeightOfGummyDrops = new System.Windows.Forms.TextBox();
            this.tbWeightOfChewingGums = new System.Windows.Forms.TextBox();
            this.tbWeightOfLollipops = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbPackedCandy = new System.Windows.Forms.RadioButton();
            this.rbMixedCandy = new System.Windows.Forms.RadioButton();
            this.btnSell = new System.Windows.Forms.Button();
            this.lbOverview = new System.Windows.Forms.ListBox();
            this.btnShowAllSoldCandy = new System.Windows.Forms.Button();
            this.btnShowSoldMixedCandy = new System.Windows.Forms.Button();
            this.btnShowWeightsMixedCandy = new System.Windows.Forms.Button();
            this.btnSaveInformationToFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNameSalesperson = new System.Windows.Forms.TextBox();
            this.gbPackedCandy.SuspendLayout();
            this.gbMixedCandy.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPackedCandy
            // 
            this.gbPackedCandy.BackColor = System.Drawing.Color.Bisque;
            this.gbPackedCandy.Controls.Add(this.lbPackedCandy);
            this.gbPackedCandy.Controls.Add(this.tbNumberOfBags);
            this.gbPackedCandy.Controls.Add(this.label1);
            this.gbPackedCandy.Location = new System.Drawing.Point(16, 46);
            this.gbPackedCandy.Margin = new System.Windows.Forms.Padding(4);
            this.gbPackedCandy.Name = "gbPackedCandy";
            this.gbPackedCandy.Padding = new System.Windows.Forms.Padding(4);
            this.gbPackedCandy.Size = new System.Drawing.Size(339, 160);
            this.gbPackedCandy.TabIndex = 0;
            this.gbPackedCandy.TabStop = false;
            this.gbPackedCandy.Text = "packed candy";
            // 
            // lbPackedCandy
            // 
            this.lbPackedCandy.FormattingEnabled = true;
            this.lbPackedCandy.ItemHeight = 16;
            this.lbPackedCandy.Location = new System.Drawing.Point(20, 27);
            this.lbPackedCandy.Name = "lbPackedCandy";
            this.lbPackedCandy.Size = new System.Drawing.Size(154, 116);
            this.lbPackedCandy.TabIndex = 3;
            // 
            // tbNumberOfBags
            // 
            this.tbNumberOfBags.Location = new System.Drawing.Point(214, 51);
            this.tbNumberOfBags.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumberOfBags.Name = "tbNumberOfBags";
            this.tbNumberOfBags.Size = new System.Drawing.Size(68, 22);
            this.tbNumberOfBags.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "number of bags";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(618, 15);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(71, 22);
            this.tbPrice.TabIndex = 5;
            // 
            // btnChangePrice
            // 
            this.btnChangePrice.BackColor = System.Drawing.Color.PaleGreen;
            this.btnChangePrice.Location = new System.Drawing.Point(504, 10);
            this.btnChangePrice.Name = "btnChangePrice";
            this.btnChangePrice.Size = new System.Drawing.Size(108, 26);
            this.btnChangePrice.TabIndex = 4;
            this.btnChangePrice.Text = "change price";
            this.btnChangePrice.UseVisualStyleBackColor = false;
            this.btnChangePrice.Click += new System.EventHandler(this.btnChangePrice_Click);
            // 
            // gbMixedCandy
            // 
            this.gbMixedCandy.BackColor = System.Drawing.Color.Bisque;
            this.gbMixedCandy.Controls.Add(this.tbWeightOfGummyDrops);
            this.gbMixedCandy.Controls.Add(this.tbWeightOfChewingGums);
            this.gbMixedCandy.Controls.Add(this.tbWeightOfLollipops);
            this.gbMixedCandy.Controls.Add(this.label4);
            this.gbMixedCandy.Controls.Add(this.label3);
            this.gbMixedCandy.Controls.Add(this.label2);
            this.gbMixedCandy.Location = new System.Drawing.Point(363, 48);
            this.gbMixedCandy.Margin = new System.Windows.Forms.Padding(4);
            this.gbMixedCandy.Name = "gbMixedCandy";
            this.gbMixedCandy.Padding = new System.Windows.Forms.Padding(4);
            this.gbMixedCandy.Size = new System.Drawing.Size(332, 158);
            this.gbMixedCandy.TabIndex = 1;
            this.gbMixedCandy.TabStop = false;
            this.gbMixedCandy.Text = "mixed candy";
            // 
            // tbWeightOfGummyDrops
            // 
            this.tbWeightOfGummyDrops.Location = new System.Drawing.Point(183, 118);
            this.tbWeightOfGummyDrops.Margin = new System.Windows.Forms.Padding(4);
            this.tbWeightOfGummyDrops.Name = "tbWeightOfGummyDrops";
            this.tbWeightOfGummyDrops.Size = new System.Drawing.Size(66, 22);
            this.tbWeightOfGummyDrops.TabIndex = 5;
            // 
            // tbWeightOfChewingGums
            // 
            this.tbWeightOfChewingGums.Location = new System.Drawing.Point(183, 76);
            this.tbWeightOfChewingGums.Margin = new System.Windows.Forms.Padding(4);
            this.tbWeightOfChewingGums.Name = "tbWeightOfChewingGums";
            this.tbWeightOfChewingGums.Size = new System.Drawing.Size(66, 22);
            this.tbWeightOfChewingGums.TabIndex = 4;
            // 
            // tbWeightOfLollipops
            // 
            this.tbWeightOfLollipops.Location = new System.Drawing.Point(180, 34);
            this.tbWeightOfLollipops.Margin = new System.Windows.Forms.Padding(4);
            this.tbWeightOfLollipops.Name = "tbWeightOfLollipops";
            this.tbWeightOfLollipops.Size = new System.Drawing.Size(66, 22);
            this.tbWeightOfLollipops.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "weight of gummy drops";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "weight of chewing gums";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "weight of lollipops";
            // 
            // rbPackedCandy
            // 
            this.rbPackedCandy.AutoSize = true;
            this.rbPackedCandy.Checked = true;
            this.rbPackedCandy.Location = new System.Drawing.Point(24, 13);
            this.rbPackedCandy.Margin = new System.Windows.Forms.Padding(4);
            this.rbPackedCandy.Name = "rbPackedCandy";
            this.rbPackedCandy.Size = new System.Drawing.Size(112, 20);
            this.rbPackedCandy.TabIndex = 2;
            this.rbPackedCandy.TabStop = true;
            this.rbPackedCandy.Text = "packed candy";
            this.rbPackedCandy.UseVisualStyleBackColor = true;
            // 
            // rbMixedCandy
            // 
            this.rbMixedCandy.AutoSize = true;
            this.rbMixedCandy.Location = new System.Drawing.Point(372, 15);
            this.rbMixedCandy.Margin = new System.Windows.Forms.Padding(4);
            this.rbMixedCandy.Name = "rbMixedCandy";
            this.rbMixedCandy.Size = new System.Drawing.Size(102, 20);
            this.rbMixedCandy.TabIndex = 3;
            this.rbMixedCandy.Text = "mixed candy";
            this.rbMixedCandy.UseVisualStyleBackColor = true;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.Orange;
            this.btnSell.Location = new System.Drawing.Point(725, 73);
            this.btnSell.Margin = new System.Windows.Forms.Padding(4);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(128, 57);
            this.btnSell.TabIndex = 4;
            this.btnSell.Text = "sell candy";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // lbOverview
            // 
            this.lbOverview.FormattingEnabled = true;
            this.lbOverview.ItemHeight = 16;
            this.lbOverview.Location = new System.Drawing.Point(16, 214);
            this.lbOverview.Name = "lbOverview";
            this.lbOverview.Size = new System.Drawing.Size(679, 164);
            this.lbOverview.TabIndex = 5;
            // 
            // btnShowAllSoldCandy
            // 
            this.btnShowAllSoldCandy.BackColor = System.Drawing.Color.Orange;
            this.btnShowAllSoldCandy.Location = new System.Drawing.Point(725, 138);
            this.btnShowAllSoldCandy.Name = "btnShowAllSoldCandy";
            this.btnShowAllSoldCandy.Size = new System.Drawing.Size(128, 57);
            this.btnShowAllSoldCandy.TabIndex = 6;
            this.btnShowAllSoldCandy.Text = "show all sold candy";
            this.btnShowAllSoldCandy.UseVisualStyleBackColor = false;
            this.btnShowAllSoldCandy.Click += new System.EventHandler(this.btnShowAllSoldCandy_Click);
            // 
            // btnShowSoldMixedCandy
            // 
            this.btnShowSoldMixedCandy.BackColor = System.Drawing.Color.Orange;
            this.btnShowSoldMixedCandy.Location = new System.Drawing.Point(725, 201);
            this.btnShowSoldMixedCandy.Name = "btnShowSoldMixedCandy";
            this.btnShowSoldMixedCandy.Size = new System.Drawing.Size(128, 57);
            this.btnShowSoldMixedCandy.TabIndex = 7;
            this.btnShowSoldMixedCandy.Text = "show sold mixed candy";
            this.btnShowSoldMixedCandy.UseVisualStyleBackColor = false;
            this.btnShowSoldMixedCandy.Click += new System.EventHandler(this.btnShowSoldMixedCandy_Click);
            // 
            // btnShowWeightsMixedCandy
            // 
            this.btnShowWeightsMixedCandy.BackColor = System.Drawing.Color.Orange;
            this.btnShowWeightsMixedCandy.Location = new System.Drawing.Point(725, 264);
            this.btnShowWeightsMixedCandy.Name = "btnShowWeightsMixedCandy";
            this.btnShowWeightsMixedCandy.Size = new System.Drawing.Size(128, 57);
            this.btnShowWeightsMixedCandy.TabIndex = 8;
            this.btnShowWeightsMixedCandy.Text = "show weights of mixed candy";
            this.btnShowWeightsMixedCandy.UseVisualStyleBackColor = false;
            this.btnShowWeightsMixedCandy.Click += new System.EventHandler(this.btnShowWeightsMixedCandy_Click);
            // 
            // btnSaveInformationToFile
            // 
            this.btnSaveInformationToFile.BackColor = System.Drawing.Color.Orange;
            this.btnSaveInformationToFile.Location = new System.Drawing.Point(725, 327);
            this.btnSaveInformationToFile.Name = "btnSaveInformationToFile";
            this.btnSaveInformationToFile.Size = new System.Drawing.Size(128, 57);
            this.btnSaveInformationToFile.TabIndex = 9;
            this.btnSaveInformationToFile.Text = "save information to file";
            this.btnSaveInformationToFile.UseVisualStyleBackColor = false;
            this.btnSaveInformationToFile.Click += new System.EventHandler(this.btnSaveInformationToFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(731, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "name salesperson";
            // 
            // tbNameSalesperson
            // 
            this.tbNameSalesperson.Location = new System.Drawing.Point(734, 32);
            this.tbNameSalesperson.Name = "tbNameSalesperson";
            this.tbNameSalesperson.Size = new System.Drawing.Size(116, 22);
            this.tbNameSalesperson.TabIndex = 11;
            // 
            // FormForCandyStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 406);
            this.Controls.Add(this.tbNameSalesperson);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.btnSaveInformationToFile);
            this.Controls.Add(this.btnChangePrice);
            this.Controls.Add(this.btnShowWeightsMixedCandy);
            this.Controls.Add(this.btnShowSoldMixedCandy);
            this.Controls.Add(this.btnShowAllSoldCandy);
            this.Controls.Add(this.lbOverview);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.rbMixedCandy);
            this.Controls.Add(this.rbPackedCandy);
            this.Controls.Add(this.gbMixedCandy);
            this.Controls.Add(this.gbPackedCandy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormForCandyStore";
            this.Text = "Form1";
            this.gbPackedCandy.ResumeLayout(false);
            this.gbPackedCandy.PerformLayout();
            this.gbMixedCandy.ResumeLayout(false);
            this.gbMixedCandy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPackedCandy;
        private System.Windows.Forms.GroupBox gbMixedCandy;
        private System.Windows.Forms.RadioButton rbPackedCandy;
        private System.Windows.Forms.RadioButton rbMixedCandy;
        private System.Windows.Forms.TextBox tbNumberOfBags;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWeightOfGummyDrops;
        private System.Windows.Forms.TextBox tbWeightOfChewingGums;
        private System.Windows.Forms.TextBox tbWeightOfLollipops;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.ListBox lbPackedCandy;
        private System.Windows.Forms.ListBox lbOverview;
        private System.Windows.Forms.Button btnShowAllSoldCandy;
        private System.Windows.Forms.Button btnShowSoldMixedCandy;
        private System.Windows.Forms.Button btnShowWeightsMixedCandy;
        private System.Windows.Forms.Button btnSaveInformationToFile;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button btnChangePrice;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNameSalesperson;
    }
}

