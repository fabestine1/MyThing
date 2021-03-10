using client.ServiceRef;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public partial class WebShopClient : Form, IWebshopCallback
    {
        private ServiceRef.WebshopClient proxy;
        private ServiceRef.Item[] items;
        public WebShopClient()
        {
            InitializeComponent();
            InstanceContext context = new InstanceContext(this);
            proxy = new ServiceRef.WebshopClient(context);
            proxy.connect();
        }

        private void btnGetWebShopName_Click(object sender, EventArgs e)
        {
            lblNotifications.Text = proxy.GetWebshopName();
        }

        private void btnGetProductList_Click(object sender, EventArgs e)
        {
            UpdateProductList();
        }

        private void UpdateProductList()
        {
            items = proxy.GetProductsList();
            lbIds.Items.Clear();
            lbPrices.Items.Clear();
            lbStocks.Items.Clear();
            foreach (ServiceRef.Item i in items)
            {
                lbIds.Items.Add(i.ProductId);
                lbPrices.Items.Add(i.Price);
                lbStocks.Items.Add(i.Stock);
            }
        }

        private void btnGetProductInfo_Click(object sender, EventArgs e)
        {
            if (lbIds.SelectedIndex > -1) MessageBox.Show(proxy.GetProductInfo(items[lbIds.SelectedIndex].ProductId));
        }

        private void btnBuyProduct_Click(object sender, EventArgs e)
        {
            if (lbIds.SelectedIndex > -1)
            {
                proxy.BuyProduct(items[lbIds.SelectedIndex].ProductId);
                //UpdateProductList();
            }
        }

        public void newClientConnected(int numberOfConnectedClients)
        {
            lblConnectedClients.Text = "The number of connected clients is: " + numberOfConnectedClients;
        }

        public void productSold(Item product)
        {
            UpdateProductList();
        }
    }
}
