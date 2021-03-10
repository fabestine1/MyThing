using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaBazar
{
    public partial class MainForm : Form
    {
        List<DepartmentUserControl> controls;
        List<Department> departments;
        List<Report> reports;
        List<ReportControl> reportControls;
        List<string> workingShifts;

        int workerRole;

        private string username;
        private int user_id;

        CheckInService checkInService;
        CheckIn checkIn;

        public MainForm(string username, int workerRole, int user_id)
        {
            InitializeComponent();
            controls = new List<DepartmentUserControl>();
            reportControls = new List<ReportControl>();
            checkInService = new CheckInService();
            checkIn = new CheckIn();
            checkIn.CheckInEvent += checkInService.OnCheckIn;
            UpdateGUI();
            this.user_id = user_id;
            this.username = username;
            this.workerRole = workerRole;

            if (workerRole == (int)ProfileRoles.ADMINISTRATOR)
            {
                tabControl1.TabPages.Remove(checkInTab);
                btnFireEmployeeRequest.Visible = false;
                btnHireEmployeeRequest.Visible = false;
                btnChangeSchedule.Visible = false;
                btnPromoteEmployee.Visible = false;
            }
            else if (workerRole == (int)ProfileRoles.MANAGER)
            {
                tabControl1.TabPages.Remove(checkInTab);
                btnFireManager.Visible = false;
                btnCreateAdminManager.Visible = false;
                addNewDepartmentBttn.Visible = false;
                btnViewRequests.Visible = false;
            }
            else if (workerRole == (int)ProfileRoles.EMPLOYEE)
            {
                tabControl1.TabPages.Remove(employeesTab);
                tabControl1.TabPages.Remove(departmentsTab);
                tabControl1.TabPages.Remove(reportsTab);
                requestStockBttn.Visible = false;
                createStockBttn.Visible = false;
                btnPromoteEmployee.Visible = false;
                btnCheckOut.Visible = false;
            }
        }

        public void UpdateGUI()
        {
            departments = null;
            controls.Clear();
            reportControls.Clear();
            flpReports.Controls.Clear();
            flpDepartments.Controls.Clear();
            departments = Department.GetAllDepartments();
            reports = Report.GetAllReports();

            foreach (Department d in departments)
            {
                controls.Add(new DepartmentUserControl(d.DepartmentId, d.Name, d.Description, d.NeededPeople, this));
            }

            foreach (DepartmentUserControl department in controls)
            {
                flpDepartments.Controls.Add(department);
            }

            foreach (Report r in reports)
            {
                if(r.ReportStatus == "unread")
                {
                    reportControls.Add(new ReportControl(r.ReportId, r.ReportSubject, r.ReportMessage, r.ReportStatus, this));
                }
            }

            foreach (ReportControl report in reportControls)
            {
                flpReports.Controls.Add(report);
            }
        }

        private void createStockBttn_Click(object sender, EventArgs e)
        {
            (new AddStock()).Show();
        }

        private void viewUpcomingShelfRestocksBttn_Click(object sender, EventArgs e)
        {
            (new ShelfRestockRequests()).Show();
        }

        private void requestStockBttn_Click(object sender, EventArgs e)
        {
            (new RequestStock()).Show();
        }

        private void viewStocksBttn_Click(object sender, EventArgs e)
        {
            (new StockView(workerRole)).Show();
        }

        private void addDepartmentBttn_Click(object sender, EventArgs e)
        {
            (new AddDepartment(this)).Show();
            UpdateGUI();
        }

        private void BtnViewRequests_Click(object sender, EventArgs e)
        {
            (new ApproveManagerRequests()).Show();
        }

        private void BtnFireEmployeeRequest_Click(object sender, EventArgs e)
        {
            (new FiringRequest(this.user_id, workerRole)).Show();
        }

        private void btnCreateAdminManager_Click(object sender, EventArgs e)
        {
            (new CreateAccount(this.user_id, workerRole)).Show();
        }

        private void BtnHireEmployeeRequest_Click(object sender, EventArgs e)
        {
            (new CreateAccount(this.user_id, workerRole)).Show();
        }

        private void additionalDepartmentActionsBttn_Click(object sender, EventArgs e)
        {
            (new DepartmentActions()).Show();
        }


        private void BtnFireManager_Click(object sender, EventArgs e)
        {
            (new FiringRequest(this.user_id, workerRole)).Show();
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            (new SearchForEmployee()).Show();
        }

        private void BtnChangeSchedule_Click(object sender, EventArgs e)
        {
            (new ChangeSchedule(this.user_id)).Show();
        }

        private void btnPromoteEmployee_Click(object sender, EventArgs e)
        {
            (new PromotionRequest(this.user_id)).Show();
        }

        private void RuleseditBtn_Click(object sender, EventArgs e)
        {
            (new RulesEditor(this.user_id)).Show();
        }

        private void workersWorkingTodayBttn_Click(object sender, EventArgs e)
        {
            (new ViewWorkersWorkingToday()).Show();
        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            workingShifts = Employee.GetEmployeeCurrentWorkingShifts(user_id);
            if (workingShifts.Count == 0)
            {
                MessageBox.Show("You can't check in today because you don't have any assigned shifts!");
            }
            else
            {
                checkIn.CheckInEmployee(user_id);
                btnCheckIn.Visible = false;
                btnCheckOut.Visible = true;
                checkIn.CheckInEvent -= checkInService.OnCheckIn;
            }
        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            btnCheckIn.Visible = true;
            btnCheckOut.Visible = false;
            checkIn.CheckInEvent += checkInService.OnCheckIn;
        }
    }
}