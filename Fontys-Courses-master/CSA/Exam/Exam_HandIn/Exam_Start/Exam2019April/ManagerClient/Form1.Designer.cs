namespace ManagerClient
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
            this.btBlockUser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btGetUsers = new System.Windows.Forms.Button();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBlockUser
            // 
            this.btBlockUser.Location = new System.Drawing.Point(89, 159);
            this.btBlockUser.Name = "btBlockUser";
            this.btBlockUser.Size = new System.Drawing.Size(75, 23);
            this.btBlockUser.TabIndex = 2;
            this.btBlockUser.Text = "Block user";
            this.btBlockUser.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btGetUsers);
            this.groupBox1.Controls.Add(this.lbUsers);
            this.groupBox1.Controls.Add(this.btBlockUser);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 190);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage users";
            // 
            // btGetUsers
            // 
            this.btGetUsers.Location = new System.Drawing.Point(6, 159);
            this.btGetUsers.Name = "btGetUsers";
            this.btGetUsers.Size = new System.Drawing.Size(75, 23);
            this.btGetUsers.TabIndex = 0;
            this.btGetUsers.Text = "Get users";
            this.btGetUsers.UseVisualStyleBackColor = true;
            this.btGetUsers.Click += new System.EventHandler(this.btGetUsers_Click);
            // 
            // lbUsers
            // 
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.Location = new System.Drawing.Point(6, 19);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(156, 134);
            this.lbUsers.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 212);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Users Manager";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBlockUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Button btGetUsers;
    }
}

