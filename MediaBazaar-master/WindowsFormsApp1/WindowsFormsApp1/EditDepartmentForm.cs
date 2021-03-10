using System;
using System.Windows.Forms;

namespace MediaBazar
{
    public partial class EditDepartmentForm : Form
    {
        MainForm previousForm;
        int depId;

        public EditDepartmentForm(int id, string name, string description, int neededpeople, MainForm form)
        {
            InitializeComponent();
            this.depId = id;
            tbxName.Text = name;
            rtbDescription.Text = description;
            numPeople.Value = neededpeople;
            this.previousForm = form;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if(tbxName.Text == "Name" || tbxName.Text == "")
            {
                MessageBox.Show("Please, input name");
                return;
            }
            if (rtbDescription.Text == "Description" || rtbDescription.Text == "")
            {
                MessageBox.Show("Please, input description");
                return;
            }
            if (MessageBox.Show("Do you really want to edit this department?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string name = tbxName.Text;
                string description = rtbDescription.Text;
                int neededpeople = Convert.ToInt32(numPeople.Value);
                foreach (Department dep in Department.GetAllDepartments())
                {
                    if (dep.DepartmentId == depId)
                    {
                        dep.EditDepartment(name, description, neededpeople);
                    }
                }
                this.Close();
                previousForm.UpdateGUI();
            } 
        }

        private void tbxName_Enter(object sender, EventArgs e)
        {
            if (tbxName.Text == "Name")
            {
                tbxName.Text = "";
            }
        }

        private void tbxName_Leave(object sender, EventArgs e)
        {
            if (tbxName.Text == "")
            {
                tbxName.Text = "Name";
            }
        }

        private void rtbDescription_Enter(object sender, EventArgs e)
        {
            if (rtbDescription.Text == "Description")
            {
                rtbDescription.Text = "";
            }
        }

        private void rtbDescription_Leave(object sender, EventArgs e)
        {
            if (rtbDescription.Text == "")
            {
                rtbDescription.Text = "Description";
            }
        }
    }
}
