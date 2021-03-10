namespace StudentWiseClient
{
    partial class MiniComplaintComponent
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoEllipsis = true;
            this.titleLbl.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.titleLbl.Location = new System.Drawing.Point(20, 45);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(360, 35);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Text = "Title of the complaint";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoEllipsis = true;
            this.statusLbl.Font = new System.Drawing.Font("Oswald", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.statusLbl.Location = new System.Drawing.Point(20, 20);
            this.statusLbl.Margin = new System.Windows.Forms.Padding(0);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(360, 24);
            this.statusLbl.TabIndex = 2;
            this.statusLbl.Text = "IN PROGRESS";
            // 
            // MiniComplaintComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.statusLbl);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MiniComplaintComponent";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(400, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label statusLbl;
    }
}
