namespace project_4._1
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
            this.lblNumberA = new System.Windows.Forms.Label();
            this.lblNumberB = new System.Windows.Forms.Label();
            this.tbxNumberA = new System.Windows.Forms.TextBox();
            this.tbxNumberB = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnMiltiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblNumberA
            // 
            this.lblNumberA.AutoSize = true;
            this.lblNumberA.Location = new System.Drawing.Point(42, 24);
            this.lblNumberA.Name = "lblNumberA";
            this.lblNumberA.Size = new System.Drawing.Size(51, 13);
            this.lblNumberA.TabIndex = 0;
            this.lblNumberA.Text = "number 1";
            // 
            // lblNumberB
            // 
            this.lblNumberB.AutoSize = true;
            this.lblNumberB.Location = new System.Drawing.Point(42, 69);
            this.lblNumberB.Name = "lblNumberB";
            this.lblNumberB.Size = new System.Drawing.Size(51, 13);
            this.lblNumberB.TabIndex = 1;
            this.lblNumberB.Text = "number 2";
            // 
            // tbxNumberA
            // 
            this.tbxNumberA.Location = new System.Drawing.Point(95, 21);
            this.tbxNumberA.Name = "tbxNumberA";
            this.tbxNumberA.Size = new System.Drawing.Size(100, 20);
            this.tbxNumberA.TabIndex = 2;
            // 
            // tbxNumberB
            // 
            this.tbxNumberB.Location = new System.Drawing.Point(95, 66);
            this.tbxNumberB.Name = "tbxNumberB";
            this.tbxNumberB.Size = new System.Drawing.Size(100, 20);
            this.tbxNumberB.TabIndex = 3;
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSum.Location = new System.Drawing.Point(73, 115);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(29, 23);
            this.btnSum.TabIndex = 4;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSubstract.Location = new System.Drawing.Point(120, 115);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(29, 23);
            this.btnSubstract.TabIndex = 5;
            this.btnSubstract.Text = "-";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // btnMiltiply
            // 
            this.btnMiltiply.Location = new System.Drawing.Point(165, 115);
            this.btnMiltiply.Name = "btnMiltiply";
            this.btnMiltiply.Size = new System.Drawing.Size(30, 23);
            this.btnMiltiply.TabIndex = 6;
            this.btnMiltiply.Text = "*";
            this.btnMiltiply.UseVisualStyleBackColor = true;
            this.btnMiltiply.Click += new System.EventHandler(this.btnMiltiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDivide.Location = new System.Drawing.Point(213, 115);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(30, 23);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(280, 24);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(206, 194);
            this.richTextBoxResult.TabIndex = 8;
            this.richTextBoxResult.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 248);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMiltiply);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.tbxNumberB);
            this.Controls.Add(this.tbxNumberA);
            this.Controls.Add(this.lblNumberB);
            this.Controls.Add(this.lblNumberA);
            this.Name = "Form1";
            this.Text = "Simple calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberA;
        private System.Windows.Forms.Label lblNumberB;
        private System.Windows.Forms.TextBox tbxNumberA;
        private System.Windows.Forms.TextBox tbxNumberB;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnMiltiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
    }
}

