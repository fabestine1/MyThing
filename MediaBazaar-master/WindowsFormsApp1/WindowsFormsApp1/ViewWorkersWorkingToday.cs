using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace MediaBazar
{
    public partial class ViewWorkersWorkingToday : Form
    {

        List<CurrentWorkingWorkerControl> controls;
        public ViewWorkersWorkingToday()
        {
            InitializeComponent();
            controls = new List<CurrentWorkingWorkerControl>();
            PopulateDepartments(Department.GetAllDepartments());
            cmbShifts.Items.Add("morning");
            cmbShifts.Items.Add("afternoon");
            cmbShifts.Items.Add("evening");
        }

        private void PopulateDepartments(List<Department> departments)
        {
            foreach (Department d in departments)
            {
                cmbDepartment.Items.Add(new DepartmentComboBoxItem(d));
            }
        }

        private void PopulateEmployees()
        {
            int departmentId = ((DepartmentComboBoxItem)cmbDepartment.SelectedItem).Id;
            string shift = cmbShifts.SelectedItem.ToString();
            foreach (Worker w in Worker.GettAllWorkers(departmentId, shift,0))
            {
                controls.Add(new CurrentWorkingWorkerControl(w.Id, w.FirstName, w.LastName,0, shift, this));
            }
            foreach (Worker w in Worker.GettAllWorkers(departmentId, shift, 1))
            {
                controls.Add(new CurrentWorkingWorkerControl(w.Id, w.FirstName, w.LastName,1, shift, this));
            }
            foreach (CurrentWorkingWorkerControl control in controls)
            {
                flpControl.Controls.Add(control);
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbShifts.Text = "";
            cmbShifts.Enabled = true;
        }

        private void cmbShifts_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpControl.Controls.Clear();
            controls.Clear();
            PopulateEmployees();
        }

        public void UpdateEmployees()
        {
            flpControl.Controls.Clear();
            controls.Clear();
            PopulateEmployees();
        }
    }
}
