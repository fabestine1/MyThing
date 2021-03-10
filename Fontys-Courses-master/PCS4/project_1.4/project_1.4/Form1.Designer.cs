namespace project_1._4
{
    partial class Form1
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
            this.tbxHour = new System.Windows.Forms.TextBox();
            this.tbxMinute = new System.Windows.Forms.TextBox();
            this.btnAddHour = new System.Windows.Forms.Button();
            this.btnAddMinute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxHour
            // 
            this.tbxHour.Location = new System.Drawing.Point(52, 60);
            this.tbxHour.Name = "tbxHour";
            this.tbxHour.Size = new System.Drawing.Size(100, 20);
            this.tbxHour.TabIndex = 0;
            // 
            // tbxMinute
            // 
            this.tbxMinute.Location = new System.Drawing.Point(52, 122);
            this.tbxMinute.Name = "tbxMinute";
            this.tbxMinute.Size = new System.Drawing.Size(100, 20);
            this.tbxMinute.TabIndex = 1;
            // 
            // btnAddHour
            // 
            this.btnAddHour.Location = new System.Drawing.Point(158, 59);
            this.btnAddHour.Name = "btnAddHour";
            this.btnAddHour.Size = new System.Drawing.Size(75, 23);
            this.btnAddHour.TabIndex = 2;
            this.btnAddHour.Text = "Add hour";
            this.btnAddHour.UseVisualStyleBackColor = true;
            this.btnAddHour.Click += new System.EventHandler(this.btnAddHour_Click);
            // 
            // btnAddMinute
            // 
            this.btnAddMinute.Location = new System.Drawing.Point(158, 120);
            this.btnAddMinute.Name = "btnAddMinute";
            this.btnAddMinute.Size = new System.Drawing.Size(75, 23);
            this.btnAddMinute.TabIndex = 3;
            this.btnAddMinute.Text = "Add minute";
            this.btnAddMinute.UseVisualStyleBackColor = true;
            this.btnAddMinute.Click += new System.EventHandler(this.btnAddMinute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 212);
            this.Controls.Add(this.btnAddMinute);
            this.Controls.Add(this.btnAddHour);
            this.Controls.Add(this.tbxMinute);
            this.Controls.Add(this.tbxHour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxHour;
        private System.Windows.Forms.TextBox tbxMinute;
        private System.Windows.Forms.Button btnAddHour;
        private System.Windows.Forms.Button btnAddMinute;
    }
}

