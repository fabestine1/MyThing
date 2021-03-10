namespace StudentWiseClient
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.CreateAccountLbl = new System.Windows.Forms.Label();
            this.LogoPbx = new System.Windows.Forms.PictureBox();
            this.emailAddressTbx = new System.Windows.Forms.TextBox();
            this.passwordTbx = new System.Windows.Forms.TextBox();
            this.fNameTbx = new System.Windows.Forms.TextBox();
            this.lNameTbx = new System.Windows.Forms.TextBox();
            this.emailAddressLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.fNameLbl = new System.Windows.Forms.Label();
            this.lNameLbl = new System.Windows.Forms.Label();
            this.loginLinkL = new System.Windows.Forms.LinkLabel();
            this.textLbl = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPbx)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateAccountLbl
            // 
            this.CreateAccountLbl.AutoSize = true;
            this.CreateAccountLbl.Font = new System.Drawing.Font("Oswald", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountLbl.Location = new System.Drawing.Point(155, 12);
            this.CreateAccountLbl.MaximumSize = new System.Drawing.Size(250, 0);
            this.CreateAccountLbl.Name = "CreateAccountLbl";
            this.CreateAccountLbl.Size = new System.Drawing.Size(192, 146);
            this.CreateAccountLbl.TabIndex = 3;
            this.CreateAccountLbl.Text = "Create an account";
            // 
            // LogoPbx
            // 
            this.LogoPbx.Image = global::StudentWiseClient.Properties.Resources.StudentwISEvBuilders__1_1;
            this.LogoPbx.Location = new System.Drawing.Point(16, 12);
            this.LogoPbx.Name = "LogoPbx";
            this.LogoPbx.Size = new System.Drawing.Size(130, 145);
            this.LogoPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPbx.TabIndex = 2;
            this.LogoPbx.TabStop = false;
            // 
            // emailAddressTbx
            // 
            this.emailAddressTbx.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressTbx.Location = new System.Drawing.Point(24, 321);
            this.emailAddressTbx.Name = "emailAddressTbx";
            this.emailAddressTbx.Size = new System.Drawing.Size(364, 37);
            this.emailAddressTbx.TabIndex = 3;
            // 
            // passwordTbx
            // 
            this.passwordTbx.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTbx.Location = new System.Drawing.Point(24, 416);
            this.passwordTbx.Name = "passwordTbx";
            this.passwordTbx.PasswordChar = '*';
            this.passwordTbx.Size = new System.Drawing.Size(364, 37);
            this.passwordTbx.TabIndex = 4;
            this.passwordTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTbx_KeyPress);
            // 
            // fNameTbx
            // 
            this.fNameTbx.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameTbx.Location = new System.Drawing.Point(24, 226);
            this.fNameTbx.Name = "fNameTbx";
            this.fNameTbx.Size = new System.Drawing.Size(171, 37);
            this.fNameTbx.TabIndex = 1;
            // 
            // lNameTbx
            // 
            this.lNameTbx.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameTbx.Location = new System.Drawing.Point(219, 226);
            this.lNameTbx.Name = "lNameTbx";
            this.lNameTbx.Size = new System.Drawing.Size(171, 37);
            this.lNameTbx.TabIndex = 2;
            // 
            // emailAddressLbl
            // 
            this.emailAddressLbl.AutoSize = true;
            this.emailAddressLbl.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressLbl.Location = new System.Drawing.Point(17, 267);
            this.emailAddressLbl.Name = "emailAddressLbl";
            this.emailAddressLbl.Size = new System.Drawing.Size(178, 51);
            this.emailAddressLbl.TabIndex = 9;
            this.emailAddressLbl.Text = "Email address:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(15, 362);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(131, 51);
            this.passwordLbl.TabIndex = 10;
            this.passwordLbl.Text = "Password:";
            // 
            // fNameLbl
            // 
            this.fNameLbl.AutoSize = true;
            this.fNameLbl.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLbl.Location = new System.Drawing.Point(15, 172);
            this.fNameLbl.Name = "fNameLbl";
            this.fNameLbl.Size = new System.Drawing.Size(143, 51);
            this.fNameLbl.TabIndex = 11;
            this.fNameLbl.Text = "First name:";
            // 
            // lNameLbl
            // 
            this.lNameLbl.AutoSize = true;
            this.lNameLbl.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameLbl.Location = new System.Drawing.Point(210, 172);
            this.lNameLbl.Name = "lNameLbl";
            this.lNameLbl.Size = new System.Drawing.Size(139, 51);
            this.lNameLbl.TabIndex = 12;
            this.lNameLbl.Text = "Last name:";
            // 
            // loginLinkL
            // 
            this.loginLinkL.AutoSize = true;
            this.loginLinkL.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLinkL.Location = new System.Drawing.Point(172, 566);
            this.loginLinkL.Name = "loginLinkL";
            this.loginLinkL.Size = new System.Drawing.Size(64, 35);
            this.loginLinkL.TabIndex = 6;
            this.loginLinkL.TabStop = true;
            this.loginLinkL.Text = "Log in!";
            this.loginLinkL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLinkL_LinkClicked);
            // 
            // textLbl
            // 
            this.textLbl.AutoSize = true;
            this.textLbl.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLbl.Location = new System.Drawing.Point(100, 531);
            this.textLbl.Name = "textLbl";
            this.textLbl.Size = new System.Drawing.Size(205, 35);
            this.textLbl.TabIndex = 14;
            this.textLbl.Text = "Already have an account?";
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.registerBtn.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(75, 467);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(255, 61);
            this.registerBtn.TabIndex = 5;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 610);
            this.Controls.Add(this.loginLinkL);
            this.Controls.Add(this.textLbl);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.lNameLbl);
            this.Controls.Add(this.fNameLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.emailAddressLbl);
            this.Controls.Add(this.lNameTbx);
            this.Controls.Add(this.fNameTbx);
            this.Controls.Add(this.passwordTbx);
            this.Controls.Add(this.emailAddressTbx);
            this.Controls.Add(this.CreateAccountLbl);
            this.Controls.Add(this.LogoPbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPbx;
        private System.Windows.Forms.Label CreateAccountLbl;
        private System.Windows.Forms.TextBox emailAddressTbx;
        private System.Windows.Forms.TextBox passwordTbx;
        private System.Windows.Forms.TextBox fNameTbx;
        private System.Windows.Forms.TextBox lNameTbx;
        private System.Windows.Forms.Label emailAddressLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label fNameLbl;
        private System.Windows.Forms.Label lNameLbl;
        private System.Windows.Forms.LinkLabel loginLinkL;
        private System.Windows.Forms.Label textLbl;
        private System.Windows.Forms.Button registerBtn;
    }
}