namespace MediaBazar
{
    partial class AddDepartment
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
            this.addDepartmentbttn = new System.Windows.Forms.Button();
            this.numPeople = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // addDepartmentbttn
            // 
            this.addDepartmentbttn.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDepartmentbttn.Location = new System.Drawing.Point(18, 229);
            this.addDepartmentbttn.Margin = new System.Windows.Forms.Padding(2);
            this.addDepartmentbttn.Name = "addDepartmentbttn";
            this.addDepartmentbttn.Size = new System.Drawing.Size(296, 42);
            this.addDepartmentbttn.TabIndex = 9;
            this.addDepartmentbttn.Text = "Add Department";
            this.addDepartmentbttn.UseVisualStyleBackColor = true;
            this.addDepartmentbttn.Click += new System.EventHandler(this.addDepartmentbttn_Click);
            // 
            // numPeople
            // 
            this.numPeople.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPeople.Location = new System.Drawing.Point(208, 182);
            this.numPeople.Margin = new System.Windows.Forms.Padding(2);
            this.numPeople.Name = "numPeople";
            this.numPeople.Size = new System.Drawing.Size(105, 34);
            this.numPeople.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Needed people:";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.Location = new System.Drawing.Point(13, 67);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(2);
            this.rtbDescription.MaxLength = 300;
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(302, 101);
            this.rtbDescription.TabIndex = 6;
            this.rtbDescription.Text = "Description";
            this.rtbDescription.Enter += new System.EventHandler(this.rtbDescription_Enter);
            this.rtbDescription.Leave += new System.EventHandler(this.rtbDescription_Leave);
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(13, 19);
            this.tbxName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(302, 34);
            this.tbxName.TabIndex = 5;
            this.tbxName.Text = "Name";
            this.tbxName.Enter += new System.EventHandler(this.tbxName_Enter);
            this.tbxName.Leave += new System.EventHandler(this.tbxName_Leave);
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 288);
            this.Controls.Add(this.addDepartmentbttn);
            this.Controls.Add(this.numPeople);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.tbxName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddDepartment";
            this.Text = "Add Department";
            ((System.ComponentModel.ISupportInitialize)(this.numPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addDepartmentbttn;
        private System.Windows.Forms.NumericUpDown numPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.TextBox tbxName;
    }
}