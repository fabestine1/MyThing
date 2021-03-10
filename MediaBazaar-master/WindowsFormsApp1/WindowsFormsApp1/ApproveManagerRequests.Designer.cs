namespace MediaBazar
{
    partial class ApproveManagerRequests
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
            this.lblRequest = new System.Windows.Forms.Label();
            this.flpRequests = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.BackColor = System.Drawing.Color.White;
            this.lblRequest.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequest.Location = new System.Drawing.Point(25, 25);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(531, 34);
            this.lblRequest.TabIndex = 12;
            this.lblRequest.Text = "Request for Hiring/Firing employees";
            // 
            // flpRequests
            // 
            this.flpRequests.AutoScroll = true;
            this.flpRequests.Location = new System.Drawing.Point(12, 106);
            this.flpRequests.Name = "flpRequests";
            this.flpRequests.Size = new System.Drawing.Size(776, 320);
            this.flpRequests.TabIndex = 11;
            // 
            // ApproveManagerRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRequest);
            this.Controls.Add(this.flpRequests);
            this.Name = "ApproveManagerRequests";
            this.Text = "ApproveManagerRequests";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.FlowLayoutPanel flpRequests;
    }
}