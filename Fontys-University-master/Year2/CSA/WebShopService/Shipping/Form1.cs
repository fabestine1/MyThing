namespace Shipping
{
    using System;
    using src;
    using System.ServiceModel;
    using System.Windows.Forms;

    public partial class Form1 : Form, IShippingCallback
    {
        private InstanceContext instanceContext;
        private ShippingClient proxy;

        public Form1()
        {
            this.InitializeComponent();

            this.instanceContext = new InstanceContext(this);
            this.proxy = new ShippingClient(this.instanceContext);

            this.proxy.RegisterShippingClent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();

            var listOrders = this.proxy.GetOrderList();

            foreach (var listOrder in listOrders)
            {
                this.listBox1.Items.Add(listOrder.ProductId);
            }

            foreach (var listOrder in listOrders)
            {
                this.listBox2.Items.Add(listOrder.Moment);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var index = this.listBox1.Items[this.listBox1.SelectedIndex];

            this.proxy.ShipOrder(index.ToString());

            MessageBox.Show("The selected order was successfully removed!");
        }
        
        public void orderCreated(Order order)
        {
            this.listBox1.Items.Add(order.ProductId);
            this.listBox2.Items.Add(order.Moment);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.proxy.DeRegisterShippingClent();
        }
    }
}
