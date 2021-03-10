using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaBazar
{
    public partial class MainForm : Form
    {
        List<DepartmentUserControl> controls;
        List<Department> departments;

        int workerRole;

        private string username;
        private int user_id;
        public MainForm(string username, int workerRole, int user_id)
        {
            InitializeComponent();
            controls = new List<DepartmentUserControl>();
            UpdateGUI();
            this.user_id = user_id;
            this.username = username;
            this.workerRole = workerRole;

            if (workerRole == (int)ProfileRoles.ADMINISTRATOR)
            {
                btnFireEmployeeRequest.Visible = false;
                btnHireEmployeeRequest.Visible = false;
            }
            else if (workerRole == (int)ProfileRoles.MANAGER)
            {
                btnFireManager.Visible = false;
                btnCreateAdminManager.Visible = false;
                addNewDepartmentBttn.Visible = false;
                btnViewRequests.Visible = false;
            }
            else if (workerRole == (int)ProfileRoles.EMPLOYEE)
            {
                tabControl1.TabPages.Remove(employeesTab);
                tabControl1.TabPages.Remove(departmentsTab);
                requestStockBttn.Visible = false;
                createStockBttn.Visible = false;
            }
        }

        public void UpdateGUI()
        {
            departments = null;
            controls.Clear();
            flpDepartments.Controls.Clear();
            departments = Department.GetAllDepartments();

            foreach (Department d in departments)
            {
                controls.Add(new DepartmentUserControl(d.DepartmentId, d.Name, d.Description, d.NeededPeople, this));
            }

            foreach (DepartmentUserControl department in controls)
            {
                flpDepartments.Controls.Add(department);
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
    }
}