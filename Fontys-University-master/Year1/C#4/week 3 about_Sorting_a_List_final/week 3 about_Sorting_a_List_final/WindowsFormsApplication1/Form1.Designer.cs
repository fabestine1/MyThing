namespace WindowsFormsApplication1
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
            this.btSort1 = new System.Windows.Forms.Button();
            this.btSort2 = new System.Windows.Forms.Button();
            this.btSort3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btSort1
            // 
            this.btSort1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSort1.Location = new System.Drawing.Point(6, 6);
            this.btSort1.Name = "btSort1";
            this.btSort1.Size = new System.Drawing.Size(309, 42);
            this.btSort1.TabIndex = 0;
            this.btSort1.Text = "default sort (by id)";
            this.btSort1.UseVisualStyleBackColor = true;
            this.btSort1.Click += new System.EventHandler(this.btSort1_Click);
            // 
            // btSort2
            // 
            this.btSort2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSort2.Location = new System.Drawing.Point(6, 54);
            this.btSort2.Name = "btSort2";
            this.btSort2.Size = new System.Drawing.Size(308, 37);
            this.btSort2.TabIndex = 1;
            this.btSort2.Text = "sort by using delegate (by name)";
            this.btSort2.UseVisualStyleBackColor = true;
            this.btSort2.Click += new System.EventHandler(this.btSort2_Click);
            // 
            // btSort3
            // 
            this.btSort3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSort3.Location = new System.Drawing.Point(5, 106);
            this.btSort3.Name = "btSort3";
            this.btSort3.Size = new System.Drawing.Size(309, 61);
            this.btSort3.TabIndex = 2;
            this.btSort3.Text = "sort by using IComparer-object (by nr of credits)";
            this.btSort3.UseVisualStyleBackColor = true;
            this.btSort3.Click += new System.EventHandler(this.btSort3_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(340, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(384, 460);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 485);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btSort3);
            this.Controls.Add(this.btSort2);
            this.Controls.Add(this.btSort1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSort1;
        private System.Windows.Forms.Button btSort2;
        private System.Windows.Forms.Button btSort3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

