namespace StudentWiseClient
{
    partial class GroupDetailedComponent
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.btnMoveMember = new System.Windows.Forms.Button();
            this.cbxMembers = new System.Windows.Forms.ComboBox();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.lblManageMembers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoEllipsis = true;
            this.lblName.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(280, 35);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoEllipsis = true;
            this.lblDateTime.Font = new System.Drawing.Font("Oswald", 12F);
            this.lblDateTime.Location = new System.Drawing.Point(300, 20);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(280, 35);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "DateTime";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoEllipsis = true;
            this.lblDescription.Font = new System.Drawing.Font("Oswald", 10F);
            this.lblDescription.Location = new System.Drawing.Point(20, 73);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(560, 65);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // lblRules
            // 
            this.lblRules.AutoEllipsis = true;
            this.lblRules.Font = new System.Drawing.Font("Oswald", 10F);
            this.lblRules.Location = new System.Drawing.Point(20, 138);
            this.lblRules.Margin = new System.Windows.Forms.Padding(0);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(560, 92);
            this.lblRules.TabIndex = 0;
            this.lblRules.Text = "Rules";
            // 
            // btnMoveMember
            // 
            this.btnMoveMember.Font = new System.Drawing.Font("Oswald", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveMember.Location = new System.Drawing.Point(306, 277);
            this.btnMoveMember.Name = "btnMoveMember";
            this.btnMoveMember.Size = new System.Drawing.Size(130, 42);
            this.btnMoveMember.TabIndex = 2;
            this.btnMoveMember.Text = "Move";
            this.btnMoveMember.UseVisualStyleBackColor = false;
            this.btnMoveMember.Click += new System.EventHandler(this.BtnMoveMember_Click);
            // 
            // cbxMembers
            // 
            this.cbxMembers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMembers.Font = new System.Drawing.Font("Oswald", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMembers.FormattingEnabled = true;
            this.cbxMembers.Location = new System.Drawing.Point(23, 278);
            this.cbxMembers.Name = "cbxMembers";
            this.cbxMembers.Size = new System.Drawing.Size(270, 39);
            this.cbxMembers.TabIndex = 1;
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Font = new System.Drawing.Font("Oswald", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveMember.Location = new System.Drawing.Point(447, 277);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(130, 42);
            this.btnRemoveMember.TabIndex = 3;
            this.btnRemoveMember.Text = "Remove";
            this.btnRemoveMember.UseVisualStyleBackColor = true;
            this.btnRemoveMember.Click += new System.EventHandler(this.BtnRemoveMember_Click);
            // 
            // lblManageMembers
            // 
            this.lblManageMembers.AutoSize = true;
            this.lblManageMembers.Font = new System.Drawing.Font("Oswald", 10F, System.Drawing.FontStyle.Bold);
            this.lblManageMembers.Location = new System.Drawing.Point(20, 240);
            this.lblManageMembers.Margin = new System.Windows.Forms.Padding(0);
            this.lblManageMembers.Name = "lblManageMembers";
            this.lblManageMembers.Size = new System.Drawing.Size(135, 29);
            this.lblManageMembers.TabIndex = 4;
            this.lblManageMembers.Text = "Manage Members";
            // 
            // GroupDetailedComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.lblManageMembers);
            this.Controls.Add(this.cbxMembers);
            this.Controls.Add(this.btnMoveMember);
            this.Controls.Add(this.btnRemoveMember);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GroupDetailedComponent";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(600, 340);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Button btnMoveMember;
        private System.Windows.Forms.ComboBox cbxMembers;
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.Label lblManageMembers;
    }
}
