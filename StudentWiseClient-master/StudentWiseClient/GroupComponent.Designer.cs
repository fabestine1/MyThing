namespace StudentWiseClient
{
    partial class GroupComponent
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoEllipsis = true;
            this.lblName.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(560, 35);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoEllipsis = true;
            this.lblDescription.Font = new System.Drawing.Font("Oswald", 10F);
            this.lblDescription.Location = new System.Drawing.Point(20, 73);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(560, 65);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // lblRules
            // 
            this.lblRules.AutoEllipsis = true;
            this.lblRules.Font = new System.Drawing.Font("Oswald", 10F);
            this.lblRules.Location = new System.Drawing.Point(20, 138);
            this.lblRules.Margin = new System.Windows.Forms.Padding(0);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(560, 92);
            this.lblRules.TabIndex = 0;
            this.lblRules.Text = "Rules";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Font = new System.Drawing.Font("Oswald", 12F);
            this.lblDateTime.Location = new System.Drawing.Point(300, 20);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(280, 35);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "DateTime";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // GroupComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblRules);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GroupComponent";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(600, 250);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Label lblDateTime;
    }
}
