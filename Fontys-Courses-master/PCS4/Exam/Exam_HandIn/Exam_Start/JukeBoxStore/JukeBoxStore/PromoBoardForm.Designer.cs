namespace JukeBoxStore
{
    partial class PromoBoardForm
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
            this.lbPromo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbPromo
            // 
            this.lbPromo.FormattingEnabled = true;
            this.lbPromo.ItemHeight = 29;
            this.lbPromo.Location = new System.Drawing.Point(12, 12);
            this.lbPromo.Name = "lbPromo";
            this.lbPromo.Size = new System.Drawing.Size(1026, 555);
            this.lbPromo.TabIndex = 0;
            // 
            // PromoBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 582);
            this.ControlBox = false;
            this.Controls.Add(this.lbPromo);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "PromoBoardForm";
            this.Text = "Promotion Board";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPromo;
    }
}