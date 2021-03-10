using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaBazar
{
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            departmentsCmbbxAddingStock.Items.Clear();
            List<Department> departments = Department.GetAllDepartments();
            foreach (Department d in departments) departmentsCmbbxAddingStock.Items.Add(new DepartmentComboBoxItem(d));
        }

        private void addStockBttn_Click(object sender, EventArgs e)
        {
            int minimumValue = 1;
            if (String.IsNullOrWhiteSpace(addStockNameTbx.Text))
            {
                MessageBox.Show("Enter Stock name");
                return;
            }

            if (pricePerItemTbx.Value < minimumValue)
            {
                MessageBox.Show("Enter price");
                return;
            }

            if (indepoQuantityInput.Value < minimumValue)
            {
                MessageBox.Show("Enter depo quantity");
                return;
            }

            if (inStoreQuantityInput.Value < minimumValue)
            {
                MessageBox.Show("Enter store quantity");
                return;
            }
            if (departmentsCmbbxAddingStock.SelectedItem == null)
            {
                MessageBox.Show("Select a depratment");
                return;
            }
            if (addStockNameTbx.Text == "Name" || addStockNameTbx.Text == "")
            {
                MessageBox.Show("Input stock name");
                return;
            }
            if (descriptionTbx.Text == "Description" || descriptionTbx.Text == "")
            {
                MessageBox.Show("Input stock description");
                return;
            }
            if (MessageBox.Show("Do you really want to add that stock?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string name = addStockNameTbx.Text;
                string description = descriptionTbx.Text;
                int inDepo = (int)indepoQuantityInput.Value;
                int inStore = (int)inStoreQuantityInput.Value;
                decimal price = pricePerItemTbx.Value;

                int departmentId = ((DepartmentComboBoxItem)departmentsCmbbxAddingStock.SelectedItem).Id;
                Stock stock = new Stock(name, description, inDepo, inStore, price, departmentId);
                this.Hide();
            }
            
        }

        private void addStockNameTbx_Enter(object sender, EventArgs e)
        {
            if (addStockNameTbx.Text == "Name")
            {
                addStockNameTbx.Text = "";
            }
        }

        private void addStockNameTbx_Leave(object sender, EventArgs e)
        {
            if (addStockNameTbx.Text == "")
            {
                addStockNameTbx.Text = "Name";
            }
        }

        private void descriptionTbx_Enter(object sender, EventArgs e)
        {
            if (descriptionTbx.Text == "Description")
            {
                descriptionTbx.Text = "";
            }
        }

        private void descriptionTbx_Leave(object sender, EventArgs e)
        {
            if (descriptionTbx.Text == "")
            {
                descriptionTbx.Text = "Description";
            }
        }
    }
}
