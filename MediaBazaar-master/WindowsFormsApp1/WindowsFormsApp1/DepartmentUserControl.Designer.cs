namespace MediaBazar
{
    partial class DepartmentUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentUserControl));
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.lblDepartmentDescription = new System.Windows.Forms.Label();
            this.editDepartmentBttn = new System.Windows.Forms.PictureBox();
            this.deleteDepartmentBttn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.editDepartmentBttn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteDepartmentBttn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentName.Location = new System.Drawing.Point(16, 18);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(334, 46);
            this.lblDepartmentName.TabIndex = 0;
            this.lblDepartmentName.Text = "Department Name";
            // 
            // lblDepartmentDescription
            // 
            this.lblDepartmentDescription.AutoSize = true;
            this.lblDepartmentDescription.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentDescription.Location = new System.Drawing.Point(19, 77);
            this.lblDepartmentDescription.Name = "lblDepartmentDescription";
            this.lblDepartmentDescription.Size = new System.Drawing.Size(269, 29);
            this.lblDepartmentDescription.TabIndex = 1;
            this.lblDepartmentDescription.Text = "Department description";
            // 
            // editDepartmentBttn
            // 
            this.editDepartmentBttn.Image = ((System.Drawing.Image)(resources.GetObject("editDepartmentBttn.Image")));
            this.editDepartmentBttn.Location = new System.Drawing.Point(443, 18);
            this.editDepartmentBttn.Name = "editDepartmentBttn";
            this.editDepartmentBttn.Size = new System.Drawing.Size(45, 46);
            this.editDepartmentBttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editDepartmentBttn.TabIndex = 4;
            this.editDepartmentBttn.TabStop = false;
            this.editDepartmentBttn.Click += new System.EventHandler(this.editDepartmentBttn_Click);
            // 
            // deleteDepartmentBttn
            // 
            this.deleteDepartmentBttn.Image = ((System.Drawing.Image)(resources.GetObject("deleteDepartmentBttn.Image")));
            this.deleteDepartmentBttn.Location = new System.Drawing.Point(494, 18);
            this.deleteDepartmentBttn.Name = "deleteDepartmentBttn";
            this.deleteDepartmentBttn.Size = new System.Drawing.Size(46, 46);
            this.deleteDepartmentBttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteDepartmentBttn.TabIndex = 5;
            this.deleteDepartmentBttn.TabStop = false;
            this.deleteDepartmentBttn.Click += new System.EventHandler(this.deleteDepartmentBttn_Click);
            // 
            // DepartmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.deleteDepartmentBttn);
            this.Controls.Add(this.editDepartmentBttn);
            this.Controls.Add(this.lblDepartmentDescription);
            this.Controls.Add(this.lblDepartmentName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DepartmentUserControl";
            this.Size = new System.Drawing.Size(552, 161);
            ((System.ComponentModel.ISupportInitialize)(this.editDepartmentBttn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteDepartmentBttn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label lblDepartmentDescription;
        private System.Windows.Forms.PictureBox editDepartmentBttn;
        private System.Windows.Forms.PictureBox deleteDepartmentBttn;
    }
}
