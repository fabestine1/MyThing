namespace _4._5
{
    partial class GuessTheNumber
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
            this.btnRestart = new System.Windows.Forms.Button();
            this.tbGuess = new System.Windows.Forms.TextBox();
            this.lbMsg = new System.Windows.Forms.Label();
            this.lbHelper = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(209, 130);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(87, 32);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // tbGuess
            // 
            this.tbGuess.Location = new System.Drawing.Point(16, 84);
            this.tbGuess.Name = "tbGuess";
            this.tbGuess.Size = new System.Drawing.Size(100, 26);
            this.tbGuess.TabIndex = 1;
            this.tbGuess.TextChanged += new System.EventHandler(this.tbGuess_TextChanged);
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Location = new System.Drawing.Point(12, 33);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(284, 20);
            this.lbMsg.TabIndex = 2;
            this.lbMsg.Text = "Guess the number from 1 to 1000:";
            // 
            // lbHelper
            // 
            this.lbHelper.AutoSize = true;
            this.lbHelper.Location = new System.Drawing.Point(149, 87);
            this.lbHelper.Name = "lbHelper";
            this.lbHelper.Size = new System.Drawing.Size(0, 20);
            this.lbHelper.TabIndex = 3;
            // 
            // GuessTheNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(368, 193);
            this.Controls.Add(this.lbHelper);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.tbGuess);
            this.Controls.Add(this.btnRestart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.DeepPink;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "GuessTheNumber";
            this.Text = "Guess The Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.TextBox tbGuess;
        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.Label lbHelper;
    }
}

