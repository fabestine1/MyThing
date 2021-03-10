namespace project_2._1
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
            this.tbOperand1 = new System.Windows.Forms.TextBox();
            this.tbOperator = new System.Windows.Forms.TextBox();
            this.tbOperand2 = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbEquals = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbOperand1
            // 
            this.tbOperand1.Location = new System.Drawing.Point(110, 55);
            this.tbOperand1.MaxLength = 5;
            this.tbOperand1.Name = "tbOperand1";
            this.tbOperand1.Size = new System.Drawing.Size(100, 20);
            this.tbOperand1.TabIndex = 0;
            this.tbOperand1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOperand1_KeyPress);
            // 
            // tbOperator
            // 
            this.tbOperator.Location = new System.Drawing.Point(231, 55);
            this.tbOperator.MaxLength = 1;
            this.tbOperator.Name = "tbOperator";
            this.tbOperator.Size = new System.Drawing.Size(32, 20);
            this.tbOperator.TabIndex = 1;
            this.tbOperator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOperator_KeyPress);
            // 
            // tbOperand2
            // 
            this.tbOperand2.Location = new System.Drawing.Point(288, 55);
            this.tbOperand2.MaxLength = 5;
            this.tbOperand2.Name = "tbOperand2";
            this.tbOperand2.Size = new System.Drawing.Size(100, 20);
            this.tbOperand2.TabIndex = 2;
            this.tbOperand2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOperand2_KeyPress);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbResult.Location = new System.Drawing.Point(414, 58);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(49, 13);
            this.lbResult.TabIndex = 3;
            this.lbResult.Text = "??????";
            // 
            // lbEquals
            // 
            this.lbEquals.AutoSize = true;
            this.lbEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEquals.Location = new System.Drawing.Point(394, 58);
            this.lbEquals.Name = "lbEquals";
            this.lbEquals.Size = new System.Drawing.Size(14, 13);
            this.lbEquals.TabIndex = 4;
            this.lbEquals.Text = "=";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(276, 160);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 5;
            this.btnResult.Text = "result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 261);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lbEquals);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.tbOperand2);
            this.Controls.Add(this.tbOperator);
            this.Controls.Add(this.tbOperand1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOperand1;
        private System.Windows.Forms.TextBox tbOperator;
        private System.Windows.Forms.TextBox tbOperand2;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbEquals;
        private System.Windows.Forms.Button btnResult;
    }
}

