namespace _2._7
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
            this.lbNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbNames
            // 
            this.cbNames.FormattingEnabled = true;
            this.cbNames.Items.AddRange(new object[] {
            "456465",
            "asd",
            "asd",
            "asdsadasd",
            "asd"});
            this.cbNames.Location = new System.Drawing.Point(12, 12);
            this.cbNames.Name = "cbNames";
            this.cbNames.Size = new System.Drawing.Size(121, 21);
            this.cbNames.TabIndex = 0;
            this.cbNames.SelectedIndexChanged += new System.EventHandler(this.cbNames_SelectedIndexChanged);
            // 
            // lbNames
            // 
            this.lbNames.FormattingEnabled = true;
            this.lbNames.Location = new System.Drawing.Point(139, 12);
            this.lbNames.Name = "lbNames";
            this.lbNames.Size = new System.Drawing.Size(133, 173);
            this.lbNames.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 210);
            this.Controls.Add(this.lbNames);
            this.Controls.Add(this.cbNames);
            this.Name = "Form1";
            this.Text = "Combo to List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNames;
        private System.Windows.Forms.ListBox lbNames;
    }
}

