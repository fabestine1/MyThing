using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace MediaBazar
{
    public partial class CurrentWorkingWorkerControl : UserControl
    {
        private int workerId;
        private string shift;
        ViewWorkersWorkingToday form;

        public CurrentWorkingWorkerControl(int workerId, string firstName, string lastName, int attendence, string shift, ViewWorkersWorkingToday form)
        {
            InitializeComponent();
            lblFullName.Text = firstName + " " + lastName;
            this.workerId = workerId;
            this.shift = shift;
            this.form = form;

            if(attendence == 0)
            {
                this.BackColor = Color.Red;
                this.btnAttend.Enabled = true;
            }
            else
            {
                this.BackColor = Color.Green;
                this.btnAttend.Enabled = false;
            }
        }

        private void btnAttend_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm the employee attendance?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Worker.EmployeeAttend(workerId, shift);
            }
            form.UpdateEmployees();
        }
    }
}
