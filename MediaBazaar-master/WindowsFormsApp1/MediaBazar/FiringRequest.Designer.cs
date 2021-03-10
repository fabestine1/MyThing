namespace MediaBazar
{
    partial class FiringRequest
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
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.btnSendFiringRequest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbReason = new System.Windows.Forms.RichTextBox();
            this.btnRemoveManager = new System.Windows.Forms.Button();
            this.cmbManagers = new System.Windows.Forms.ComboBox();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 25);
            this.label6.TabIndex = 87;
            this.label6.Text = "Select department:";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(24, 71);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(256, 41);
            this.cmbDepartment.TabIndex = 86;
            this.cmbDepartment.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 85;
            this.label3.Text = "Select employee:";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.Location = new System.Drawing.Point(24, 271);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(255, 40);
            this.tbxLastName.TabIndex = 84;
            this.tbxLastName.Text = "Last name";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.Location = new System.Drawing.Point(24, 218);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(256, 40);
            this.tbxFirstName.TabIndex = 83;
            this.tbxFirstName.Text = "First name";
            // 
            // btnSendFiringRequest
            // 
            this.btnSendFiringRequest.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendFiringRequest.Location = new System.Drawing.Point(202, 324);
            this.btnSendFiringRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendFiringRequest.Name = "btnSendFiringRequest";
            this.btnSendFiringRequest.Size = new System.Drawing.Size(239, 46);
            this.btnSendFiringRequest.TabIndex = 82;
            this.btnSendFiringRequest.Text = "Send request";
            this.btnSendFiringRequest.UseVisualStyleBackColor = true;
            this.btnSendFiringRequest.Click += new System.EventHandler(this.BtnSendFiringRequest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(309, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 81;
            this.label1.Text = "Reason for firing";
            // 
            // rtbReason
            // 
            this.rtbReason.Font = new System.Drawing.Font("Montserrat", 16F);
            this.rtbReason.Location = new System.Drawing.Point(314, 71);
            this.rtbReason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbReason.Name = "rtbReason";
            this.rtbReason.Size = new System.Drawing.Size(359, 240);
            this.rtbReason.TabIndex = 80;
            this.rtbReason.Text = "Reason for firing";
            // 
            // btnRemoveManager
            // 
            this.btnRemoveManager.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveManager.Location = new System.Drawing.Point(202, 324);
            this.btnRemoveManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveManager.Name = "btnRemoveManager";
            this.btnRemoveManager.Size = new System.Drawing.Size(239, 46);
            this.btnRemoveManager.TabIndex = 89;
            this.btnRemoveManager.Text = "Fire manager";
            this.btnRemoveManager.UseVisualStyleBackColor = true;
            this.btnRemoveManager.Click += new System.EventHandler(this.BtnRemoveManager_Click);
            // 
            // cmbManagers
            // 
            this.cmbManagers.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbManagers.FormattingEnabled = true;
            this.cmbManagers.Location = new System.Drawing.Point(25, 163);
            this.cmbManagers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbManagers.Name = "cmbManagers";
            this.cmbManagers.Size = new System.Drawing.Size(255, 41);
            this.cmbManagers.TabIndex = 90;
            this.cmbManagers.Text = "Managers";
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(25, 163);
            this.cmbEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(256, 41);
            this.cmbEmployees.TabIndex = 91;
            this.cmbEmployees.Text = "Employees";
            // 
            // FiringRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 381);
            this.Controls.Add(this.cmbEmployees);
            this.Controls.Add(this.cmbManagers);
            this.Controls.Add(this.btnRemoveManager);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.btnSendFiringRequest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbReason);
            this.Name = "FiringRequest";
            this.Text = "FiringRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Button btnSendFiringRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbReason;
        private System.Windows.Forms.Button btnRemoveManager;
        private System.Windows.Forms.ComboBox cmbManagers;
        private System.Windows.Forms.ComboBox cmbEmployees;
    }
}