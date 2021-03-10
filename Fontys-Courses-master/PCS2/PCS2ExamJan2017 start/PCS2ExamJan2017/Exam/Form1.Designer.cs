namespace Exam
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.nudSeniors = new System.Windows.Forms.NumericUpDown();
            this.nudAdults = new System.Windows.Forms.NumericUpDown();
            this.nudChildren = new System.Windows.Forms.NumericUpDown();
            this.lbTicketType = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbLunch = new System.Windows.Forms.CheckBox();
            this.cbGuide = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbOrders = new System.Windows.Forms.GroupBox();
            this.btnShowNotCheckedIn = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.listBoxOrders = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbOrderNr = new System.Windows.Forms.TextBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeniors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildren)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbOrders.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnAddOrder);
            this.groupBox1.Controls.Add(this.nudSeniors);
            this.groupBox1.Controls.Add(this.nudAdults);
            this.groupBox1.Controls.Add(this.nudChildren);
            this.groupBox1.Controls.Add(this.lbTicketType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lbPrice);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buy tickets";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Last added order info:";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(6, 184);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(95, 23);
            this.btnAddOrder.TabIndex = 28;
            this.btnAddOrder.Text = "Add order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // nudSeniors
            // 
            this.nudSeniors.Location = new System.Drawing.Point(127, 74);
            this.nudSeniors.Name = "nudSeniors";
            this.nudSeniors.Size = new System.Drawing.Size(48, 20);
            this.nudSeniors.TabIndex = 27;
            // 
            // nudAdults
            // 
            this.nudAdults.Location = new System.Drawing.Point(127, 48);
            this.nudAdults.Name = "nudAdults";
            this.nudAdults.Size = new System.Drawing.Size(48, 20);
            this.nudAdults.TabIndex = 26;
            // 
            // nudChildren
            // 
            this.nudChildren.Location = new System.Drawing.Point(127, 22);
            this.nudChildren.Name = "nudChildren";
            this.nudChildren.Size = new System.Drawing.Size(48, 20);
            this.nudChildren.TabIndex = 25;
            // 
            // lbTicketType
            // 
            this.lbTicketType.AutoSize = true;
            this.lbTicketType.Location = new System.Drawing.Point(74, 244);
            this.lbTicketType.Name = "lbTicketType";
            this.lbTicketType.Size = new System.Drawing.Size(16, 13);
            this.lbTicketType.TabIndex = 24;
            this.lbTicketType.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Order type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Order price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "6 EUR/person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "10 EUR/person";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "0 EUR/person";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Seniors (from 65 years)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Adults (12-65 years)";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(74, 231);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(13, 13);
            this.lbPrice.TabIndex = 10;
            this.lbPrice.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbLunch);
            this.groupBox2.Controls.Add(this.cbGuide);
            this.groupBox2.Location = new System.Drawing.Point(6, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 68);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional services";
            // 
            // cbLunch
            // 
            this.cbLunch.AutoSize = true;
            this.cbLunch.Location = new System.Drawing.Point(6, 41);
            this.cbLunch.Name = "cbLunch";
            this.cbLunch.Size = new System.Drawing.Size(148, 17);
            this.cbLunch.TabIndex = 1;
            this.cbLunch.Text = "Lunch (+ 6.00 per person)";
            this.cbLunch.UseVisualStyleBackColor = true;
            // 
            // cbGuide
            // 
            this.cbGuide.AutoSize = true;
            this.cbGuide.Location = new System.Drawing.Point(6, 19);
            this.cbGuide.Name = "cbGuide";
            this.cbGuide.Size = new System.Drawing.Size(144, 17);
            this.cbGuide.TabIndex = 0;
            this.cbGuide.Text = "Guide (+22.50 per group)";
            this.cbGuide.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Children (0-12 years)";
            // 
            // gbOrders
            // 
            this.gbOrders.BackColor = System.Drawing.Color.LightGreen;
            this.gbOrders.Controls.Add(this.btnShowNotCheckedIn);
            this.gbOrders.Controls.Add(this.btnShowAll);
            this.gbOrders.Controls.Add(this.listBoxOrders);
            this.gbOrders.Location = new System.Drawing.Point(306, 12);
            this.gbOrders.Name = "gbOrders";
            this.gbOrders.Size = new System.Drawing.Size(311, 189);
            this.gbOrders.TabIndex = 1;
            this.gbOrders.TabStop = false;
            this.gbOrders.Text = "Administrate orders";
            // 
            // btnShowNotCheckedIn
            // 
            this.btnShowNotCheckedIn.Location = new System.Drawing.Point(119, 19);
            this.btnShowNotCheckedIn.Name = "btnShowNotCheckedIn";
            this.btnShowNotCheckedIn.Size = new System.Drawing.Size(101, 23);
            this.btnShowNotCheckedIn.TabIndex = 16;
            this.btnShowNotCheckedIn.Text = "Show unchecked ";
            this.btnShowNotCheckedIn.UseVisualStyleBackColor = true;
            this.btnShowNotCheckedIn.Click += new System.EventHandler(this.btnShowNotCheckedIn_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(12, 19);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(101, 23);
            this.btnShowAll.TabIndex = 15;
            this.btnShowAll.Text = "Show all";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // listBoxOrders
            // 
            this.listBoxOrders.FormattingEnabled = true;
            this.listBoxOrders.Location = new System.Drawing.Point(12, 50);
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.Size = new System.Drawing.Size(293, 108);
            this.listBoxOrders.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Order no.:";
            // 
            // tbOrderNr
            // 
            this.tbOrderNr.Location = new System.Drawing.Point(69, 24);
            this.tbOrderNr.Name = "tbOrderNr";
            this.tbOrderNr.Size = new System.Drawing.Size(70, 20);
            this.tbOrderNr.TabIndex = 16;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(145, 22);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(75, 23);
            this.btnCheckIn.TabIndex = 4;
            this.btnCheckIn.Text = "Check in";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox3.Controls.Add(this.tbOrderNr);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnCheckIn);
            this.groupBox3.Location = new System.Drawing.Point(306, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 73);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Check order";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 292);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbOrders);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeniors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildren)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbOrders.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.CheckBox cbLunch;
        private System.Windows.Forms.CheckBox cbGuide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbOrders;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.ListBox listBoxOrders;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbOrderNr;
        private System.Windows.Forms.Button btnShowNotCheckedIn;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTicketType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudSeniors;
        private System.Windows.Forms.NumericUpDown nudAdults;
        private System.Windows.Forms.NumericUpDown nudChildren;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label label9;
    }
}

