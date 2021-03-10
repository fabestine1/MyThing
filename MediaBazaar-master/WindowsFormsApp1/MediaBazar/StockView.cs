using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaBazar
{
    public partial class StockView : Form
    {
        public StockView(int workerRole)
        {
            InitializeComponent();
            PopulateDepartments(Department.GetAllDepartments());
            populateStocks(Stock.GetAllStocks());
            if (workerRole == (int)ProfileRoles.EMPLOYEE)
            {
                this.Width = 580;
            }
        }

        private void PopulateDepartments(List<Department> departments)
        {
            foreach (Department d in departments)
                departmentsCmbbxStockView.Items.Add(new DepartmentComboBoxItem(d));
        }

        private void populateStocks(List<Stock> stocks)
        {
            stocksViewLbx.Items.Clear();
            foreach (Stock s in stocks)
            {
                ListViewItem item = new ListViewItem(new[] { s.Id.ToString(), s.Name, s.Description, s.QuantityInStore.ToString(), s.QuantityInDepot.ToString(), s.Price.ToString() });
                stocksViewLbx.Items.Add(item);
            }
        }

        private void RefreshStocks()
        {
            if (departmentsCmbbxStockView.SelectedIndex > -1 || stockNameTbx.Text != "Stock name")
            {
                int departmentId = ((DepartmentComboBoxItem)departmentsCmbbxStockView.SelectedItem).Id;
                string productName = (stockNameTbx.Text != "Stock name" ? stockNameTbx.Text : null);
                List<Stock> stocks = Stock.FilterStocks(departmentId, productName);
                populateStocks(stocks);
            }
            else
            {
                populateStocks(Stock.GetAllStocks());
            }
        }

        private void removeStockBttn_Click(object sender, EventArgs e)
        {
            if (stocksViewLbx.SelectedItems.Count != 0)
            {
                int id = Convert.ToInt32(stocksViewLbx.SelectedItems[0].Text);
                Stock.Remove(id);
                RefreshStocks();
            }
            else
            {
                MessageBox.Show("Please select a stock!");
                return;
            }
        }

        private void editStockBttn_Click(object sender, EventArgs e)
        {
            if (stocksViewLbx.SelectedItems.Count != 0)
            {
                int id = Convert.ToInt32(stocksViewLbx.SelectedItems[0].Text);
                (new StockEdit(id)).Show();
            }
            else
            {
                MessageBox.Show("Please select a stock!");
                return;
            }
        }

        private void filterStocksBttn_Click(object sender, EventArgs e)
        {
            if (departmentsCmbbxStockView.SelectedIndex == -1)
            {
                MessageBox.Show("Select a stock first.");
                return;
            }

            int departmentId = ((DepartmentComboBoxItem)departmentsCmbbxStockView.SelectedItem).Id;
            string productName = (stockNameTbx.Text != "Stock name" ? stockNameTbx.Text : null);

            List<Stock> stocks = Stock.FilterStocks(departmentId, productName);
            populateStocks(stocks);
        }
    }
}
