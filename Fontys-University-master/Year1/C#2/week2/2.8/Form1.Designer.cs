namespace _2._8
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
            this.tbString = new System.Windows.Forms.TextBox();
            this.lbString = new System.Windows.Forms.ListBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbString
            // 
            this.tbString.Location = new System.Drawing.Point(12, 12);
            this.tbString.Name = "tbString";
            this.tbString.Size = new System.Drawing.Size(257, 20);
            this.tbString.TabIndex = 0;
            // 
            // lbString
            // 
            this.lbString.FormattingEnabled = true;
            this.lbString.Location = new System.Drawing.Point(12, 52);
            this.lbString.Name = "lbString";
            this.lbString.Size = new System.Drawing.Size(418, 108);
            this.lbString.Sorted = true;
            this.lbString.TabIndex = 1;
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btAdd.Location = new System.Drawing.Point(288, 3);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(128, 34);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Add To ListBox";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 189);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbString);
            this.Controls.Add(this.tbString);
            this.Name = "Form1";
            this.Text = "Text to List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbString;
        private System.Windows.Forms.ListBox lbString;
        private System.Windows.Forms.Button btAdd;
    }
}

