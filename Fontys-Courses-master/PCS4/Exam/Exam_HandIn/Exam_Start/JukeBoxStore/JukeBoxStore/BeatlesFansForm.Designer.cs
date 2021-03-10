namespace JukeBoxStore
{
    partial class BeatlesFanForm
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
            this.lbBeatlesFans = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbBeatlesFans
            // 
            this.lbBeatlesFans.FormattingEnabled = true;
            this.lbBeatlesFans.ItemHeight = 29;
            this.lbBeatlesFans.Location = new System.Drawing.Point(12, 12);
            this.lbBeatlesFans.Name = "lbBeatlesFans";
            this.lbBeatlesFans.Size = new System.Drawing.Size(746, 555);
            this.lbBeatlesFans.TabIndex = 0;
            // 
            // BeatlesFanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(770, 582);
            this.ControlBox = false;
            this.Controls.Add(this.lbBeatlesFans);
            this.Name = "BeatlesFanForm";
            this.Text = "The Beatles Fan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBeatlesFans;
    }
}