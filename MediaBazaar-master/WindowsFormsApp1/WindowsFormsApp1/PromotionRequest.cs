using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace MediaBazar
{
    public partial class PromotionRequest : Form
    {

        private int loggedUserId;
        public PromotionRequest(int user_id)
        {
            InitializeComponent();
            this.loggedUserId = user_id;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            PopulateDepartments(Department.GetAllDepartments());
            PopulateEmployees(Employee.GetAllEmployees());
        }

        public PromotionRequest(bool flag,int departmentId,string firstName,string lastName,decimal hourlyWage,decimal previousHourlyWage)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            numericHourlywage.Value = hourlyWage;
            cmbEmployee.Text = firstName + " " + lastName;
            lblCurrentWage.Text = previousHourlyWage.ToString() + "$/Hourly";
            if (flag)
            {
                this.Enabled = false;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
            {
                cmbDepartment.Items.Add(new DepartmentComboBoxItem(d));
            }
        }

        private void PopulateEmployees(List<Employee> employees)
        {
            cmbEmployee.Items.Clear();
            foreach (Employee e in employees)
            {
                cmbEmployee.Items.Add(new EmployeeComboBoxItem(e));
            }
        }


        private void btnSendPromotionRequest_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Utils.GetConnection();

            if (cmbDepartment.Text == "Department" || cmbDepartment.Text == "")
            {
                MessageBox.Show("Please select a department from the menu!");
            }
            else if (cmbEmployee.Text == "Employees" || cmbEmployee.Text == "")
            {
                MessageBox.Show("Please select an employee from the menu!");
            }
            else
            {
                int employeeid = ((EmployeeComboBoxItem)cmbEmployee.SelectedItem).Id;
                decimal CurrentWage = Worker.GetworkerCurrentWage(employeeid);
                decimal employeeHourlyWage = numericHourlywage.Value;
                if (CurrentWage >= employeeHourlyWage)
                {
                    MessageBox.Show("The new wage can not be lower than the worker's current wage!");
                }
                else
                {
                    int departmentId = ((DepartmentComboBoxItem)cmbDepartment.SelectedItem).Id;
                    int employeeId = ((EmployeeComboBoxItem)cmbEmployee.SelectedItem).Id;
                    string employeeUsername = ((EmployeeComboBoxItem)cmbEmployee.SelectedItem).Username;
                    string employeeFirstName = ((EmployeeComboBoxItem)cmbEmployee.SelectedItem).FirstName;
                    string employeeLastName = ((EmployeeComboBoxItem)cmbEmployee.SelectedItem).LastName;
                    if (MessageBox.Show("Do you really want to send this Promotion request?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            PromotionRequests pr = new PromotionRequests(employeeId, this.loggedUserId, employeeUsername, employeeFirstName, employeeLastName, departmentId, employeeHourlyWage);
                            PromotionRequests pr1 = new PromotionRequests(employeeId, this.loggedUserId, employeeHourlyWage);
                            if (!pr1.PrExists)
                            {
                                MessageBox.Show("Promotion request already exists!");
                            }
                            else
                            {
                                MessageBox.Show("Request sent successfully!");
                                this.Close();
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
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int departmentId = ((DepartmentComboBoxItem)cmbDepartment.SelectedItem).Id;
            PopulateEmployees(Employee.GetAllEmployeesByDepartment(departmentId));
            cmbEmployee.Enabled = true;
        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            int employeeid = ((EmployeeComboBoxItem)cmbEmployee.SelectedItem).Id;
            decimal CurrentWage = Worker.GetworkerCurrentWage(employeeid);
            lblCurrentWage.Text = CurrentWage.ToString() + "$/Hourly";
            numericHourlywage.Enabled = true;
            numericHourlywage.Value = CurrentWage;
        }
    }
}
