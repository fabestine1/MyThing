namespace FreakyGarage
{
    partial class FortuneFritzForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FortuneFritzForm));
            this.lbFortuneFritz = new System.Windows.Forms.ListBox();
            this.pbFerrari = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFerrari)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFortuneFritz
            // 
            this.lbFortuneFritz.FormattingEnabled = true;
            this.lbFortuneFritz.Location = new System.Drawing.Point(32, 113);
            this.lbFortuneFritz.Name = "lbFortuneFritz";
            this.lbFortuneFritz.Size = new System.Drawing.Size(654, 238);
            this.lbFortuneFritz.TabIndex = 0;
            // 
            // pbFerrari
            // 
            this.pbFerrari.Image = ((System.Drawing.Image)(resources.GetObject("pbFerrari.Image")));
            this.pbFerrari.Location = new System.Drawing.Point(292, 12);
            this.pbFerrari.Name = "pbFerrari";
            this.pbFerrari.Size = new System.Drawing.Size(146, 86);
            this.pbFerrari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFerrari.TabIndex = 2;
            this.pbFerrari.TabStop = false;
            // 
            // FortuneFritzForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 382);
            this.Controls.Add(this.pbFerrari);
            this.Controls.Add(this.lbFortuneFritz);
            this.Name = "FortuneFritzForm";
            this.Text = "Fortune Fritz";
            ((System.ComponentModel.ISupportInitialize)(this.pbFerrari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbFortuneFritz;
        private System.Windows.Forms.PictureBox pbFerrari;
    }
}