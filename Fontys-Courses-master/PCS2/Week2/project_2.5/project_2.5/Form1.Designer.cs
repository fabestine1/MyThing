namespace project_2._5
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
            this.lbxClient1 = new System.Windows.Forms.ListBox();
            this.lbxClient2 = new System.Windows.Forms.ListBox();
            this.lbxClient3 = new System.Windows.Forms.ListBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.rbtnCheckings = new System.Windows.Forms.RadioButton();
            this.rbtnSavings = new System.Windows.Forms.RadioButton();
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.createUserPanel = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.tbxClientName = new System.Windows.Forms.TextBox();
            this.clientBirthDate = new System.Windows.Forms.DateTimePicker();
            this.createUserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxClient1
            // 
            this.lbxClient1.FormattingEnabled = true;
            this.lbxClient1.Location = new System.Drawing.Point(501, 27);
            this.lbxClient1.Name = "lbxClient1";
            this.lbxClient1.Size = new System.Drawing.Size(377, 95);
            this.lbxClient1.TabIndex = 3;
            // 
            // lbxClient2
            // 
            this.lbxClient2.FormattingEnabled = true;
            this.lbxClient2.Location = new System.Drawing.Point(884, 27);
            this.lbxClient2.Name = "lbxClient2";
            this.lbxClient2.Size = new System.Drawing.Size(377, 95);
            this.lbxClient2.TabIndex = 4;
            // 
            // lbxClient3
            // 
            this.lbxClient3.FormattingEnabled = true;
            this.lbxClient3.Location = new System.Drawing.Point(501, 128);
            this.lbxClient3.Name = "lbxClient3";
            this.lbxClient3.Size = new System.Drawing.Size(377, 95);
            this.lbxClient3.TabIndex = 5;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(40, 197);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 6;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(121, 197);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw.TabIndex = 7;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(37, 163);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Amount:";
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(82, 160);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(114, 20);
            this.tbxAmount.TabIndex = 9;
            // 
            // rbtnCheckings
            // 
            this.rbtnCheckings.AutoSize = true;
            this.rbtnCheckings.Checked = true;
            this.rbtnCheckings.Location = new System.Drawing.Point(40, 93);
            this.rbtnCheckings.Name = "rbtnCheckings";
            this.rbtnCheckings.Size = new System.Drawing.Size(118, 17);
            this.rbtnCheckings.TabIndex = 11;
            this.rbtnCheckings.TabStop = true;
            this.rbtnCheckings.Text = "Checkings Account";
            this.rbtnCheckings.UseVisualStyleBackColor = true;
            // 
            // rbtnSavings
            // 
            this.rbtnSavings.AutoSize = true;
            this.rbtnSavings.Location = new System.Drawing.Point(40, 116);
            this.rbtnSavings.Name = "rbtnSavings";
            this.rbtnSavings.Size = new System.Drawing.Size(106, 17);
            this.rbtnSavings.TabIndex = 12;
            this.rbtnSavings.Text = "Savings Account";
            this.rbtnSavings.UseVisualStyleBackColor = true;
            // 
            // cbClients
            // 
            this.cbClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClients.FormattingEnabled = true;
            this.cbClients.Location = new System.Drawing.Point(40, 27);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(121, 21);
            this.cbClients.TabIndex = 13;
            this.cbClients.SelectedIndexChanged += new System.EventHandler(this.cbClients_SelectedIndexChanged);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(37, 64);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(121, 23);
            this.btnNewUser.TabIndex = 15;
            this.btnNewUser.Text = "Create new user";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // createUserPanel
            // 
            this.createUserPanel.Controls.Add(this.btnCreate);
            this.createUserPanel.Controls.Add(this.lblClientName);
            this.createUserPanel.Controls.Add(this.lblBirthDate);
            this.createUserPanel.Controls.Add(this.tbxClientName);
            this.createUserPanel.Controls.Add(this.clientBirthDate);
            this.createUserPanel.Location = new System.Drawing.Point(202, 27);
            this.createUserPanel.Name = "createUserPanel";
            this.createUserPanel.Size = new System.Drawing.Size(293, 196);
            this.createUserPanel.TabIndex = 16;
            this.createUserPanel.Visible = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(81, 126);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(10, 40);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(65, 13);
            this.lblClientName.TabIndex = 17;
            this.lblClientName.Text = "Client name:";
            this.lblClientName.Click += new System.EventHandler(this.lblClientName_Click);
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(10, 78);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(55, 13);
            this.lblBirthDate.TabIndex = 18;
            this.lblBirthDate.Text = "Birth date:";
            this.lblBirthDate.Click += new System.EventHandler(this.lblBirthDate_Click);
            // 
            // tbxClientName
            // 
            this.tbxClientName.Location = new System.Drawing.Point(81, 37);
            this.tbxClientName.Name = "tbxClientName";
            this.tbxClientName.Size = new System.Drawing.Size(200, 20);
            this.tbxClientName.TabIndex = 19;
            // 
            // clientBirthDate
            // 
            this.clientBirthDate.Location = new System.Drawing.Point(81, 72);
            this.clientBirthDate.Name = "clientBirthDate";
            this.clientBirthDate.Size = new System.Drawing.Size(200, 20);
            this.clientBirthDate.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 277);
            this.Controls.Add(this.createUserPanel);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.cbClients);
            this.Controls.Add(this.rbtnSavings);
            this.Controls.Add(this.rbtnCheckings);
            this.Controls.Add(this.tbxAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.lbxClient3);
            this.Controls.Add(this.lbxClient2);
            this.Controls.Add(this.lbxClient1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.createUserPanel.ResumeLayout(false);
            this.createUserPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxClient1;
        private System.Windows.Forms.ListBox lbxClient2;
        private System.Windows.Forms.ListBox lbxClient3;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.RadioButton rbtnCheckings;
        private System.Windows.Forms.RadioButton rbtnSavings;
        private System.Windows.Forms.ComboBox cbClients;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Panel createUserPanel;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox tbxClientName;
        private System.Windows.Forms.DateTimePicker clientBirthDate;
        private System.Windows.Forms.Button btnCreate;
    }
}

