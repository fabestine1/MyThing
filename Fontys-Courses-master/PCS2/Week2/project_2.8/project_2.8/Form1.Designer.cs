namespace project_2._8
{
    partial class lblText
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
            this.tbxAdd = new System.Windows.Forms.TextBox();
            this.lbxText = new System.Windows.Forms.ListBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxAdd
            // 
            this.tbxAdd.Location = new System.Drawing.Point(172, 45);
            this.tbxAdd.Name = "tbxAdd";
            this.tbxAdd.Size = new System.Drawing.Size(100, 20);
            this.tbxAdd.TabIndex = 0;
            this.tbxAdd.Leave += new System.EventHandler(this.tbxAdd_Leave);
            // 
            // lbxText
            // 
            this.lbxText.FormattingEnabled = true;
            this.lbxText.Location = new System.Drawing.Point(152, 109);
            this.lbxText.Name = "lbxText";
            this.lbxText.Size = new System.Drawing.Size(120, 95);
            this.lbxText.Sorted = true;
            this.lbxText.TabIndex = 1;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(21, 45);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(75, 13);
            this.lblAdd.TabIndex = 2;
            this.lblAdd.Text = "Add to textbox";
            // 
            // lblText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lbxText);
            this.Controls.Add(this.tbxAdd);
            this.Name = "lblText";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxAdd;
        private System.Windows.Forms.ListBox lbxText;
        private System.Windows.Forms.Label lblAdd;
    }
}

