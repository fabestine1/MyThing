namespace RacingFedApp
{
    partial class BlueScoutForm
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
            this.lbBlueScout = new System.Windows.Forms.ListBox();
            this.lblLastAddedRacer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBlueScout
            // 
            this.lbBlueScout.FormattingEnabled = true;
            this.lbBlueScout.Location = new System.Drawing.Point(12, 142);
            this.lbBlueScout.Name = "lbBlueScout";
            this.lbBlueScout.Size = new System.Drawing.Size(360, 199);
            this.lbBlueScout.TabIndex = 0;
            // 
            // lblLastAddedRacer
            // 
            this.lblLastAddedRacer.AutoSize = true;
            this.lblLastAddedRacer.Location = new System.Drawing.Point(12, 9);
            this.lblLastAddedRacer.Name = "lblLastAddedRacer";
            this.lblLastAddedRacer.Size = new System.Drawing.Size(87, 13);
            this.lblLastAddedRacer.TabIndex = 1;
            this.lblLastAddedRacer.Text = "Last added racer";
            // 
            // BlueScoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.lblLastAddedRacer);
            this.Controls.Add(this.lbBlueScout);
            this.Name = "BlueScoutForm";
            this.Text = "Blue Scout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBlueScout;
        private System.Windows.Forms.Label lblLastAddedRacer;
    }
}