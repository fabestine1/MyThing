namespace _6._1
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
            this.rbtnFristClass = new System.Windows.Forms.RadioButton();
            this.rbtnSecondClass = new System.Windows.Forms.RadioButton();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lsbSecondClass = new System.Windows.Forms.ListBox();
            this.lsbFirstClass = new System.Windows.Forms.ListBox();
            this.lbSecondClass = new System.Windows.Forms.Label();
            this.lbFirstClass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtnFristClass
            // 
            this.rbtnFristClass.AutoSize = true;
            this.rbtnFristClass.Location = new System.Drawing.Point(14, 14);
            this.rbtnFristClass.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rbtnFristClass.Name = "rbtnFristClass";
            this.rbtnFristClass.Size = new System.Drawing.Size(112, 24);
            this.rbtnFristClass.TabIndex = 0;
            this.rbtnFristClass.TabStop = true;
            this.rbtnFristClass.Text = "First Class";
            this.rbtnFristClass.UseVisualStyleBackColor = true;
            // 
            // rbtnSecondClass
            // 
            this.rbtnSecondClass.AutoSize = true;
            this.rbtnSecondClass.Location = new System.Drawing.Point(14, 48);
            this.rbtnSecondClass.Margin = new System.Windows.Forms.Padding(5);
            this.rbtnSecondClass.Name = "rbtnSecondClass";
            this.rbtnSecondClass.Size = new System.Drawing.Size(137, 24);
            this.rbtnSecondClass.TabIndex = 1;
            this.rbtnSecondClass.TabStop = true;
            this.rbtnSecondClass.Text = "Second Class";
            this.rbtnSecondClass.UseVisualStyleBackColor = true;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(12, 99);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(137, 40);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "Assign Seat";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lsbSecondClass
            // 
            this.lsbSecondClass.ForeColor = System.Drawing.Color.HotPink;
            this.lsbSecondClass.FormattingEnabled = true;
            this.lsbSecondClass.ItemHeight = 20;
            this.lsbSecondClass.Location = new System.Drawing.Point(183, 34);
            this.lsbSecondClass.Name = "lsbSecondClass";
            this.lsbSecondClass.Size = new System.Drawing.Size(124, 104);
            this.lsbSecondClass.TabIndex = 3;
            // 
            // lsbFirstClass
            // 
            this.lsbFirstClass.ForeColor = System.Drawing.Color.HotPink;
            this.lsbFirstClass.FormattingEnabled = true;
            this.lsbFirstClass.ItemHeight = 20;
            this.lsbFirstClass.Location = new System.Drawing.Point(340, 35);
            this.lsbFirstClass.Name = "lsbFirstClass";
            this.lsbFirstClass.Size = new System.Drawing.Size(125, 104);
            this.lsbFirstClass.TabIndex = 4;
            // 
            // lbSecondClass
            // 
            this.lbSecondClass.AutoSize = true;
            this.lbSecondClass.Location = new System.Drawing.Point(179, 9);
            this.lbSecondClass.Name = "lbSecondClass";
            this.lbSecondClass.Size = new System.Drawing.Size(119, 20);
            this.lbSecondClass.TabIndex = 5;
            this.lbSecondClass.Text = "Second Class";
            // 
            // lbFirstClass
            // 
            this.lbFirstClass.AutoSize = true;
            this.lbFirstClass.Location = new System.Drawing.Point(336, 9);
            this.lbFirstClass.Name = "lbFirstClass";
            this.lbFirstClass.Size = new System.Drawing.Size(89, 20);
            this.lbFirstClass.TabIndex = 6;
            this.lbFirstClass.Text = "FirstClass";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(499, 161);
            this.Controls.Add(this.lbFirstClass);
            this.Controls.Add(this.lbSecondClass);
            this.Controls.Add(this.lsbFirstClass);
            this.Controls.Add(this.lsbSecondClass);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.rbtnSecondClass);
            this.Controls.Add(this.rbtnFristClass);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.HotPink;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Seats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnFristClass;
        private System.Windows.Forms.RadioButton rbtnSecondClass;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.ListBox lsbSecondClass;
        private System.Windows.Forms.ListBox lsbFirstClass;
        private System.Windows.Forms.Label lbSecondClass;
        private System.Windows.Forms.Label lbFirstClass;
    }
}

