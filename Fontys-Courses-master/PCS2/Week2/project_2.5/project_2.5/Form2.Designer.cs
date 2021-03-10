namespace project_2._5
{
    partial class Form2
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
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.tbxClientName = new System.Windows.Forms.TextBox();
            this.clientBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(78, 181);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(142, 23);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Create new user";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // tbxClientName
            // 
            this.tbxClientName.Location = new System.Drawing.Point(69, 56);
            this.tbxClientName.Name = "tbxClientName";
            this.tbxClientName.Size = new System.Drawing.Size(200, 20);
            this.tbxClientName.TabIndex = 1;
            this.tbxClientName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clientBirthDate
            // 
            this.clientBirthDate.Location = new System.Drawing.Point(69, 116);
            this.clientBirthDate.Name = "clientBirthDate";
            this.clientBirthDate.Size = new System.Drawing.Size(200, 20);
            this.clientBirthDate.TabIndex = 2;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(2, 59);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(65, 13);
            this.lblClientName.TabIndex = 3;
            this.lblClientName.Text = "Client name:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(12, 122);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(55, 13);
            this.lblBirthDate.TabIndex = 4;
            this.lblBirthDate.Text = "Birth date:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.clientBirthDate);
            this.Controls.Add(this.tbxClientName);
            this.Controls.Add(this.btnCreateUser);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.TextBox tbxClientName;
        private System.Windows.Forms.DateTimePicker clientBirthDate;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblBirthDate;
    }
}