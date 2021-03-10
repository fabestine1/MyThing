namespace project_4._5
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblQuestionCaption = new System.Windows.Forms.Label();
            this.tbxGuessNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(93, 47);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblQuestionCaption
            // 
            this.lblQuestionCaption.AllowDrop = true;
            this.lblQuestionCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestionCaption.ForeColor = System.Drawing.Color.Black;
            this.lblQuestionCaption.Location = new System.Drawing.Point(12, 100);
            this.lblQuestionCaption.Name = "lblQuestionCaption";
            this.lblQuestionCaption.Size = new System.Drawing.Size(260, 89);
            this.lblQuestionCaption.TabIndex = 1;
            // 
            // tbxGuessNumber
            // 
            this.tbxGuessNumber.Location = new System.Drawing.Point(93, 205);
            this.tbxGuessNumber.Name = "tbxGuessNumber";
            this.tbxGuessNumber.Size = new System.Drawing.Size(100, 20);
            this.tbxGuessNumber.TabIndex = 2;
            this.tbxGuessNumber.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbxGuessNumber);
            this.Controls.Add(this.lblQuestionCaption);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblQuestionCaption;
        private System.Windows.Forms.TextBox tbxGuessNumber;
    }
}

