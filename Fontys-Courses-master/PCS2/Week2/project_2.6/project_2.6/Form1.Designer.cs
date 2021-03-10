namespace project_2._6
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
            this.cbNames = new System.Windows.Forms.ComboBox();
            this.lbxNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbNames
            // 
            this.cbNames.FormattingEnabled = true;
            this.cbNames.Items.AddRange(new object[] {
            "John Green",
            "Peter Jonson",
            "Clancy Pace",
            "Elouise Roger",
            "Roland Brittany",
            "Sonia Madonna",
            "Tallulah Rosa",
            "Kolleen Aloysius",
            "Maddy Kathleen",
            "Pip Ike",
            "Pru Gyles",
            "Wynonna Errol",
            "Amethyst Cletis",
            "Jaden Isebella",
            "Faron Jaynie"});
            this.cbNames.Location = new System.Drawing.Point(122, 39);
            this.cbNames.Name = "cbNames";
            this.cbNames.Size = new System.Drawing.Size(121, 21);
            this.cbNames.TabIndex = 0;
            this.cbNames.SelectedIndexChanged += new System.EventHandler(this.cbNames_SelectedIndexChanged);
            // 
            // lbxNames
            // 
            this.lbxNames.FormattingEnabled = true;
            this.lbxNames.Location = new System.Drawing.Point(122, 117);
            this.lbxNames.Name = "lbxNames";
            this.lbxNames.Size = new System.Drawing.Size(120, 95);
            this.lbxNames.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbxNames);
            this.Controls.Add(this.cbNames);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNames;
        private System.Windows.Forms.ListBox lbxNames;
    }
}

