using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaShopRevisited
{
    public partial class StatisticsForm : Form
    {
        List<Customer> customers;
        OrdersHandler ordersHandler;
        public StatisticsForm(List<Customer> customers, OrdersHandler ordersHandler)
        {
            InitializeComponent();
            this.ordersHandler = ordersHandler;
            this.customers = customers;
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            lblTotalRevenue.Text = $"Total revenue: €{ordersHandler.GetRevenue():f2}";
            var orders = ordersHandler.GetOrders();
            var sortedOrders = orders.OrderByDescending(o => o.GetOrderTotalCost()).ToList();
            for (int i = 0; i < sortedOrders.Count; i++)
            {
                var currentOrder = sortedOrders[i];
                lbxOrders.Items.Add($"ID:{currentOrder.GetOrderId()}, {currentOrder.GetCustomerName()}, {currentOrder.GetTimestamp()}, Total price : €{currentOrder.GetOrderTotalCost():f2}");
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            var totalRevenueForTheDay = 0.0d;
            try
            {
                var date = DateTime.Parse(dtpDate.Text).ToString("MM/dd/yyyy");
                var orders = ordersHandler.GetOrders();
                for (int i = 0; i < orders.Count; i++)
                {
                    if (orders[i].GetRawTime() == date)
                    {
                        totalRevenueForTheDay += orders[i].GetOrderTotalCost();
                    }
                }
                if (totalRevenueForTheDay == 0.0)
                {
                    MessageBox.Show("There is no data for the current day!");
                    lblCurrentDay.Text = $"Revenue for that day: €0.00";
                }
                else
                {
                    lblCurrentDay.Text = $"Revenue for that day: €{totalRevenueForTheDay:f2}";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect date!");
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }
    }
}
