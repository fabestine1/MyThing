namespace PCS4EXAM
{
    partial class FormCrowdfunding
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
            this.btnsortOnNumberOfDonationsName = new System.Windows.Forms.Button();
            this.btnSortOnTotalDonations = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbNameDonator = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbThreshold = new System.Windows.Forms.TextBox();
            this.tbWebsite = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbNameStartup = new System.Windows.Forms.TextBox();
            this.btnAddDonation = new System.Windows.Forms.Button();
            this.btnAddStartup = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnShowLinkedList = new System.Windows.Forms.Button();
            this.btnShowAllStartups = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(537, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(628, 384);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.btnsortOnNumberOfDonationsName);
            this.groupBox1.Controls.Add(this.btnSortOnTotalDonations);
            this.groupBox1.Location = new System.Drawing.Point(7, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "about sorting";
            // 
            // btnsortOnNumberOfDonationsName
            // 
            this.btnsortOnNumberOfDonationsName.Location = new System.Drawing.Point(200, 22);
            this.btnsortOnNumberOfDonationsName.Name = "btnsortOnNumberOfDonationsName";
            this.btnsortOnNumberOfDonationsName.Size = new System.Drawing.Size(306, 43);
            this.btnsortOnNumberOfDonationsName.TabIndex = 1;
            this.btnsortOnNumberOfDonationsName.Text = "sort on number of donations/name";
            this.btnsortOnNumberOfDonationsName.UseVisualStyleBackColor = true;
            this.btnsortOnNumberOfDonationsName.Click += new System.EventHandler(this.btnsortOnNumberOfDonationsName_Click);
            // 
            // btnSortOnTotalDonations
            // 
            this.btnSortOnTotalDonations.Location = new System.Drawing.Point(6, 22);
            this.btnSortOnTotalDonations.Name = "btnSortOnTotalDonations";
            this.btnSortOnTotalDonations.Size = new System.Drawing.Size(179, 43);
            this.btnSortOnTotalDonations.TabIndex = 0;
            this.btnSortOnTotalDonations.Text = "sort on total donations";
            this.btnSortOnTotalDonations.UseVisualStyleBackColor = true;
            this.btnSortOnTotalDonations.Click += new System.EventHandler(this.btnSortOnTotalDonations_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Turquoise;
            this.groupBox2.Controls.Add(this.tbAmount);
            this.groupBox2.Controls.Add(this.tbNameDonator);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbThreshold);
            this.groupBox2.Controls.Add(this.tbWebsite);
            this.groupBox2.Controls.Add(this.tbDescription);
            this.groupBox2.Controls.Add(this.tbNameStartup);
            this.groupBox2.Controls.Add(this.btnAddDonation);
            this.groupBox2.Controls.Add(this.btnAddStartup);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 241);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "about startups and donations";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(158, 204);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(162, 26);
            this.tbAmount.TabIndex = 13;
            // 
            // tbNameDonator
            // 
            this.tbNameDonator.Location = new System.Drawing.Point(158, 171);
            this.tbNameDonator.Name = "tbNameDonator";
            this.tbNameDonator.Size = new System.Drawing.Size(162, 26);
            this.tbNameDonator.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "amount donation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "name donator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "threshold";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "website";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "name startup";
            // 
            // tbThreshold
            // 
            this.tbThreshold.Location = new System.Drawing.Point(117, 129);
            this.tbThreshold.Name = "tbThreshold";
            this.tbThreshold.Size = new System.Drawing.Size(121, 26);
            this.tbThreshold.TabIndex = 5;
            // 
            // tbWebsite
            // 
            this.tbWebsite.Location = new System.Drawing.Point(115, 95);
            this.tbWebsite.Name = "tbWebsite";
            this.tbWebsite.Size = new System.Drawing.Size(258, 26);
            this.tbWebsite.TabIndex = 4;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(117, 58);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(256, 26);
            this.tbDescription.TabIndex = 3;
            // 
            // tbNameStartup
            // 
            this.tbNameStartup.Location = new System.Drawing.Point(117, 26);
            this.tbNameStartup.Name = "tbNameStartup";
            this.tbNameStartup.Size = new System.Drawing.Size(123, 26);
            this.tbNameStartup.TabIndex = 2;
            // 
            // btnAddDonation
            // 
            this.btnAddDonation.Location = new System.Drawing.Point(393, 143);
            this.btnAddDonation.Name = "btnAddDonation";
            this.btnAddDonation.Size = new System.Drawing.Size(87, 75);
            this.btnAddDonation.TabIndex = 1;
            this.btnAddDonation.Text = "add donation";
            this.btnAddDonation.UseVisualStyleBackColor = true;
            this.btnAddDonation.Click += new System.EventHandler(this.btnAddDonation_Click);
            // 
            // btnAddStartup
            // 
            this.btnAddStartup.Location = new System.Drawing.Point(393, 48);
            this.btnAddStartup.Name = "btnAddStartup";
            this.btnAddStartup.Size = new System.Drawing.Size(87, 89);
            this.btnAddStartup.TabIndex = 0;
            this.btnAddStartup.Text = "add a startup";
            this.btnAddStartup.UseVisualStyleBackColor = true;
            this.btnAddStartup.Click += new System.EventHandler(this.btnAddStartup_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox3.Location = new System.Drawing.Point(13, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 96);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "about assignment 3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 458);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 26);
            this.panel1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(754, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "label7";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox4.Controls.Add(this.btnShowLinkedList);
            this.groupBox4.Location = new System.Drawing.Point(275, 338);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 96);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "about assignment 4";
            // 
            // btnShowLinkedList
            // 
            this.btnShowLinkedList.Location = new System.Drawing.Point(34, 25);
            this.btnShowLinkedList.Name = "btnShowLinkedList";
            this.btnShowLinkedList.Size = new System.Drawing.Size(150, 50);
            this.btnShowLinkedList.TabIndex = 0;
            this.btnShowLinkedList.Text = "show linked list";
            this.btnShowLinkedList.UseVisualStyleBackColor = true;
            this.btnShowLinkedList.Click += new System.EventHandler(this.btnShowLinkedList_Click);
            // 
            // btnShowAllStartups
            // 
            this.btnShowAllStartups.BackColor = System.Drawing.Color.DarkOrange;
            this.btnShowAllStartups.Location = new System.Drawing.Point(679, 408);
            this.btnShowAllStartups.Name = "btnShowAllStartups";
            this.btnShowAllStartups.Size = new System.Drawing.Size(309, 38);
            this.btnShowAllStartups.TabIndex = 6;
            this.btnShowAllStartups.Text = "show all startups";
            this.btnShowAllStartups.UseVisualStyleBackColor = false;
            this.btnShowAllStartups.Click += new System.EventHandler(this.btnShowAllStartups_Click);
            // 
            // FormCrowdfunding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 484);
            this.Controls.Add(this.btnShowAllStartups);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCrowdfunding";
            this.Text = "Crowdfunding";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnsortOnNumberOfDonationsName;
        private System.Windows.Forms.Button btnSortOnTotalDonations;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbThreshold;
        private System.Windows.Forms.TextBox tbWebsite;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbNameStartup;
        private System.Windows.Forms.Button btnAddDonation;
        private System.Windows.Forms.Button btnAddStartup;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbNameDonator;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnShowLinkedList;
        private System.Windows.Forms.Button btnShowAllStartups;
    }
}

