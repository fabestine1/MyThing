using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazar
{

    public partial class DepartmentUserControl : UserControl
    {
        int depId;
        int neededPeople;
        MainForm form;

        public DepartmentUserControl(int departmentid, string name, string department, int neededpeople, MainForm form = null)
        {
            InitializeComponent();
            lblDepartmentName.Text = name;
            lblDepartmentDescription.Text = department;
            neededPeople = neededpeople;
            depId = departmentid;
            this.form = form;
        }

        private void editDepartmentBttn_Click(object sender, EventArgs e)
        {
            string name = lblDepartmentName.Text;
            string description = lblDepartmentDescription.Text;
            EditDepartmentForm editDepartment = new EditDepartmentForm(depId, name, description, neededPeople, form);
            editDepartment.Show();
        }

        private void deleteDepartmentBttn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to remove this department?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Department dep in Department.GetAllDepartments())
                {
                    if (dep.DepartmentId == depId)
                    {
                        dep.RemoveDepartment();
                    }
                }
                form.UpdateGUI();
            }
        }
    }
}
