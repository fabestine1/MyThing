namespace _3._4
{
    partial class movement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(movement));
            this.pbHead = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHead
            // 
            this.pbHead.Image = ((System.Drawing.Image)(resources.GetObject("pbHead.Image")));
            this.pbHead.Location = new System.Drawing.Point(197, 171);
            this.pbHead.Name = "pbHead";
            this.pbHead.Size = new System.Drawing.Size(136, 147);
            this.pbHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbHead.TabIndex = 0;
            this.pbHead.TabStop = false;
            // 
            // movement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 462);
            this.Controls.Add(this.pbHead);
            this.Name = "movement";
            this.Text = "Movement";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.movement_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHead;
    }
}

