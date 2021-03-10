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
    public partial class RequestStock : Form
    {
        public RequestStock()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            PopulateStocks(Stock.GetAllStocks());
        }

        private void PopulateStocks(List<Stock> stocks)
        {
            foreach (Stock s in stocks) 
                requestStockStocksCmbbx.Items.Add(new StocksComboBoxItem(s));
        }

        private void requestStockBttn_Click(object sender, EventArgs e)
        {
            if (requestStockQtty.Value < 1)
            {
                MessageBox.Show("Enter quantity");
                return;
            }

            if (requestStockStocksCmbbx.SelectedIndex == -1)
            {
                MessageBox.Show("Select stock");
                return;
            }

            int quantity = (int)requestStockQtty.Value;
            int stock_id = ((StocksComboBoxItem)requestStockStocksCmbbx.SelectedItem).Id;

            StockRequest.CreateStockRequest(stock_id, quantity);
            this.Hide();
        }
    }
}