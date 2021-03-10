namespace AppAboutTextfiles
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
            this.btnDoTheJob = new System.Windows.Forms.Button();
            this.tbFilename = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnCopySomeLines = new System.Windows.Forms.Button();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDoTheJob
            // 
            this.btnDoTheJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoTheJob.Location = new System.Drawing.Point(36, 12);
            this.btnDoTheJob.Name = "btnDoTheJob";
            this.btnDoTheJob.Size = new System.Drawing.Size(185, 65);
            this.btnDoTheJob.TabIndex = 1;
            this.btnDoTheJob.Text = "do the job";
            this.btnDoTheJob.UseVisualStyleBackColor = true;
            this.btnDoTheJob.Click += new System.EventHandler(this.btnDoTheJob_Click);
            // 
            // tbFilename
            // 
            this.tbFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilename.Location = new System.Drawing.Point(36, 83);
            this.tbFilename.Name = "tbFilename";
            this.tbFilename.Size = new System.Drawing.Size(717, 29);
            this.tbFilename.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(36, 118);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(717, 364);
            this.listBox1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnCopySomeLines
            // 
            this.btnCopySomeLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopySomeLines.Location = new System.Drawing.Point(470, 12);
            this.btnCopySomeLines.Name = "btnCopySomeLines";
            this.btnCopySomeLines.Size = new System.Drawing.Size(149, 65);
            this.btnCopySomeLines.TabIndex = 5;
            this.btnCopySomeLines.Text = "copy some lines to another file";
            this.btnCopySomeLines.UseVisualStyleBackColor = true;
            this.btnCopySomeLines.Click += new System.EventHandler(this.btnCopySomeLines_Click);
            // 
            // tbNumber
            // 
            this.tbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumber.Location = new System.Drawing.Point(625, 32);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(128, 26);
            this.tbNumber.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 514);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.btnCopySomeLines);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbFilename);
            this.Controls.Add(this.btnDoTheJob);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoTheJob;
        private System.Windows.Forms.TextBox tbFilename;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnCopySomeLines;
        private System.Windows.Forms.TextBox tbNumber;
    }
}

