using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaBazar
{
    public partial class FiringRequest : Form
    {
        private int loggedUserId;
        private int workerRole;
        public FiringRequest(int user_id, int workerRole)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            tbxFirstName.Enabled = false;
            tbxLastName.Enabled = false;
            PopulateDepartments(Department.GetAllDepartments());
            PopulateManagers(Manager.GetAllManagers());
            PopulateEmployees(Employee.GetAllEmployees());
            this.loggedUserId = user_id;
            this.workerRole = workerRole;
            if (workerRole == (int)ProfileRoles.ADMINISTRATOR)
            {
                btnSendFiringRequest.Visible = false;
                this.Text = "Remove manager!";
                cmbEmployees.Visible = false;
            }
            else if (workerRole == (int)ProfileRoles.MANAGER)
            {
                btnRemoveManager.Visible = false;
                cmbManagers.Visible = false;
            }
        }

        public FiringRequest(bool flag, int departmentId, string username, string firstName, string lastName, string description)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            if (flag)
            {
                this.Enabled = false;
                tbxFirstName.Text = firstName;
                tbxLastName.Text = lastName;
                rtbReason.Text = description;

                List<Department> departments = Department.GetAllDepartments();
                foreach (Department d in departments)
                {
                    if (d.DepartmentId == departmentId) cmbDepartment.Text = d.Name;
                }
            }
        }

        

        private void PopulateDepartments(List<Department> departments)
        {
            foreach (Department d in departments)
                cmbDepartment.Items.Add(new DepartmentComboBoxItem(d));
        }
        private void PopulateManagers(List<Manager> managers)
        {
            foreach (Manager m in managers)
            {
                cmbManagers.Items.Add(new ManagerComboBoxItems(m));
            }
        }
        private void PopulateEmployees(List<Employee> employees)
        {
            foreach (Employee e in employees)
            {
                cmbEmployees.Items.Add(new EmployeeComboBoxItem(e));
            }
        }

        private void BtnSendFiringRequest_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Utils.GetConnection();

            if (cmbDepartment.Text == "Department" || cmbDepartment.Text == "")
            {
                MessageBox.Show("Please select a department from the menu!");
            }
            else if (cmbEmployees.Text == "Employees" || cmbEmployees.Text == "")
            {
                MessageBox.Show("Please select an employee from the menu!");
            }
            else if (rtbReason.Text == "")
            {
                MessageBox.Show("Please fill in all the fields in the table!");
            }
            else if (rtbReason.Text == "Reason for firing")
            {
                MessageBox.Show("Please change the initial information in the fields!");
            }
            else
            {
                string description = rtbReason.Text;
                int departmentId = ((DepartmentComboBoxItem)cmbDepartment.SelectedItem).Id;
                int employeeId = ((EmployeeComboBoxItem)cmbEmployees.SelectedItem).Id;
                string employeeUsername = ((EmployeeComboBoxItem)cmbEmployees.SelectedItem).Username;
                string employeeFirstName = ((EmployeeComboBoxItem)cmbEmployees.SelectedItem).FirstName;
                string employeeLastName = ((EmployeeComboBoxItem)cmbEmployees.SelectedItem).LastName;
                try
                {
                    FiringRequests fr = new FiringRequests(employeeId, this.loggedUserId, employeeUsername, description, employeeFirstName, employeeLastName, departmentId);
                    FiringRequests fr1 = new FiringRequests(employeeId, this.loggedUserId, description);
                    if (!fr1.FrExists)
                    {
                        MessageBox.Show("Firing request already exists!");
                    }
                    else
                    {
                        tbxFirstName.Text = employeeFirstName;
                        tbxLastName.Text = employeeLastName;
                        MessageBox.Show("Request sent successfully!");
                    }
                }
                catch (Exception ex)
                {
                    string epra = ex.Message;
                }
                finally
                {
                    conn.Close();
                }
            }

        }

        private void BtnRemoveManager_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Utils.GetConnection();
            List<int> contactIds = new List<int>();
            try
            {
                int managerId = ((ManagerComboBoxItems)cmbManagers.SelectedItem).Id;
                if (cmbDepartment.Text == "Department" || cmbDepartment.Text == "")
                {
                    MessageBox.Show("Please select a department from the menu!");
                }
                else if (rtbReason.Text == "Reason for firing")
                {
                    MessageBox.Show("Please change the initial information in the fields!");
                }
                else if (cmbManagers.Text == "Managers" || cmbManagers.Text == "")
                {
                    MessageBox.Show("Please select a manager from the menu!");
                }
                else if (rtbReason.Text == "")
                {
                    MessageBox.Show("Please fill in all the fields in the table!");
                }
                else
                {
                    try
                    {
                        string userRemoveQuery = "DELETE From user WHERE account_id = @manager_Id";
                        MySqlCommand userRemoveCmd = new MySqlCommand(userRemoveQuery, conn);
                        conn.Open();
                        userRemoveCmd.Parameters.AddWithValue("@manager_Id", managerId);
                        userRemoveCmd.ExecuteNonQuery();

                        string employeeRemoveQuery = "DELETE From employee_details WHERE person_id = @manager_Id";
                        MySqlCommand employeeRemoveCmd = new MySqlCommand(employeeRemoveQuery, conn);
                        employeeRemoveCmd.Parameters.AddWithValue("@manager_Id", managerId);
                        employeeRemoveCmd.ExecuteNonQuery();

                        string employeeDaysRemoveQuery = "DELETE From employee_working_days WHERE employee_id = @manager_Id";
                        MySqlCommand employeeDaysRemoveCmd = new MySqlCommand(employeeDaysRemoveQuery, conn);
                        employeeDaysRemoveCmd.Parameters.AddWithValue("@manager_Id", managerId);
                        employeeDaysRemoveCmd.ExecuteNonQuery();

                        string sql = "SELECT contact_person_id FROM contact_person WHERE employee_id = @manager_Id";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@manager_Id", managerId);
                        MySqlDataReader row = cmd.ExecuteReader();
                        while (row.Read())
                        {
                            contactIds.Add(Convert.ToInt32(row[0]));
                        }
                        conn.Close();

                        string employeeContactRemoveQuery = "DELETE From contact_person WHERE employee_id = @manager_Id";
                        MySqlCommand employeeContactRemoveCmd = new MySqlCommand(employeeContactRemoveQuery, conn);
                        conn.Open();
                        employeeContactRemoveCmd.Parameters.AddWithValue("@manager_Id", managerId);
                        employeeContactRemoveCmd.ExecuteNonQuery();

                        foreach (int id in contactIds)
                        {
                            string contactRemoveQuery = "DELETE FROM person WHERE id=@contact_Id";
                            MySqlCommand contactRemoveCmd = new MySqlCommand(contactRemoveQuery, conn);
                            contactRemoveCmd.Parameters.AddWithValue("@contact_id", id);
                            contactRemoveCmd.ExecuteNonQuery();
                        }

                        string contractUpdateQuery = "UPDATE contract SET contract_end = @end_date, reason_for_leaving = @description WHERE person_id = @manager_Id";
                        MySqlCommand contractUpdateCmd = new MySqlCommand(contractUpdateQuery, conn);
                        contractUpdateCmd.Parameters.AddWithValue("@end_date", Utils.GetDateTime());
                        contractUpdateCmd.Parameters.AddWithValue("@description", rtbReason.Text);
                        contractUpdateCmd.Parameters.AddWithValue("@manager_Id", managerId);
                        contractUpdateCmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        string epra = ex.Message;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please select a department from the menu!");
            }
        }
    }
}
