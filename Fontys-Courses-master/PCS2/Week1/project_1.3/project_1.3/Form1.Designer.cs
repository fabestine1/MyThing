namespace project_1._3
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
            this.components = new System.ComponentModel.Container();
            this.tbAmodB = new System.Windows.Forms.TextBox();
            this.tbAdivB = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.lbA = new System.Windows.Forms.Label();
            this.lbIntDiv = new System.Windows.Forms.Label();
            this.lbRemainder = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // tbAmodB
            // 
            this.tbAmodB.Location = new System.Drawing.Point(211, 141);
            this.tbAmodB.Name = "tbAmodB";
            this.tbAmodB.Size = new System.Drawing.Size(100, 20);
            this.tbAmodB.TabIndex = 0;
            this.tbAmodB.TextChanged += new System.EventHandler(this.tbAmodB_TextChanged);
            // 
            // tbAdivB
            // 
            this.tbAdivB.Location = new System.Drawing.Point(55, 141);
            this.tbAdivB.Name = "tbAdivB";
            this.tbAdivB.Size = new System.Drawing.Size(100, 20);
            this.tbAdivB.TabIndex = 1;
            this.tbAdivB.TextChanged += new System.EventHandler(this.tbAdivB_TextChanged);
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(55, 82);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 20);
            this.tbA.TabIndex = 2;
            this.toolTip1.SetToolTip(this.tbA, "Whole number");
            this.tbA.TextChanged += new System.EventHandler(this.tbA_TextChanged);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(211, 82);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 20);
            this.tbB.TabIndex = 3;
            this.tbB.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbA.Location = new System.Drawing.Point(20, 85);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(19, 13);
            this.lbA.TabIndex = 4;
            this.lbA.Text = "A:";
            this.lbA.MouseHover += new System.EventHandler(this.lbA_MouseHover);
            // 
            // lbIntDiv
            // 
            this.lbIntDiv.AutoSize = true;
            this.lbIntDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbIntDiv.Location = new System.Drawing.Point(14, 144);
            this.lbIntDiv.Name = "lbIntDiv";
            this.lbIntDiv.Size = new System.Drawing.Size(41, 13);
            this.lbIntDiv.TabIndex = 5;
            this.lbIntDiv.Text = "A / B:";
            this.lbIntDiv.Click += new System.EventHandler(this.lbIntDiv_Click);
            // 
            // lbRemainder
            // 
            this.lbRemainder.AutoSize = true;
            this.lbRemainder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRemainder.Location = new System.Drawing.Point(161, 144);
            this.lbRemainder.Name = "lbRemainder";
            this.lbRemainder.Size = new System.Drawing.Size(44, 13);
            this.lbRemainder.TabIndex = 6;
            this.lbRemainder.Text = "A % B:";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbB.Location = new System.Drawing.Point(172, 85);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(19, 13);
            this.lbB.TabIndex = 7;
            this.lbB.Text = "B:";
            this.toolTip1.SetToolTip(this.lbB, "A whole number not 0");
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(103, 197);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 8;
            this.btnResult.Text = "result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.BackColor = System.Drawing.Color.FloralWhite;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 261);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbRemainder);
            this.Controls.Add(this.lbIntDiv);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.tbAdivB);
            this.Controls.Add(this.tbAmodB);
            this.Name = "Form1";
            this.Text = "assignment dividing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAmodB;
        private System.Windows.Forms.TextBox tbAdivB;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbIntDiv;
        private System.Windows.Forms.Label lbRemainder;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

