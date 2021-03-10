namespace MediaBazar
{
    partial class PromotionRequest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.btnSendPromotionRequest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericHourlywage = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCurrentWage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericHourlywage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select employee:";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(184, 6);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(145, 30);
            this.cmbDepartment.TabIndex = 2;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.Enabled = false;
            this.cmbEmployee.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(184, 50);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(145, 30);
            this.cmbEmployee.TabIndex = 3;
            this.cmbEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbEmployee_SelectedIndexChanged);
            // 
            // btnSendPromotionRequest
            // 
            this.btnSendPromotionRequest.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendPromotionRequest.Location = new System.Drawing.Point(95, 174);
            this.btnSendPromotionRequest.Name = "btnSendPromotionRequest";
            this.btnSendPromotionRequest.Size = new System.Drawing.Size(145, 35);
            this.btnSendPromotionRequest.TabIndex = 4;
            this.btnSendPromotionRequest.Text = "Promote Employee";
            this.btnSendPromotionRequest.UseVisualStyleBackColor = true;
            this.btnSendPromotionRequest.Click += new System.EventHandler(this.btnSendPromotionRequest_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "New hourlywage:";
            // 
            // numericHourlywage
            // 
            this.numericHourlywage.DecimalPlaces = 1;
            this.numericHourlywage.Enabled = false;
            this.numericHourlywage.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericHourlywage.Location = new System.Drawing.Point(184, 137);
            this.numericHourlywage.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericHourlywage.Name = "numericHourlywage";
            this.numericHourlywage.Size = new System.Drawing.Size(145, 27);
            this.numericHourlywage.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Current hourlywage:";
            // 
            // lblCurrentWage
            // 
            this.lblCurrentWage.AutoSize = true;
            this.lblCurrentWage.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentWage.Location = new System.Drawing.Point(209, 97);
            this.lblCurrentWage.Name = "lblCurrentWage";
            this.lblCurrentWage.Size = new System.Drawing.Size(16, 22);
            this.lblCurrentWage.TabIndex = 8;
            this.lblCurrentWage.Text = "-";
            // 
            // PromotionRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 221);
            this.Controls.Add(this.lblCurrentWage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericHourlywage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSendPromotionRequest);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PromotionRequest";
            this.Text = "PromotionRequest";
            ((System.ComponentModel.ISupportInitialize)(this.numericHourlywage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Button btnSendPromotionRequest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericHourlywage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCurrentWage;
    }
}