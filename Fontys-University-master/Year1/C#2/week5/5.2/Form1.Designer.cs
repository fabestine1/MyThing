namespace _5._2
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
            this.btnAddName = new System.Windows.Forms.Button();
            this.tbAddName = new System.Windows.Forms.TextBox();
            this.lbNames = new System.Windows.Forms.ListBox();
            this.btnFindName = new System.Windows.Forms.Button();
            this.tbFindName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(23, 75);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(100, 23);
            this.btnAddName.TabIndex = 0;
            this.btnAddName.Text = "Add Name";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbAddName
            // 
            this.tbAddName.Location = new System.Drawing.Point(23, 34);
            this.tbAddName.Name = "tbAddName";
            this.tbAddName.Size = new System.Drawing.Size(100, 22);
            this.tbAddName.TabIndex = 1;
            // 
            // lbNames
            // 
            this.lbNames.BackColor = System.Drawing.Color.Tomato;
            this.lbNames.ForeColor = System.Drawing.Color.Lime;
            this.lbNames.FormattingEnabled = true;
            this.lbNames.ItemHeight = 16;
            this.lbNames.Location = new System.Drawing.Point(262, 34);
            this.lbNames.Name = "lbNames";
            this.lbNames.Size = new System.Drawing.Size(113, 132);
            this.lbNames.TabIndex = 2;
            // 
            // btnFindName
            // 
            this.btnFindName.Location = new System.Drawing.Point(145, 75);
            this.btnFindName.Name = "btnFindName";
            this.btnFindName.Size = new System.Drawing.Size(100, 23);
            this.btnFindName.TabIndex = 3;
            this.btnFindName.Text = "Find Name";
            this.btnFindName.UseVisualStyleBackColor = true;
            this.btnFindName.Click += new System.EventHandler(this.btnFindName_Click);
            // 
            // tbFindName
            // 
            this.tbFindName.Location = new System.Drawing.Point(145, 34);
            this.tbFindName.Name = "tbFindName";
            this.tbFindName.Size = new System.Drawing.Size(100, 22);
            this.tbFindName.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(93, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 62);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Selected Name";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(402, 194);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbFindName);
            this.Controls.Add(this.btnFindName);
            this.Controls.Add(this.lbNames);
            this.Controls.Add(this.tbAddName);
            this.Controls.Add(this.btnAddName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Class Line";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.TextBox tbAddName;
        private System.Windows.Forms.ListBox lbNames;
        private System.Windows.Forms.Button btnFindName;
        private System.Windows.Forms.TextBox tbFindName;
        private System.Windows.Forms.Button btnDelete;
    }
}

