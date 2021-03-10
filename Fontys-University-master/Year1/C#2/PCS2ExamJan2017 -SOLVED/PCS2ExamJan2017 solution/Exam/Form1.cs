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
        // assignment 4a
        private Zoo theZoo;
        public Form1()
        {
            InitializeComponent();
            // assignment 4a and 4b
            this.theZoo = new Zoo("Rotterdam Zoo");
            this.Text = theZoo.Name + " : Andrius Kuprys";
            // You can use this dummy data to test your application. Rename the "theZoo" if necessary.
            theZoo.AddOrder(new Order(1, 3, 5, false, false));
            theZoo.AddOrder(new Order(2, 1, 2, true, false));
            theZoo.AddOrder(new Order(2, 2, 3, false, true));
            theZoo.AddOrder(new Order(1, 1, 0, true, true));
        }

        // assignment 4c
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order(
                Convert.ToInt32(nudChilds.Value),
                Convert.ToInt32(nudAdults.Value),
                Convert.ToInt32(nudSeniors.Value),
                cbGuide.Checked, cbLunch.Checked);

            theZoo.AddOrder(order);

            lbPrice.Text = order.GetPrice().ToString();
            lbTicketType.Text = order.GetOrderType().ToString();
        }


        // assignment 4d
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            listBoxOrders.Items.Clear();
            foreach (Order o in theZoo.GetAllOrders())
            {
                listBoxOrders.Items.Add(o.AsString());
            }
        }

        // assignment 4e
        private void btnShowCheckedIn_Click(object sender, EventArgs e)
        {
            listBoxOrders.Items.Clear();
            foreach (Order o in theZoo.GetUncheckedOrders())
            {
                listBoxOrders.Items.Add(o.AsString());
            }
        }

        // assignment 4f
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            Order o = theZoo.GetOrder(Convert.ToInt32(tbOrderNr.Text));
            if (o == null)
            {  //order does not exist
                MessageBox.Show("Order not found");
            }
            else
            {   // order exist
                if ( o.IsCheckedIn == true)
                { //order o exists and is already checked in
                    MessageBox.Show("Order already checked in");
                }
                else
                { //order o exists and is not checked in yet
                    o.IsCheckedIn = true;
                    MessageBox.Show("Order is checked in, " + o.GetExtraInfo());
                }
            }
            
        }
    }
}
