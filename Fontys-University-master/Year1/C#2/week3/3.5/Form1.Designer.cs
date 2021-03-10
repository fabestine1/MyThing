namespace _3._5
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
            this.tbLength = new System.Windows.Forms.TextBox();
            this.tbBreadth = new System.Windows.Forms.TextBox();
            this.tbDiagonal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbLenght = new System.Windows.Forms.Label();
            this.lbBreadth = new System.Windows.Forms.Label();
            this.lbDiagonal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLength
            // 
            this.tbLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLength.Location = new System.Drawing.Point(13, 61);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(100, 26);
            this.tbLength.TabIndex = 0;
            // 
            // tbBreadth
            // 
            this.tbBreadth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBreadth.Location = new System.Drawing.Point(148, 61);
            this.tbBreadth.Name = "tbBreadth";
            this.tbBreadth.Size = new System.Drawing.Size(100, 26);
            this.tbBreadth.TabIndex = 1;
            // 
            // tbDiagonal
            // 
            this.tbDiagonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDiagonal.Location = new System.Drawing.Point(286, 61);
            this.tbDiagonal.Name = "tbDiagonal";
            this.tbDiagonal.ReadOnly = true;
            this.tbDiagonal.Size = new System.Drawing.Size(100, 26);
            this.tbDiagonal.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(232, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Find Diagonal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbLenght
            // 
            this.lbLenght.AutoSize = true;
            this.lbLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLenght.Location = new System.Drawing.Point(12, 26);
            this.lbLenght.Name = "lbLenght";
            this.lbLenght.Size = new System.Drawing.Size(65, 20);
            this.lbLenght.TabIndex = 4;
            this.lbLenght.Text = "Length";
            // 
            // lbBreadth
            // 
            this.lbBreadth.AutoSize = true;
            this.lbBreadth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBreadth.Location = new System.Drawing.Point(144, 26);
            this.lbBreadth.Name = "lbBreadth";
            this.lbBreadth.Size = new System.Drawing.Size(73, 20);
            this.lbBreadth.TabIndex = 5;
            this.lbBreadth.Text = "Breadth";
            // 
            // lbDiagonal
            // 
            this.lbDiagonal.AutoSize = true;
            this.lbDiagonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDiagonal.Location = new System.Drawing.Point(282, 26);
            this.lbDiagonal.Name = "lbDiagonal";
            this.lbDiagonal.Size = new System.Drawing.Size(80, 20);
            this.lbDiagonal.TabIndex = 6;
            this.lbDiagonal.Text = "Diagonal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 184);
            this.Controls.Add(this.lbDiagonal);
            this.Controls.Add(this.lbBreadth);
            this.Controls.Add(this.lbLenght);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDiagonal);
            this.Controls.Add(this.tbBreadth);
            this.Controls.Add(this.tbLength);
            this.Name = "Form1";
            this.Text = "Rectangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.TextBox tbBreadth;
        private System.Windows.Forms.TextBox tbDiagonal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbLenght;
        private System.Windows.Forms.Label lbBreadth;
        private System.Windows.Forms.Label lbDiagonal;
    }
}

