namespace project_3._5
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblBreadth = new System.Windows.Forms.Label();
            this.tbxLength = new System.Windows.Forms.TextBox();
            this.tbxBreadth = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(58, 64);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(43, 13);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length:";
            // 
            // lblBreadth
            // 
            this.lblBreadth.AutoSize = true;
            this.lblBreadth.Location = new System.Drawing.Point(58, 112);
            this.lblBreadth.Name = "lblBreadth";
            this.lblBreadth.Size = new System.Drawing.Size(47, 13);
            this.lblBreadth.TabIndex = 1;
            this.lblBreadth.Text = "Breadth:";
            // 
            // tbxLength
            // 
            this.tbxLength.Location = new System.Drawing.Point(121, 61);
            this.tbxLength.Name = "tbxLength";
            this.tbxLength.Size = new System.Drawing.Size(100, 20);
            this.tbxLength.TabIndex = 2;
            // 
            // tbxBreadth
            // 
            this.tbxBreadth.Location = new System.Drawing.Point(121, 109);
            this.tbxBreadth.Name = "tbxBreadth";
            this.tbxBreadth.Size = new System.Drawing.Size(100, 20);
            this.tbxBreadth.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(94, 174);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(91, 216);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbxBreadth);
            this.Controls.Add(this.tbxLength);
            this.Controls.Add(this.lblBreadth);
            this.Controls.Add(this.lblLength);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblBreadth;
        private System.Windows.Forms.TextBox tbxLength;
        private System.Windows.Forms.TextBox tbxBreadth;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
    }
}

