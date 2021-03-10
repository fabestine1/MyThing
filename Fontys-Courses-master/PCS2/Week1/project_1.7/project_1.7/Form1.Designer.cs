namespace project_1._7
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
            this.lblPurchased = new System.Windows.Forms.Label();
            this.lblPointsEarned = new System.Windows.Forms.Label();
            this.tbxPurchased = new System.Windows.Forms.TextBox();
            this.tbxPointsEarned = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPurchased
            // 
            this.lblPurchased.AutoSize = true;
            this.lblPurchased.Location = new System.Drawing.Point(9, 28);
            this.lblPurchased.Name = "lblPurchased";
            this.lblPurchased.Size = new System.Drawing.Size(121, 13);
            this.lblPurchased.TabIndex = 0;
            this.lblPurchased.Text = "Books Purchased (>=0):";
            this.lblPurchased.Click += new System.EventHandler(this.lblPurchased_Click);
            // 
            // lblPointsEarned
            // 
            this.lblPointsEarned.AutoSize = true;
            this.lblPointsEarned.Location = new System.Drawing.Point(169, 28);
            this.lblPointsEarned.Name = "lblPointsEarned";
            this.lblPointsEarned.Size = new System.Drawing.Size(76, 13);
            this.lblPointsEarned.TabIndex = 1;
            this.lblPointsEarned.Text = "Points Earned:";
            this.lblPointsEarned.Click += new System.EventHandler(this.lblPointsEarned_Click);
            // 
            // tbxPurchased
            // 
            this.tbxPurchased.Location = new System.Drawing.Point(12, 55);
            this.tbxPurchased.Name = "tbxPurchased";
            this.tbxPurchased.Size = new System.Drawing.Size(100, 20);
            this.tbxPurchased.TabIndex = 2;
            // 
            // tbxPointsEarned
            // 
            this.tbxPointsEarned.Location = new System.Drawing.Point(172, 55);
            this.tbxPointsEarned.Name = "tbxPointsEarned";
            this.tbxPointsEarned.ReadOnly = true;
            this.tbxPointsEarned.Size = new System.Drawing.Size(100, 20);
            this.tbxPointsEarned.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 98);
            this.Controls.Add(this.tbxPointsEarned);
            this.Controls.Add(this.tbxPurchased);
            this.Controls.Add(this.lblPointsEarned);
            this.Controls.Add(this.lblPurchased);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPurchased;
        private System.Windows.Forms.Label lblPointsEarned;
        private System.Windows.Forms.TextBox tbxPurchased;
        private System.Windows.Forms.TextBox tbxPointsEarned;
    }
}

