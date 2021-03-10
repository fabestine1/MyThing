namespace StudentWiseClient
{
    partial class NoGroups
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Oswald", 36F);
            this.lblHeader.Location = new System.Drawing.Point(20, 20);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(460, 100);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Sorry!";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBody
            // 
            this.lblBody.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBody.Location = new System.Drawing.Point(20, 120);
            this.lblBody.Margin = new System.Windows.Forms.Padding(0);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(460, 60);
            this.lblBody.TabIndex = 0;
            this.lblBody.Text = "Currently, there are no groups.";
            this.lblBody.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NoGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblBody);
            this.Name = "NoGroups";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(500, 200);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblBody;
    }
}
