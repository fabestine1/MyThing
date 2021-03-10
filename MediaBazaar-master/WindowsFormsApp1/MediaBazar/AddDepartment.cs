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
                MessageBox.Show("Enter Stock name");
                return;
            }

            if (numPeople.Value < 1)
            {
                MessageBox.Show("Enter employees quantity");
                return;
            }

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
}
