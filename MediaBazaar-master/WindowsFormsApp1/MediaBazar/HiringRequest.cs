using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaBazar
{
    public partial class HiringRequest : Form
    {
        public HiringRequest(string username, string firstName, string lastName, decimal hourlyWage, int departmentId, DateTime contractStartDate, long phoneNumber, string email)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Enabled = false;

            tbUsername.Text = username;
            tbFirstName.Text = firstName;
            tbLastName.Text = lastName;
            nHourlyWage.Value = hourlyWage;
            dtbContractStartDate.Value = contractStartDate;
            tbPhoneNumber.Text = phoneNumber.ToString();
            tbEmail.Text = email;

            List<Department> departments = Department.GetAllDepartments();
            foreach (Department d in departments)
            {
                if (d.DepartmentId == departmentId) cmbDepartment.Text = d.Name;
            };
        }
    }
}
