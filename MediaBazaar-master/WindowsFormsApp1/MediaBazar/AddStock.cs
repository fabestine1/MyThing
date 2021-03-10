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
}
