namespace project_1._6
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
            this.lblGallons = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblHighway = new System.Windows.Forms.Label();
            this.tbxHighway = new System.Windows.Forms.TextBox();
            this.tbxTown = new System.Windows.Forms.TextBox();
            this.gallons = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.gallons)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGallons
            // 
            this.lblGallons.AutoSize = true;
            this.lblGallons.Location = new System.Drawing.Point(12, 75);
            this.lblGallons.Name = "lblGallons";
            this.lblGallons.Size = new System.Drawing.Size(124, 13);
            this.lblGallons.TabIndex = 0;
            this.lblGallons.Text = "How many gallons of oil?";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(12, 154);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(157, 13);
            this.lblTown.TabIndex = 2;
            this.lblTown.Text = "Miles the car can travel in town:";
            // 
            // lblHighway
            // 
            this.lblHighway.AutoSize = true;
            this.lblHighway.Location = new System.Drawing.Point(12, 176);
            this.lblHighway.Name = "lblHighway";
            this.lblHighway.Size = new System.Drawing.Size(195, 13);
            this.lblHighway.TabIndex = 4;
            this.lblHighway.Text = "Miles the car can travel on the highway:";
            // 
            // tbxHighway
            // 
            this.tbxHighway.Enabled = false;
            this.tbxHighway.Location = new System.Drawing.Point(225, 173);
            this.tbxHighway.Name = "tbxHighway";
            this.tbxHighway.ReadOnly = true;
            this.tbxHighway.Size = new System.Drawing.Size(37, 20);
            this.tbxHighway.TabIndex = 5;
            // 
            // tbxTown
            // 
            this.tbxTown.Enabled = false;
            this.tbxTown.Location = new System.Drawing.Point(225, 151);
            this.tbxTown.Name = "tbxTown";
            this.tbxTown.ReadOnly = true;
            this.tbxTown.Size = new System.Drawing.Size(37, 20);
            this.tbxTown.TabIndex = 6;
            this.tbxTown.TextChanged += new System.EventHandler(this.tbxTown_TextChanged);
            // 
            // gallons
            // 
            this.gallons.DecimalPlaces = 2;
            this.gallons.Location = new System.Drawing.Point(142, 73);
            this.gallons.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.gallons.Name = "gallons";
            this.gallons.Size = new System.Drawing.Size(120, 20);
            this.gallons.TabIndex = 7;
            this.gallons.ValueChanged += new System.EventHandler(this.gallons_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gallons);
            this.Controls.Add(this.tbxTown);
            this.Controls.Add(this.tbxHighway);
            this.Controls.Add(this.lblHighway);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.lblGallons);
            this.Name = "Form1";
            this.Text = "Miles Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.gallons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGallons;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblHighway;
        private System.Windows.Forms.TextBox tbxHighway;
        private System.Windows.Forms.TextBox tbxTown;
        private System.Windows.Forms.NumericUpDown gallons;
    }
}

