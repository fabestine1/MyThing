namespace _4._6
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
            this.btnThrid = new System.Windows.Forms.Button();
            this.lbFirstArr = new System.Windows.Forms.Label();
            this.lbSecondArr = new System.Windows.Forms.Label();
            this.lbNumbersArr1 = new System.Windows.Forms.Label();
            this.lbNumbersArr2 = new System.Windows.Forms.Label();
            this.lbNumbersArr3 = new System.Windows.Forms.Label();
            this.lbThirdArray = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThrid
            // 
            this.btnThrid.Location = new System.Drawing.Point(169, 38);
            this.btnThrid.Name = "btnThrid";
            this.btnThrid.Size = new System.Drawing.Size(118, 59);
            this.btnThrid.TabIndex = 0;
            this.btnThrid.Text = "Make Thrid Array";
            this.btnThrid.UseVisualStyleBackColor = true;
            this.btnThrid.Click += new System.EventHandler(this.btnThrid_Click);
            // 
            // lbFirstArr
            // 
            this.lbFirstArr.AutoSize = true;
            this.lbFirstArr.Location = new System.Drawing.Point(36, 38);
            this.lbFirstArr.Name = "lbFirstArr";
            this.lbFirstArr.Size = new System.Drawing.Size(97, 20);
            this.lbFirstArr.TabIndex = 1;
            this.lbFirstArr.Text = "First Array:";
            // 
            // lbSecondArr
            // 
            this.lbSecondArr.AutoSize = true;
            this.lbSecondArr.Location = new System.Drawing.Point(319, 38);
            this.lbSecondArr.Name = "lbSecondArr";
            this.lbSecondArr.Size = new System.Drawing.Size(122, 20);
            this.lbSecondArr.TabIndex = 2;
            this.lbSecondArr.Text = "Second Array:";
            // 
            // lbNumbersArr1
            // 
            this.lbNumbersArr1.AutoSize = true;
            this.lbNumbersArr1.Location = new System.Drawing.Point(36, 77);
            this.lbNumbersArr1.Name = "lbNumbersArr1";
            this.lbNumbersArr1.Size = new System.Drawing.Size(0, 20);
            this.lbNumbersArr1.TabIndex = 3;
            // 
            // lbNumbersArr2
            // 
            this.lbNumbersArr2.AutoSize = true;
            this.lbNumbersArr2.Location = new System.Drawing.Point(319, 77);
            this.lbNumbersArr2.Name = "lbNumbersArr2";
            this.lbNumbersArr2.Size = new System.Drawing.Size(0, 20);
            this.lbNumbersArr2.TabIndex = 4;
            // 
            // lbNumbersArr3
            // 
            this.lbNumbersArr3.AutoSize = true;
            this.lbNumbersArr3.Location = new System.Drawing.Point(165, 233);
            this.lbNumbersArr3.Name = "lbNumbersArr3";
            this.lbNumbersArr3.Size = new System.Drawing.Size(0, 20);
            this.lbNumbersArr3.TabIndex = 5;
            // 
            // lbThirdArray
            // 
            this.lbThirdArray.AutoSize = true;
            this.lbThirdArray.Location = new System.Drawing.Point(165, 164);
            this.lbThirdArray.Name = "lbThirdArray";
            this.lbThirdArray.Size = new System.Drawing.Size(101, 20);
            this.lbThirdArray.TabIndex = 6;
            this.lbThirdArray.Text = "Third Array:";
            this.lbThirdArray.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(491, 314);
            this.Controls.Add(this.lbThirdArray);
            this.Controls.Add(this.lbNumbersArr3);
            this.Controls.Add(this.lbNumbersArr2);
            this.Controls.Add(this.lbNumbersArr1);
            this.Controls.Add(this.lbSecondArr);
            this.Controls.Add(this.lbFirstArr);
            this.Controls.Add(this.btnThrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.DeepPink;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThrid;
        private System.Windows.Forms.Label lbFirstArr;
        private System.Windows.Forms.Label lbSecondArr;
        private System.Windows.Forms.Label lbNumbersArr1;
        private System.Windows.Forms.Label lbNumbersArr2;
        private System.Windows.Forms.Label lbNumbersArr3;
        private System.Windows.Forms.Label lbThirdArray;
    }
}

