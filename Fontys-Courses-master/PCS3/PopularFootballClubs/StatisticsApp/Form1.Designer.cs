namespace StatisticsApp
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
            this.lblFirstClubVotesCaption = new System.Windows.Forms.Label();
            this.lblSecondClubVotesCaption = new System.Windows.Forms.Label();
            this.lblFirstClub = new System.Windows.Forms.Label();
            this.lblSecondClub = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbxFirstClub = new System.Windows.Forms.TextBox();
            this.tbxSecondClub = new System.Windows.Forms.TextBox();
            this.lblFirstClubVotes = new System.Windows.Forms.Label();
            this.lblSecondClubVotes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirstClubVotesCaption
            // 
            this.lblFirstClubVotesCaption.AutoSize = true;
            this.lblFirstClubVotesCaption.Location = new System.Drawing.Point(357, 41);
            this.lblFirstClubVotesCaption.Name = "lblFirstClubVotesCaption";
            this.lblFirstClubVotesCaption.Size = new System.Drawing.Size(143, 13);
            this.lblFirstClubVotesCaption.TabIndex = 0;
            this.lblFirstClubVotesCaption.Text = "number of votes for first club:";
            // 
            // lblSecondClubVotesCaption
            // 
            this.lblSecondClubVotesCaption.AutoSize = true;
            this.lblSecondClubVotesCaption.Location = new System.Drawing.Point(357, 76);
            this.lblSecondClubVotesCaption.Name = "lblSecondClubVotesCaption";
            this.lblSecondClubVotesCaption.Size = new System.Drawing.Size(162, 13);
            this.lblSecondClubVotesCaption.TabIndex = 1;
            this.lblSecondClubVotesCaption.Text = "number of votes for second club:";
            // 
            // lblFirstClub
            // 
            this.lblFirstClub.AutoSize = true;
            this.lblFirstClub.Location = new System.Drawing.Point(37, 41);
            this.lblFirstClub.Name = "lblFirstClub";
            this.lblFirstClub.Size = new System.Drawing.Size(46, 13);
            this.lblFirstClub.TabIndex = 2;
            this.lblFirstClub.Text = "first club";
            // 
            // lblSecondClub
            // 
            this.lblSecondClub.AutoSize = true;
            this.lblSecondClub.Location = new System.Drawing.Point(26, 76);
            this.lblSecondClub.Name = "lblSecondClub";
            this.lblSecondClub.Size = new System.Drawing.Size(65, 13);
            this.lblSecondClub.TabIndex = 3;
            this.lblSecondClub.Text = "second club";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(97, 118);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(403, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate votes";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbxFirstClub
            // 
            this.tbxFirstClub.Location = new System.Drawing.Point(97, 38);
            this.tbxFirstClub.Name = "tbxFirstClub";
            this.tbxFirstClub.Size = new System.Drawing.Size(171, 20);
            this.tbxFirstClub.TabIndex = 5;
            // 
            // tbxSecondClub
            // 
            this.tbxSecondClub.Location = new System.Drawing.Point(97, 73);
            this.tbxSecondClub.Name = "tbxSecondClub";
            this.tbxSecondClub.Size = new System.Drawing.Size(171, 20);
            this.tbxSecondClub.TabIndex = 6;
            // 
            // lblFirstClubVotes
            // 
            this.lblFirstClubVotes.AutoSize = true;
            this.lblFirstClubVotes.Location = new System.Drawing.Point(525, 41);
            this.lblFirstClubVotes.Name = "lblFirstClubVotes";
            this.lblFirstClubVotes.Size = new System.Drawing.Size(0, 13);
            this.lblFirstClubVotes.TabIndex = 7;
            // 
            // lblSecondClubVotes
            // 
            this.lblSecondClubVotes.AutoSize = true;
            this.lblSecondClubVotes.Location = new System.Drawing.Point(525, 76);
            this.lblSecondClubVotes.Name = "lblSecondClubVotes";
            this.lblSecondClubVotes.Size = new System.Drawing.Size(0, 13);
            this.lblSecondClubVotes.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(598, 148);
            this.Controls.Add(this.lblSecondClubVotes);
            this.Controls.Add(this.lblFirstClubVotes);
            this.Controls.Add(this.tbxSecondClub);
            this.Controls.Add(this.tbxFirstClub);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblSecondClub);
            this.Controls.Add(this.lblFirstClub);
            this.Controls.Add(this.lblSecondClubVotesCaption);
            this.Controls.Add(this.lblFirstClubVotesCaption);
            this.Name = "Form1";
            this.Text = "Statistical information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstClubVotesCaption;
        private System.Windows.Forms.Label lblSecondClubVotesCaption;
        private System.Windows.Forms.Label lblFirstClub;
        private System.Windows.Forms.Label lblSecondClub;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbxFirstClub;
        private System.Windows.Forms.TextBox tbxSecondClub;
        private System.Windows.Forms.Label lblFirstClubVotes;
        private System.Windows.Forms.Label lblSecondClubVotes;
    }
}

