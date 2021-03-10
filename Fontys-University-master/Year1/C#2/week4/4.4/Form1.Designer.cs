namespace _4._4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.tbD = new System.Windows.Forms.TextBox();
            this.tbE = new System.Windows.Forms.TextBox();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "D";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "E";
            // 
            // tbA
            // 
            this.tbA.ForeColor = System.Drawing.Color.Lime;
            this.tbA.Location = new System.Drawing.Point(238, 51);
            this.tbA.Name = "tbA";
            this.tbA.ReadOnly = true;
            this.tbA.Size = new System.Drawing.Size(100, 22);
            this.tbA.TabIndex = 5;
            this.tbA.Text = "0";
            // 
            // tbB
            // 
            this.tbB.ForeColor = System.Drawing.Color.Lime;
            this.tbB.Location = new System.Drawing.Point(238, 79);
            this.tbB.Name = "tbB";
            this.tbB.ReadOnly = true;
            this.tbB.Size = new System.Drawing.Size(100, 22);
            this.tbB.TabIndex = 6;
            this.tbB.Text = "0";
            // 
            // tbC
            // 
            this.tbC.ForeColor = System.Drawing.Color.Lime;
            this.tbC.Location = new System.Drawing.Point(238, 108);
            this.tbC.Name = "tbC";
            this.tbC.ReadOnly = true;
            this.tbC.Size = new System.Drawing.Size(100, 22);
            this.tbC.TabIndex = 7;
            this.tbC.Text = "0";
            // 
            // tbD
            // 
            this.tbD.ForeColor = System.Drawing.Color.Lime;
            this.tbD.Location = new System.Drawing.Point(238, 136);
            this.tbD.Name = "tbD";
            this.tbD.ReadOnly = true;
            this.tbD.Size = new System.Drawing.Size(100, 22);
            this.tbD.TabIndex = 8;
            this.tbD.Text = "0";
            // 
            // tbE
            // 
            this.tbE.ForeColor = System.Drawing.Color.Lime;
            this.tbE.Location = new System.Drawing.Point(238, 164);
            this.tbE.Name = "tbE";
            this.tbE.ReadOnly = true;
            this.tbE.Size = new System.Drawing.Size(100, 22);
            this.tbE.TabIndex = 9;
            this.tbE.Text = "0";
            // 
            // tbAverage
            // 
            this.tbAverage.ForeColor = System.Drawing.Color.Lime;
            this.tbAverage.Location = new System.Drawing.Point(31, 76);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.Size = new System.Drawing.Size(100, 22);
            this.tbAverage.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Give Average";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(369, 228);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAverage);
            this.Controls.Add(this.tbE);
            this.Controls.Add(this.tbD);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Grades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.TextBox tbE;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

