namespace _2._4
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
            this.btInfo = new System.Windows.Forms.Button();
            this.rbCheckings = new System.Windows.Forms.RadioButton();
            this.tbDeposit = new System.Windows.Forms.TextBox();
            this.lbChekings = new System.Windows.Forms.Label();
            this.lbSavings = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btDeposit = new System.Windows.Forms.Button();
            this.btWithdraw = new System.Windows.Forms.Button();
            this.tbChekings = new System.Windows.Forms.TextBox();
            this.tbWithdraw = new System.Windows.Forms.TextBox();
            this.rbSavings = new System.Windows.Forms.RadioButton();
            this.tbSavings = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btInfo
            // 
            this.btInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btInfo.ForeColor = System.Drawing.Color.Blue;
            this.btInfo.Location = new System.Drawing.Point(31, 242);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(69, 55);
            this.btInfo.TabIndex = 0;
            this.btInfo.Text = "Client Info";
            this.btInfo.UseVisualStyleBackColor = true;
            this.btInfo.Click += new System.EventHandler(this.btInfo_Click);
            // 
            // rbCheckings
            // 
            this.rbCheckings.AutoSize = true;
            this.rbCheckings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbCheckings.ForeColor = System.Drawing.Color.Blue;
            this.rbCheckings.Location = new System.Drawing.Point(239, 56);
            this.rbCheckings.Name = "rbCheckings";
            this.rbCheckings.Size = new System.Drawing.Size(82, 20);
            this.rbCheckings.TabIndex = 1;
            this.rbCheckings.TabStop = true;
            this.rbCheckings.Text = "Chekings";
            this.rbCheckings.UseVisualStyleBackColor = true;
            // 
            // tbDeposit
            // 
            this.tbDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDeposit.ForeColor = System.Drawing.Color.Blue;
            this.tbDeposit.Location = new System.Drawing.Point(388, 52);
            this.tbDeposit.Name = "tbDeposit";
            this.tbDeposit.Size = new System.Drawing.Size(100, 26);
            this.tbDeposit.TabIndex = 2;
            // 
            // lbChekings
            // 
            this.lbChekings.AutoSize = true;
            this.lbChekings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbChekings.ForeColor = System.Drawing.Color.Blue;
            this.lbChekings.Location = new System.Drawing.Point(12, 55);
            this.lbChekings.Name = "lbChekings";
            this.lbChekings.Size = new System.Drawing.Size(88, 20);
            this.lbChekings.TabIndex = 4;
            this.lbChekings.Text = "Chekings:";
            // 
            // lbSavings
            // 
            this.lbSavings.AutoSize = true;
            this.lbSavings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSavings.ForeColor = System.Drawing.Color.Blue;
            this.lbSavings.Location = new System.Drawing.Point(12, 128);
            this.lbSavings.Name = "lbSavings";
            this.lbSavings.Size = new System.Drawing.Size(77, 20);
            this.lbSavings.TabIndex = 5;
            this.lbSavings.Text = "Savings:";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInfo.ForeColor = System.Drawing.Color.Blue;
            this.lbInfo.Location = new System.Drawing.Point(119, 195);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(87, 20);
            this.lbInfo.TabIndex = 6;
            this.lbInfo.Text = "Clint Info:";
            // 
            // btDeposit
            // 
            this.btDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btDeposit.ForeColor = System.Drawing.Color.Blue;
            this.btDeposit.Location = new System.Drawing.Point(502, 49);
            this.btDeposit.Name = "btDeposit";
            this.btDeposit.Size = new System.Drawing.Size(115, 29);
            this.btDeposit.TabIndex = 7;
            this.btDeposit.Text = "Deposit";
            this.btDeposit.UseVisualStyleBackColor = true;
            this.btDeposit.Click += new System.EventHandler(this.btDeposit_Click);
            // 
            // btWithdraw
            // 
            this.btWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btWithdraw.ForeColor = System.Drawing.Color.Blue;
            this.btWithdraw.Location = new System.Drawing.Point(502, 121);
            this.btWithdraw.Name = "btWithdraw";
            this.btWithdraw.Size = new System.Drawing.Size(115, 30);
            this.btWithdraw.TabIndex = 8;
            this.btWithdraw.Text = "Withdraw";
            this.btWithdraw.UseVisualStyleBackColor = true;
            this.btWithdraw.Click += new System.EventHandler(this.btWithdraw_Click);
            // 
            // tbChekings
            // 
            this.tbChekings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbChekings.ForeColor = System.Drawing.Color.Blue;
            this.tbChekings.Location = new System.Drawing.Point(105, 52);
            this.tbChekings.Name = "tbChekings";
            this.tbChekings.ReadOnly = true;
            this.tbChekings.Size = new System.Drawing.Size(100, 26);
            this.tbChekings.TabIndex = 9;
            this.tbChekings.Text = "0";
            // 
            // tbWithdraw
            // 
            this.tbWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWithdraw.ForeColor = System.Drawing.Color.Blue;
            this.tbWithdraw.Location = new System.Drawing.Point(388, 125);
            this.tbWithdraw.Name = "tbWithdraw";
            this.tbWithdraw.Size = new System.Drawing.Size(100, 26);
            this.tbWithdraw.TabIndex = 10;
            // 
            // rbSavings
            // 
            this.rbSavings.AutoSize = true;
            this.rbSavings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbSavings.ForeColor = System.Drawing.Color.Blue;
            this.rbSavings.Location = new System.Drawing.Point(239, 128);
            this.rbSavings.Name = "rbSavings";
            this.rbSavings.Size = new System.Drawing.Size(75, 20);
            this.rbSavings.TabIndex = 11;
            this.rbSavings.TabStop = true;
            this.rbSavings.Text = "Savings";
            this.rbSavings.UseVisualStyleBackColor = true;
            // 
            // tbSavings
            // 
            this.tbSavings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSavings.ForeColor = System.Drawing.Color.Blue;
            this.tbSavings.Location = new System.Drawing.Point(105, 125);
            this.tbSavings.Name = "tbSavings";
            this.tbSavings.ReadOnly = true;
            this.tbSavings.Size = new System.Drawing.Size(100, 26);
            this.tbSavings.TabIndex = 12;
            this.tbSavings.Text = "0";
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btExit.ForeColor = System.Drawing.Color.Blue;
            this.btExit.Location = new System.Drawing.Point(562, 319);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(55, 39);
            this.btExit.TabIndex = 13;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // dtpBirth
            // 
            this.dtpBirth.Enabled = false;
            this.dtpBirth.Location = new System.Drawing.Point(123, 299);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpBirth.TabIndex = 15;
            this.dtpBirth.Visible = false;
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(123, 242);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(346, 51);
            this.tbInfo.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(632, 370);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.tbSavings);
            this.Controls.Add(this.rbSavings);
            this.Controls.Add(this.tbWithdraw);
            this.Controls.Add(this.tbChekings);
            this.Controls.Add(this.btWithdraw);
            this.Controls.Add(this.btDeposit);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.lbSavings);
            this.Controls.Add(this.lbChekings);
            this.Controls.Add(this.tbDeposit);
            this.Controls.Add(this.rbCheckings);
            this.Controls.Add(this.btInfo);
            this.Name = "Form1";
            this.Text = "Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInfo;
        private System.Windows.Forms.RadioButton rbCheckings;
        private System.Windows.Forms.TextBox tbDeposit;
        private System.Windows.Forms.Label lbChekings;
        private System.Windows.Forms.Label lbSavings;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btDeposit;
        private System.Windows.Forms.Button btWithdraw;
        private System.Windows.Forms.TextBox tbChekings;
        private System.Windows.Forms.TextBox tbWithdraw;
        private System.Windows.Forms.RadioButton rbSavings;
        private System.Windows.Forms.TextBox tbSavings;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.TextBox tbInfo;
    }
}

