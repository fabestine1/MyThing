using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazar
{
    
    public partial class AddDepartment : Form
    {
        MainForm form;
        Department department;

        public AddDepartment(MainForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void addDepartmentbttn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbxName.Text))
            {
                MessageBox.Show("Enter department name");
                return;
            }
            if(tbxName.Text == "Name")
            {
                MessageBox.Show("Enter department name");
                return;
            }
            if (rtbDescription.Text == "Description" || rtbDescription.Text == "Description")
            {
                MessageBox.Show("Enter department description");
                return;
            }

            if (numPeople.Value < 1)
            {
                MessageBox.Show("Enter employees quantity");
                return;
            }
            if (MessageBox.Show("Do you really want to create this department?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int neededpeople = Convert.ToInt32(numPeople.Value);
                string description = rtbDescription.Text;
                if (String.IsNullOrWhiteSpace(description))
                {
                    department = new Department(tbxName.Text, null, neededpeople);
                    this.Hide();
                }
                else
                {
                    department = new Department(tbxName.Text, description, neededpeople);
                    this.Hide();
                }
                form.UpdateGUI();
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
