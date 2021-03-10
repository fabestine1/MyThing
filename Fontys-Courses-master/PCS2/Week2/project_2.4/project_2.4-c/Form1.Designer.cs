namespace project_2._4_c
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
            this.lbxAccount2 = new System.Windows.Forms.ListBox();
            this.gbxAccount3 = new System.Windows.Forms.ListBox();
            this.lbxAccount1 = new System.Windows.Forms.ListBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cbAccount = new System.Windows.Forms.ComboBox();
            this.gbxAccount1 = new System.Windows.Forms.GroupBox();
            this.gbxAccount2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbxActions = new System.Windows.Forms.GroupBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.gbxAccount1.SuspendLayout();
            this.gbxAccount2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxAccount2
            // 
            this.lbxAccount2.FormattingEnabled = true;
            this.lbxAccount2.Location = new System.Drawing.Point(11, 16);
            this.lbxAccount2.Name = "lbxAccount2";
            this.lbxAccount2.Size = new System.Drawing.Size(251, 121);
            this.lbxAccount2.TabIndex = 1;
            // 
            // gbxAccount3
            // 
            this.gbxAccount3.FormattingEnabled = true;
            this.gbxAccount3.Location = new System.Drawing.Point(6, 17);
            this.gbxAccount3.Name = "gbxAccount3";
            this.gbxAccount3.Size = new System.Drawing.Size(251, 121);
            this.gbxAccount3.TabIndex = 2;
            // 
            // lbxAccount1
            // 
            this.lbxAccount1.FormattingEnabled = true;
            this.lbxAccount1.Location = new System.Drawing.Point(6, 19);
            this.lbxAccount1.Name = "lbxAccount1";
            this.lbxAccount1.Size = new System.Drawing.Size(251, 121);
            this.lbxAccount1.TabIndex = 3;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(104, 115);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 7;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(185, 115);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw.TabIndex = 8;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(72, 48);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(189, 20);
            this.tbxAmount.TabIndex = 9;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(17, 51);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Amount:";
            // 
            // cbAccount
            // 
            this.cbAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccount.FormattingEnabled = true;
            this.cbAccount.Location = new System.Drawing.Point(73, 21);
            this.cbAccount.Name = "cbAccount";
            this.cbAccount.Size = new System.Drawing.Size(188, 21);
            this.cbAccount.TabIndex = 11;
            this.cbAccount.SelectedIndexChanged += new System.EventHandler(this.cbAccount_SelectedIndexChanged);
            // 
            // gbxAccount1
            // 
            this.gbxAccount1.Controls.Add(this.lbxAccount2);
            this.gbxAccount1.Location = new System.Drawing.Point(347, 59);
            this.gbxAccount1.Name = "gbxAccount1";
            this.gbxAccount1.Size = new System.Drawing.Size(273, 149);
            this.gbxAccount1.TabIndex = 12;
            this.gbxAccount1.TabStop = false;
            this.gbxAccount1.Text = "Account A";
            // 
            // gbxAccount2
            // 
            this.gbxAccount2.Controls.Add(this.lbxAccount1);
            this.gbxAccount2.Location = new System.Drawing.Point(648, 58);
            this.gbxAccount2.Name = "gbxAccount2";
            this.gbxAccount2.Size = new System.Drawing.Size(267, 150);
            this.gbxAccount2.TabIndex = 0;
            this.gbxAccount2.TabStop = false;
            this.gbxAccount2.Text = "Account B";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gbxAccount3);
            this.groupBox3.Location = new System.Drawing.Point(941, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 150);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account C";
            // 
            // gbxActions
            // 
            this.gbxActions.Controls.Add(this.lblAccount);
            this.gbxActions.Controls.Add(this.cbAccount);
            this.gbxActions.Controls.Add(this.lblAmount);
            this.gbxActions.Controls.Add(this.tbxAmount);
            this.gbxActions.Controls.Add(this.btnWithdraw);
            this.gbxActions.Controls.Add(this.btnDeposit);
            this.gbxActions.Location = new System.Drawing.Point(26, 58);
            this.gbxActions.Name = "gbxActions";
            this.gbxActions.Size = new System.Drawing.Size(290, 150);
            this.gbxActions.TabIndex = 13;
            this.gbxActions.TabStop = false;
            this.gbxActions.Text = "Actions";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(17, 24);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(50, 13);
            this.lblAccount.TabIndex = 12;
            this.lblAccount.Text = "Account:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 261);
            this.Controls.Add(this.gbxActions);
            this.Controls.Add(this.gbxAccount2);
            this.Controls.Add(this.gbxAccount1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxAccount1.ResumeLayout(false);
            this.gbxAccount2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.gbxActions.ResumeLayout(false);
            this.gbxActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxAccount2;
        private System.Windows.Forms.ListBox gbxAccount3;
        private System.Windows.Forms.ListBox lbxAccount1;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cbAccount;
        private System.Windows.Forms.GroupBox gbxAccount1;
        private System.Windows.Forms.GroupBox gbxAccount2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbxActions;
        private System.Windows.Forms.Label lblAccount;
    }
}

