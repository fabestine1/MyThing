using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        private Zoo theZoo;
        public Form1()
        {
            InitializeComponent();
            theZoo = new Zoo("My zoo");
            this.Text = theZoo.Name + ". " + "Nikolay Nikolaev.";

            // You may use this testing-data to test your application. Rename the "theZoo" if necessary.
            theZoo.AddOrder(new Order(1, 3, 5, false, false));
            theZoo.AddOrder(new Order(2, 1, 2, true, false));
            theZoo.AddOrder(new Order(2, 2, 3, false, true));
            theZoo.AddOrder(new Order(1, 1, 0, true, true));
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order(Convert.ToInt32(nudChildren.Value), Convert.ToInt32(nudAdults.Value), Convert.ToInt32(nudSeniors.Value), cbGuide.Checked, cbLunch.Checked);
            theZoo.AddOrder(order);
            lbPrice.Text = order.GetPrice().ToString();
            lbTicketType.Text = order.GetOrderType().ToString();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            listBoxOrders.Items.Clear();
            foreach(Order order in theZoo.GetAllOrders())
            {
                listBoxOrders.Items.Add(order.AsString());
            }
        }

        private void btnShowNotCheckedIn_Click(object sender, EventArgs e)
        {
            listBoxOrders.Items.Clear();
            foreach (Order order in theZoo.GetUncheckedOrders())
            {
                listBoxOrders.Items.Add(order.AsString());
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            Order order = theZoo.GetOrder(Convert.ToInt32(tbOrderNr.Text));
            if (order != null)
            {
                if (order.IsCheckedIn)
                {
                    MessageBox.Show("Order already checked in");
                }
                else
                {
                    order.IsCheckedIn = true;
                    MessageBox.Show(order.GetExtraInfo());
                }
            }
            else
            {
                MessageBox.Show("Order not found");
            }
        }
    }
}
