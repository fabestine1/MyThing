namespace _2._6
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
            this.SuspendLayout();
            // 
            // cbNames
            // 
            this.cbNames.FormattingEnabled = true;
            this.cbNames.Items.AddRange(new object[] {
            "asd",
            "asdd",
            "saddd",
            "sadasdasd",
            "asdasdasdasd",
            "asdasdasdasdasd",
            "asdasdasdasdasdsad",
            "sadasdasdasd",
            "asdasda",
            "sadasd",
            "asd",
            "as",
            "a",
            "asdasd",
            "asdasdasd"});
            this.cbNames.Location = new System.Drawing.Point(12, 12);
            this.cbNames.Name = "cbNames";
            this.cbNames.Size = new System.Drawing.Size(123, 21);
            this.cbNames.TabIndex = 0;
            this.cbNames.SelectedIndexChanged += new System.EventHandler(this.cbNames_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(147, 196);
            this.Controls.Add(this.cbNames);
            this.Name = "Form1";
            this.Text = "Combo Box";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNames;
    }
}

