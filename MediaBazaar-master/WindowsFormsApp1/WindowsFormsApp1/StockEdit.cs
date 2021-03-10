using System;
using System.Windows.Forms;

namespace MediaBazar
{
    public partial class StockEdit : Form
    {
        int id;
        Stock s;

        public StockEdit(int id)
        {
            this.id = id;
            InitializeComponent();
            s = Stock.GetStockById(id);
            populateForm(s);
        }

        private void populateForm(Stock s)
        {
            stocksEditNameTbx.Text = s.Name;
            pricePerItemTbx.Value = s.Price;
            depoQuantityStock.Value = s.QuantityInDepot;
            storeQuantityStock.Value = s.QuantityInStore;
            idLbl.Text = s.Id.ToString();
            DepartmentLbl.Text = Department.GetDepartmentById(s.DepartmentId).Name;
        }

        private void editStockBttn_Click(object sender, EventArgs e)
        {
            if(stocksEditNameTbx.Text == "Name" || stocksEditNameTbx.Text == "")
            {
                MessageBox.Show("Please enter a valid stock name");
                return;
            }
            if (pricePerItemTbx.Value == 0)
            {
                MessageBox.Show("Please enter a valid stock price");
                return;
            }
            if (storeQuantityStock.Value == 0 && depoQuantityStock.Value == 0)
            {
                MessageBox.Show("Please enter a valid stock quantity");
                return;
            }
            if (MessageBox.Show("Do you really want to edit that stock?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Stock.EditStock(this.id, stocksEditNameTbx.Text, pricePerItemTbx.Value, storeQuantityStock.Value, depoQuantityStock.Value);
                this.Hide();
            }
        }

        private void stocksEditNameTbx_Enter(object sender, EventArgs e)
        {
            if (stocksEditNameTbx.Text == "Name")
            {
                stocksEditNameTbx.Text = "";
            }
        }

        private void stocksEditNameTbx_Leave(object sender, EventArgs e)
        {
            if (stocksEditNameTbx.Text == "")
            {
                stocksEditNameTbx.Text = "Name";
            }
        }
    }
}
