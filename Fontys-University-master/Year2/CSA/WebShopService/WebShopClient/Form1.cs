namespace WebShopClient
{
    using src;
    using System;
    using System.ServiceModel;
    using System.Windows.Forms;

    public partial class Form1 : Form, IWebshopCallback
    {
        private InstanceContext instanceContext;
        private WebshopClient proxy;

        public Form1()
        {
            this.InitializeComponent();

            this.instanceContext = new InstanceContext(this);
            this.proxy = new WebshopClient(this.instanceContext);
            
            this.proxy.connectClient();
        }

        private void GetWebShopNameBtn_Click(object sender, EventArgs e)
        {
            this.NameLable.Text = this.proxy.GetWebShopName();
        }

        private void GetProductListBtn_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();
            this.listBox3.Items.Clear();

            var listOdProducts = this.proxy.GetProductList();

            foreach (var listOdProduct in listOdProducts)
            {
                this.listBox1.Items.Add(listOdProduct.ProductId);
            }

            foreach (var listOdProduct in listOdProducts)
            {
                this.listBox2.Items.Add(listOdProduct.Price);
            }

            foreach (var listOdProduct in listOdProducts)
            {
                this.listBox3.Items.Add(listOdProduct.Stock);
            }
        }

        private void GetProductInfoBtn_Click(object sender, EventArgs e)
        {
        }

        private void BuyProductBtn_Click(object sender, EventArgs e)
        {
            var id = this.listBox1.SelectedItem.ToString();
            var BoughtProduct = this.proxy.BuyProduct(id);
            var listProducts = this.proxy.GetProductList();

            if (BoughtProduct)
            {
                foreach (var listProduct in listProducts)
                {
                    if (listProduct.ProductId == id)
                    {
                        this.listBox3.Items[this.listBox1.SelectedIndex] = listProduct.Stock;
                    }
                }

                MessageBox.Show("Product Successfully Bought!");
                return;
            }

            MessageBox.Show("Out of Stock!");
        }

        public void newClientConnected(int numberOfConnectedClients)
        {
            this.btnNumber.Text = numberOfConnectedClients.ToString();
        }

        public void productSold(Item product)
        {
            var index = this.listBox1.Items.IndexOf(product.ProductId);
            this.listBox3.Items[index] = product.Stock;
        }

        public void notifyOrderShipped(Order order)
        {
            MessageBox.Show("Your order was shipped " + order.ProductId);
        }
    }
}
