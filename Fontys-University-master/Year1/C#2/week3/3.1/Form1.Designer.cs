namespace _3._1
{
    partial class Color
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
            this.btChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btChange
            // 
            this.btChange.BackColor = System.Drawing.Color.DeepPink;
            this.btChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btChange.ForeColor = System.Drawing.Color.Lime;
            this.btChange.Location = new System.Drawing.Point(290, 241);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(69, 28);
            this.btChange.TabIndex = 0;
            this.btChange.Text = "Change";
            this.btChange.UseVisualStyleBackColor = false;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // Color
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 281);
            this.Controls.Add(this.btChange);
            this.Name = "Color";
            this.Text = "Color";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btChange;
    }
}

