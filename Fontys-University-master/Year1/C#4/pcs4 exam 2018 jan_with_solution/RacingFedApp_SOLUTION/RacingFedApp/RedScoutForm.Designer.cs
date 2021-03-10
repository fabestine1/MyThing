namespace RacingFedApp
{
    partial class RedScoutForm
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
            this.lbRedScout = new System.Windows.Forms.ListBox();
            this.lblInterestedRacers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbRedScout
            // 
            this.lbRedScout.FormattingEnabled = true;
            this.lbRedScout.Location = new System.Drawing.Point(15, 45);
            this.lbRedScout.Name = "lbRedScout";
            this.lbRedScout.Size = new System.Drawing.Size(357, 147);
            this.lbRedScout.TabIndex = 0;
            // 
            // lblInterestedRacers
            // 
            this.lblInterestedRacers.AutoSize = true;
            this.lblInterestedRacers.Location = new System.Drawing.Point(12, 29);
            this.lblInterestedRacers.Name = "lblInterestedRacers";
            this.lblInterestedRacers.Size = new System.Drawing.Size(91, 13);
            this.lblInterestedRacers.TabIndex = 1;
            this.lblInterestedRacers.Text = "Interested Racers";
            // 
            // RedScoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.lblInterestedRacers);
            this.Controls.Add(this.lbRedScout);
            this.Name = "RedScoutForm";
            this.Text = "Red Scout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbRedScout;
        private System.Windows.Forms.Label lblInterestedRacers;
    }
}