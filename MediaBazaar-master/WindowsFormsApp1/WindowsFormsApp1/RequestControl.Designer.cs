namespace MediaBazar
{
    partial class RequestControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestControl));
            this.lblRequestDescription = new System.Windows.Forms.Label();
            this.lblRequest = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnApprove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRequestDescription
            // 
            this.lblRequestDescription.AutoSize = true;
            this.lblRequestDescription.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestDescription.Location = new System.Drawing.Point(10, 79);
            this.lblRequestDescription.Name = "lblRequestDescription";
            this.lblRequestDescription.Size = new System.Drawing.Size(408, 29);
            this.lblRequestDescription.TabIndex = 18;
            this.lblRequestDescription.Text = "Some description of the request here";
            this.lblRequestDescription.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblRequest.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequest.Location = new System.Drawing.Point(8, 21);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(157, 46);
            this.lblRequest.TabIndex = 17;
            this.lblRequest.Text = "Request";
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.Silver;
            this.btnDetails.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.Location = new System.Drawing.Point(15, 126);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(82, 41);
            this.btnDetails.TabIndex = 16;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.BtnDetails_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Image = ((System.Drawing.Image)(resources.GetObject("btnApprove.Image")));
            this.btnApprove.Location = new System.Drawing.Point(564, 100);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(84, 81);
            this.btnApprove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnApprove.TabIndex = 20;
            this.btnApprove.TabStop = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(654, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 66);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete.TabIndex = 21;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // RequestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.lblRequestDescription);
            this.Controls.Add(this.lblRequest);
            this.Controls.Add(this.btnDetails);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RequestControl";
            this.Size = new System.Drawing.Size(727, 185);
            ((System.ComponentModel.ISupportInitialize)(this.btnApprove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRequestDescription;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.PictureBox btnApprove;
        private System.Windows.Forms.PictureBox btnDelete;
    }
}
