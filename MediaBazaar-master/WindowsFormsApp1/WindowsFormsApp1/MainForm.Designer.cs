namespace MediaBazar
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.employeesTab = new System.Windows.Forms.TabPage();
            this.RuleseditBtn = new System.Windows.Forms.Button();
            this.btnPromoteEmployee = new System.Windows.Forms.Button();
            this.btnChangeSchedule = new System.Windows.Forms.Button();
            this.btnViewRequests = new System.Windows.Forms.Button();
            this.btnHireEmployeeRequest = new System.Windows.Forms.Button();
            this.btnFireEmployeeRequest = new System.Windows.Forms.Button();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.btnFireManager = new System.Windows.Forms.Button();
            this.btnCreateAdminManager = new System.Windows.Forms.Button();
            this.stocksTab = new System.Windows.Forms.TabPage();
            this.requestStockBttn = new System.Windows.Forms.Button();
            this.viewStocksBttn = new System.Windows.Forms.Button();
            this.viewUpcomingShelfRestocksBttn = new System.Windows.Forms.Button();
            this.createStockBttn = new System.Windows.Forms.Button();
            this.departmentsTab = new System.Windows.Forms.TabPage();
            this.workersWorkingTodayBttn = new System.Windows.Forms.Button();
            this.additionalDepartmentActionsBttn = new System.Windows.Forms.Button();
            this.addNewDepartmentBttn = new System.Windows.Forms.PictureBox();
            this.flpDepartments = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.reportsTab = new System.Windows.Forms.TabPage();
            this.flpReports = new System.Windows.Forms.FlowLayoutPanel();
            this.lblReports = new System.Windows.Forms.Label();
            this.checkInTab = new System.Windows.Forms.TabPage();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.employeesTab.SuspendLayout();
            this.stocksTab.SuspendLayout();
            this.departmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addNewDepartmentBttn)).BeginInit();
            this.reportsTab.SuspendLayout();
            this.checkInTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.employeesTab);
            this.tabControl1.Controls.Add(this.stocksTab);
            this.tabControl1.Controls.Add(this.departmentsTab);
            this.tabControl1.Controls.Add(this.reportsTab);
            this.tabControl1.Controls.Add(this.checkInTab);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1144, 492);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // employeesTab
            // 
            this.employeesTab.Controls.Add(this.RuleseditBtn);
            this.employeesTab.Controls.Add(this.btnPromoteEmployee);
            this.employeesTab.Controls.Add(this.btnChangeSchedule);
            this.employeesTab.Controls.Add(this.btnViewRequests);
            this.employeesTab.Controls.Add(this.btnHireEmployeeRequest);
            this.employeesTab.Controls.Add(this.btnFireEmployeeRequest);
            this.employeesTab.Controls.Add(this.btnSearchEmployee);
            this.employeesTab.Controls.Add(this.btnFireManager);
            this.employeesTab.Controls.Add(this.btnCreateAdminManager);
            this.employeesTab.Location = new System.Drawing.Point(4, 25);
            this.employeesTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeesTab.Name = "employeesTab";
            this.employeesTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeesTab.Size = new System.Drawing.Size(1136, 463);
            this.employeesTab.TabIndex = 0;
            this.employeesTab.Text = "Employees";
            this.employeesTab.UseVisualStyleBackColor = true;
            // 
            // RuleseditBtn
            // 
            this.RuleseditBtn.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RuleseditBtn.Location = new System.Drawing.Point(35, 300);
            this.RuleseditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RuleseditBtn.Name = "RuleseditBtn";
            this.RuleseditBtn.Size = new System.Drawing.Size(1036, 57);
            this.RuleseditBtn.TabIndex = 36;
            this.RuleseditBtn.Text = "Edit rules";
            this.RuleseditBtn.UseVisualStyleBackColor = true;
            this.RuleseditBtn.Click += new System.EventHandler(this.RuleseditBtn_Click);
            // 
            // btnPromoteEmployee
            // 
            this.btnPromoteEmployee.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromoteEmployee.Location = new System.Drawing.Point(35, 364);
            this.btnPromoteEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnPromoteEmployee.Name = "btnPromoteEmployee";
            this.btnPromoteEmployee.Size = new System.Drawing.Size(1036, 55);
            this.btnPromoteEmployee.TabIndex = 35;
            this.btnPromoteEmployee.Text = "Promote employee";
            this.btnPromoteEmployee.UseVisualStyleBackColor = true;
            this.btnPromoteEmployee.Click += new System.EventHandler(this.btnPromoteEmployee_Click);
            // 
            // btnChangeSchedule
            // 
            this.btnChangeSchedule.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeSchedule.Location = new System.Drawing.Point(35, 230);
            this.btnChangeSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangeSchedule.Name = "btnChangeSchedule";
            this.btnChangeSchedule.Size = new System.Drawing.Size(1036, 64);
            this.btnChangeSchedule.TabIndex = 34;
            this.btnChangeSchedule.Text = "Change employee\'s schedule";
            this.btnChangeSchedule.UseVisualStyleBackColor = true;
            this.btnChangeSchedule.Click += new System.EventHandler(this.BtnChangeSchedule_Click);
            // 
            // btnViewRequests
            // 
            this.btnViewRequests.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRequests.Location = new System.Drawing.Point(35, 230);
            this.btnViewRequests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewRequests.Name = "btnViewRequests";
            this.btnViewRequests.Size = new System.Drawing.Size(1036, 64);
            this.btnViewRequests.TabIndex = 33;
            this.btnViewRequests.Text = "View requests";
            this.btnViewRequests.UseVisualStyleBackColor = true;
            this.btnViewRequests.Click += new System.EventHandler(this.BtnViewRequests_Click);
            // 
            // btnHireEmployeeRequest
            // 
            this.btnHireEmployeeRequest.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHireEmployeeRequest.Location = new System.Drawing.Point(35, 21);
            this.btnHireEmployeeRequest.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnHireEmployeeRequest.Name = "btnHireEmployeeRequest";
            this.btnHireEmployeeRequest.Size = new System.Drawing.Size(1036, 65);
            this.btnHireEmployeeRequest.TabIndex = 32;
            this.btnHireEmployeeRequest.Text = "Hire employee request";
            this.btnHireEmployeeRequest.UseVisualStyleBackColor = true;
            this.btnHireEmployeeRequest.Click += new System.EventHandler(this.BtnHireEmployeeRequest_Click);
            // 
            // btnFireEmployeeRequest
            // 
            this.btnFireEmployeeRequest.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFireEmployeeRequest.Location = new System.Drawing.Point(35, 91);
            this.btnFireEmployeeRequest.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnFireEmployeeRequest.Name = "btnFireEmployeeRequest";
            this.btnFireEmployeeRequest.Size = new System.Drawing.Size(1036, 65);
            this.btnFireEmployeeRequest.TabIndex = 31;
            this.btnFireEmployeeRequest.Text = "Fire employee request";
            this.btnFireEmployeeRequest.UseVisualStyleBackColor = true;
            this.btnFireEmployeeRequest.Click += new System.EventHandler(this.BtnFireEmployeeRequest_Click);
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmployee.Location = new System.Drawing.Point(35, 161);
            this.btnSearchEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(1036, 64);
            this.btnSearchEmployee.TabIndex = 30;
            this.btnSearchEmployee.Text = "Search for employee";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // btnFireManager
            // 
            this.btnFireManager.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFireManager.Location = new System.Drawing.Point(35, 91);
            this.btnFireManager.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnFireManager.Name = "btnFireManager";
            this.btnFireManager.Size = new System.Drawing.Size(1036, 65);
            this.btnFireManager.TabIndex = 29;
            this.btnFireManager.Text = "Fire manager";
            this.btnFireManager.UseVisualStyleBackColor = true;
            this.btnFireManager.Click += new System.EventHandler(this.BtnFireManager_Click);
            // 
            // btnCreateAdminManager
            // 
            this.btnCreateAdminManager.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAdminManager.Location = new System.Drawing.Point(35, 21);
            this.btnCreateAdminManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateAdminManager.Name = "btnCreateAdminManager";
            this.btnCreateAdminManager.Size = new System.Drawing.Size(1036, 65);
            this.btnCreateAdminManager.TabIndex = 27;
            this.btnCreateAdminManager.Text = "Create admin/manager";
            this.btnCreateAdminManager.UseVisualStyleBackColor = true;
            this.btnCreateAdminManager.Click += new System.EventHandler(this.btnCreateAdminManager_Click);
            // 
            // stocksTab
            // 
            this.stocksTab.Controls.Add(this.requestStockBttn);
            this.stocksTab.Controls.Add(this.viewStocksBttn);
            this.stocksTab.Controls.Add(this.viewUpcomingShelfRestocksBttn);
            this.stocksTab.Controls.Add(this.createStockBttn);
            this.stocksTab.Location = new System.Drawing.Point(4, 25);
            this.stocksTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stocksTab.Name = "stocksTab";
            this.stocksTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stocksTab.Size = new System.Drawing.Size(1136, 463);
            this.stocksTab.TabIndex = 1;
            this.stocksTab.Text = "Stocks";
            this.stocksTab.UseVisualStyleBackColor = true;
            // 
            // requestStockBttn
            // 
            this.requestStockBttn.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestStockBttn.Location = new System.Drawing.Point(28, 256);
            this.requestStockBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.requestStockBttn.Name = "requestStockBttn";
            this.requestStockBttn.Size = new System.Drawing.Size(1053, 68);
            this.requestStockBttn.TabIndex = 30;
            this.requestStockBttn.Text = "Request Stock";
            this.requestStockBttn.UseVisualStyleBackColor = true;
            this.requestStockBttn.Click += new System.EventHandler(this.requestStockBttn_Click);
            // 
            // viewStocksBttn
            // 
            this.viewStocksBttn.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewStocksBttn.Location = new System.Drawing.Point(28, 146);
            this.viewStocksBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewStocksBttn.Name = "viewStocksBttn";
            this.viewStocksBttn.Size = new System.Drawing.Size(1053, 66);
            this.viewStocksBttn.TabIndex = 29;
            this.viewStocksBttn.Text = "View Stocks";
            this.viewStocksBttn.UseVisualStyleBackColor = true;
            this.viewStocksBttn.Click += new System.EventHandler(this.viewStocksBttn_Click);
            // 
            // viewUpcomingShelfRestocksBttn
            // 
            this.viewUpcomingShelfRestocksBttn.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewUpcomingShelfRestocksBttn.Location = new System.Drawing.Point(28, 34);
            this.viewUpcomingShelfRestocksBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewUpcomingShelfRestocksBttn.Name = "viewUpcomingShelfRestocksBttn";
            this.viewUpcomingShelfRestocksBttn.Size = new System.Drawing.Size(1053, 70);
            this.viewUpcomingShelfRestocksBttn.TabIndex = 28;
            this.viewUpcomingShelfRestocksBttn.Text = "View upcoming shelf requests";
            this.viewUpcomingShelfRestocksBttn.UseVisualStyleBackColor = true;
            this.viewUpcomingShelfRestocksBttn.Click += new System.EventHandler(this.viewUpcomingShelfRestocksBttn_Click);
            // 
            // createStockBttn
            // 
            this.createStockBttn.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createStockBttn.Location = new System.Drawing.Point(28, 366);
            this.createStockBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createStockBttn.Name = "createStockBttn";
            this.createStockBttn.Size = new System.Drawing.Size(1053, 70);
            this.createStockBttn.TabIndex = 27;
            this.createStockBttn.Text = "Create stock";
            this.createStockBttn.UseVisualStyleBackColor = true;
            this.createStockBttn.Click += new System.EventHandler(this.createStockBttn_Click);
            // 
            // departmentsTab
            // 
            this.departmentsTab.Controls.Add(this.workersWorkingTodayBttn);
            this.departmentsTab.Controls.Add(this.additionalDepartmentActionsBttn);
            this.departmentsTab.Controls.Add(this.addNewDepartmentBttn);
            this.departmentsTab.Controls.Add(this.flpDepartments);
            this.departmentsTab.Controls.Add(this.label4);
            this.departmentsTab.Location = new System.Drawing.Point(4, 25);
            this.departmentsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.departmentsTab.Name = "departmentsTab";
            this.departmentsTab.Size = new System.Drawing.Size(1136, 463);
            this.departmentsTab.TabIndex = 2;
            this.departmentsTab.Text = "Departments";
            this.departmentsTab.UseVisualStyleBackColor = true;
            // 
            // workersWorkingTodayBttn
            // 
            this.workersWorkingTodayBttn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workersWorkingTodayBttn.Location = new System.Drawing.Point(432, 38);
            this.workersWorkingTodayBttn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.workersWorkingTodayBttn.Name = "workersWorkingTodayBttn";
            this.workersWorkingTodayBttn.Size = new System.Drawing.Size(280, 52);
            this.workersWorkingTodayBttn.TabIndex = 20;
            this.workersWorkingTodayBttn.Text = "Workers Working Today";
            this.workersWorkingTodayBttn.UseVisualStyleBackColor = true;
            this.workersWorkingTodayBttn.Click += new System.EventHandler(this.workersWorkingTodayBttn_Click);
            // 
            // additionalDepartmentActionsBttn
            // 
            this.additionalDepartmentActionsBttn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalDepartmentActionsBttn.Location = new System.Drawing.Point(719, 38);
            this.additionalDepartmentActionsBttn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.additionalDepartmentActionsBttn.Name = "additionalDepartmentActionsBttn";
            this.additionalDepartmentActionsBttn.Size = new System.Drawing.Size(291, 52);
            this.additionalDepartmentActionsBttn.TabIndex = 19;
            this.additionalDepartmentActionsBttn.Text = "Additional Actions";
            this.additionalDepartmentActionsBttn.UseVisualStyleBackColor = true;
            this.additionalDepartmentActionsBttn.Click += new System.EventHandler(this.additionalDepartmentActionsBttn_Click);
            // 
            // addNewDepartmentBttn
            // 
            this.addNewDepartmentBttn.Image = ((System.Drawing.Image)(resources.GetObject("addNewDepartmentBttn.Image")));
            this.addNewDepartmentBttn.Location = new System.Drawing.Point(1027, 38);
            this.addNewDepartmentBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNewDepartmentBttn.Name = "addNewDepartmentBttn";
            this.addNewDepartmentBttn.Size = new System.Drawing.Size(59, 49);
            this.addNewDepartmentBttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addNewDepartmentBttn.TabIndex = 17;
            this.addNewDepartmentBttn.TabStop = false;
            this.addNewDepartmentBttn.Click += new System.EventHandler(this.addDepartmentBttn_Click);
            // 
            // flpDepartments
            // 
            this.flpDepartments.AutoScroll = true;
            this.flpDepartments.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpDepartments.Location = new System.Drawing.Point(40, 106);
            this.flpDepartments.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.flpDepartments.Name = "flpDepartments";
            this.flpDepartments.Size = new System.Drawing.Size(1072, 348);
            this.flpDepartments.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "Departments:";
            // 
            // reportsTab
            // 
            this.reportsTab.Controls.Add(this.flpReports);
            this.reportsTab.Controls.Add(this.lblReports);
            this.reportsTab.Location = new System.Drawing.Point(4, 25);
            this.reportsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportsTab.Name = "reportsTab";
            this.reportsTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportsTab.Size = new System.Drawing.Size(1136, 463);
            this.reportsTab.TabIndex = 3;
            this.reportsTab.Text = "Reports";
            this.reportsTab.UseVisualStyleBackColor = true;
            // 
            // flpReports
            // 
            this.flpReports.AutoScroll = true;
            this.flpReports.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpReports.Location = new System.Drawing.Point(21, 63);
            this.flpReports.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.flpReports.Name = "flpReports";
            this.flpReports.Size = new System.Drawing.Size(1101, 383);
            this.flpReports.TabIndex = 14;
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.Location = new System.Drawing.Point(16, 25);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(295, 33);
            this.lblReports.TabIndex = 13;
            this.lblReports.Text = "Anonymous reports:";
            // 
            // checkInTab
            // 
            this.checkInTab.Controls.Add(this.btnCheckOut);
            this.checkInTab.Controls.Add(this.btnCheckIn);
            this.checkInTab.Location = new System.Drawing.Point(4, 25);
            this.checkInTab.Name = "checkInTab";
            this.checkInTab.Padding = new System.Windows.Forms.Padding(3);
            this.checkInTab.Size = new System.Drawing.Size(1136, 463);
            this.checkInTab.TabIndex = 4;
            this.checkInTab.Text = "CheckIn";
            this.checkInTab.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(371, 128);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(376, 196);
            this.btnCheckIn.TabIndex = 0;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.BtnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(371, 128);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(376, 196);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.BtnCheckOut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 501);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Media Bazar";
            this.tabControl1.ResumeLayout(false);
            this.employeesTab.ResumeLayout(false);
            this.stocksTab.ResumeLayout(false);
            this.departmentsTab.ResumeLayout(false);
            this.departmentsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addNewDepartmentBttn)).EndInit();
            this.reportsTab.ResumeLayout(false);
            this.reportsTab.PerformLayout();
            this.checkInTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage employeesTab;
        private System.Windows.Forms.TabPage stocksTab;
        private System.Windows.Forms.TabPage departmentsTab;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Button btnCreateAdminManager;

        private System.Windows.Forms.Button viewUpcomingShelfRestocksBttn;

        private System.Windows.Forms.Button createStockBttn;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.Button btnFireManager;
        private System.Windows.Forms.FlowLayoutPanel flpDepartments;

        private System.Windows.Forms.Button btnFireEmployeeRequest;
        private System.Windows.Forms.Button btnHireEmployeeRequest;

        private System.Windows.Forms.Button requestStockBttn;
        private System.Windows.Forms.Button viewStocksBttn;
        private System.Windows.Forms.PictureBox addNewDepartmentBttn;
        private System.Windows.Forms.Button btnViewRequests;
        private System.Windows.Forms.Button additionalDepartmentActionsBttn;
        private System.Windows.Forms.Button btnChangeSchedule;
        private System.Windows.Forms.Button btnPromoteEmployee;
        private System.Windows.Forms.Button RuleseditBtn;
        private System.Windows.Forms.TabPage reportsTab;
        private System.Windows.Forms.FlowLayoutPanel flpReports;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.Button workersWorkingTodayBttn;
        private System.Windows.Forms.TabPage checkInTab;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
    }
}