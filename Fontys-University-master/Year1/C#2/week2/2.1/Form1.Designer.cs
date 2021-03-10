namespace _2._1
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
            this.firstNumber = new System.Windows.Forms.TextBox();
            this.sign = new System.Windows.Forms.TextBox();
            this.secondNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNumber
            // 
            this.firstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNumber.ForeColor = System.Drawing.Color.DeepPink;
            this.firstNumber.Location = new System.Drawing.Point(64, 78);
            this.firstNumber.MaxLength = 20;
            this.firstNumber.Name = "firstNumber";
            this.firstNumber.Size = new System.Drawing.Size(100, 26);
            this.firstNumber.TabIndex = 0;
            this.firstNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNumber_KeyPress);
            // 
            // sign
            // 
            this.sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sign.ForeColor = System.Drawing.Color.DeepPink;
            this.sign.Location = new System.Drawing.Point(187, 78);
            this.sign.MaxLength = 1;
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(27, 26);
            this.sign.TabIndex = 1;
            this.sign.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sign_KeyPress);
            // 
            // secondNumber
            // 
            this.secondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondNumber.ForeColor = System.Drawing.Color.DeepPink;
            this.secondNumber.Location = new System.Drawing.Point(233, 78);
            this.secondNumber.MaxLength = 20;
            this.secondNumber.Name = "secondNumber";
            this.secondNumber.Size = new System.Drawing.Size(100, 26);
            this.secondNumber.TabIndex = 2;
            this.secondNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secondNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(353, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.ForeColor = System.Drawing.Color.DeepPink;
            this.result.Location = new System.Drawing.Point(395, 81);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(61, 20);
            this.result.TabIndex = 4;
            this.result.Text = "             ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.DeepPink;
            this.button1.Location = new System.Drawing.Point(176, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(558, 238);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondNumber);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.firstNumber);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNumber;
        private System.Windows.Forms.TextBox sign;
        private System.Windows.Forms.TextBox secondNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button button1;
    }
}

