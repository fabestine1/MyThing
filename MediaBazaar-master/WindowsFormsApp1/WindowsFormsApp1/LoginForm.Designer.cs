namespace MediaBazar
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.usernameLoginInput = new System.Windows.Forms.TextBox();
            this.mediaBazarLogoLogin = new System.Windows.Forms.PictureBox();
            this.passwordLoginInput = new System.Windows.Forms.TextBox();
            this.loginBttn = new System.Windows.Forms.Button();
            this.usernameLoginLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mediaBazarLogoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your credentials";
            // 
            // usernameLoginInput
            // 
            this.usernameLoginInput.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLoginInput.Location = new System.Drawing.Point(56, 226);
            this.usernameLoginInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameLoginInput.Name = "usernameLoginInput";
            this.usernameLoginInput.Size = new System.Drawing.Size(498, 51);
            this.usernameLoginInput.TabIndex = 1;
            // 
            // mediaBazarLogoLogin
            // 
            this.mediaBazarLogoLogin.Image = global::MediaBazar.Properties.Resources.DigitalTech_Logo_3;
            this.mediaBazarLogoLogin.Location = new System.Drawing.Point(620, 12);
            this.mediaBazarLogoLogin.Margin = new System.Windows.Forms.Padding(0);
            this.mediaBazarLogoLogin.Name = "mediaBazarLogoLogin";
            this.mediaBazarLogoLogin.Size = new System.Drawing.Size(567, 531);
            this.mediaBazarLogoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mediaBazarLogoLogin.TabIndex = 2;
            this.mediaBazarLogoLogin.TabStop = false;
            // 
            // passwordLoginInput
            // 
            this.passwordLoginInput.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLoginInput.Location = new System.Drawing.Point(56, 354);
            this.passwordLoginInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordLoginInput.Name = "passwordLoginInput";
            this.passwordLoginInput.Size = new System.Drawing.Size(498, 51);
            this.passwordLoginInput.TabIndex = 3;
            this.passwordLoginInput.UseSystemPasswordChar = true;
            // 
            // loginBttn
            // 
            this.loginBttn.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBttn.Location = new System.Drawing.Point(92, 469);
            this.loginBttn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginBttn.Name = "loginBttn";
            this.loginBttn.Size = new System.Drawing.Size(428, 74);
            this.loginBttn.TabIndex = 4;
            this.loginBttn.Text = "Login";
            this.loginBttn.UseVisualStyleBackColor = true;
            this.loginBttn.Click += new System.EventHandler(this.loginBttn_Click);
            // 
            // usernameLoginLbl
            // 
            this.usernameLoginLbl.AutoSize = true;
            this.usernameLoginLbl.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLoginLbl.Location = new System.Drawing.Point(46, 171);
            this.usernameLoginLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLoginLbl.Name = "usernameLoginLbl";
            this.usernameLoginLbl.Size = new System.Drawing.Size(218, 50);
            this.usernameLoginLbl.TabIndex = 5;
            this.usernameLoginLbl.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 50);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 620);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernameLoginLbl);
            this.Controls.Add(this.loginBttn);
            this.Controls.Add(this.passwordLoginInput);
            this.Controls.Add(this.mediaBazarLogoLogin);
            this.Controls.Add(this.usernameLoginInput);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.Text = "Media Bazar";
            ((System.ComponentModel.ISupportInitialize)(this.mediaBazarLogoLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameLoginInput;
        private System.Windows.Forms.PictureBox mediaBazarLogoLogin;
        private System.Windows.Forms.TextBox passwordLoginInput;
        private System.Windows.Forms.Button loginBttn;
        private System.Windows.Forms.Label usernameLoginLbl;
        private System.Windows.Forms.Label label3;
    }
}

