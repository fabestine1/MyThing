namespace MediaBazar
{
    partial class ReportControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportControl));
            this.lblReportSubject = new System.Windows.Forms.Label();
            this.rtbReportMessage = new System.Windows.Forms.RichTextBox();
            this.btnMarkAsRead = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnMarkAsRead)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReportSubject
            // 
            this.lblReportSubject.AutoSize = true;
            this.lblReportSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblReportSubject.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportSubject.Location = new System.Drawing.Point(10, 20);
            this.lblReportSubject.Name = "lblReportSubject";
            this.lblReportSubject.Size = new System.Drawing.Size(123, 34);
            this.lblReportSubject.TabIndex = 18;
            this.lblReportSubject.Text = "Subject";
            // 
            // rtbReportMessage
            // 
            this.rtbReportMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rtbReportMessage.Enabled = false;
            this.rtbReportMessage.Location = new System.Drawing.Point(16, 57);
            this.rtbReportMessage.Name = "rtbReportMessage";
            this.rtbReportMessage.Size = new System.Drawing.Size(356, 158);
            this.rtbReportMessage.TabIndex = 19;
            this.rtbReportMessage.Text = "";
            // 
            // btnMarkAsRead
            // 
            this.btnMarkAsRead.Image = ((System.Drawing.Image)(resources.GetObject("btnMarkAsRead.Image")));
            this.btnMarkAsRead.Location = new System.Drawing.Point(346, 20);
            this.btnMarkAsRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMarkAsRead.Name = "btnMarkAsRead";
            this.btnMarkAsRead.Size = new System.Drawing.Size(26, 29);
            this.btnMarkAsRead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMarkAsRead.TabIndex = 22;
            this.btnMarkAsRead.TabStop = false;
            this.btnMarkAsRead.Click += new System.EventHandler(this.BtnMarkAsRead_Click);
            // 
            // ReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.btnMarkAsRead);
            this.Controls.Add(this.rtbReportMessage);
            this.Controls.Add(this.lblReportSubject);
            this.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(383, 230);
            ((System.ComponentModel.ISupportInitialize)(this.btnMarkAsRead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReportSubject;
        private System.Windows.Forms.RichTextBox rtbReportMessage;
        private System.Windows.Forms.PictureBox btnMarkAsRead;
    }
}
