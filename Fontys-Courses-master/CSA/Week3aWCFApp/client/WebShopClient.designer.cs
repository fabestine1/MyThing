namespace client
{
    partial class WebShopClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebShopClient));
            this.btnGetWebShopName = new System.Windows.Forms.Button();
            this.btnGetProductList = new System.Windows.Forms.Button();
            this.btnGetProductInfo = new System.Windows.Forms.Button();
            this.btnBuyProduct = new System.Windows.Forms.Button();
            this.lblNotifications = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lbIds = new System.Windows.Forms.ListBox();
            this.lbPrices = new System.Windows.Forms.ListBox();
            this.lbStocks = new System.Windows.Forms.ListBox();
            this.lblConnectedClients = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetWebShopName
            // 
            resources.ApplyResources(this.btnGetWebShopName, "btnGetWebShopName");
            this.btnGetWebShopName.Name = "btnGetWebShopName";
            this.btnGetWebShopName.UseVisualStyleBackColor = true;
            this.btnGetWebShopName.Click += new System.EventHandler(this.btnGetWebShopName_Click);
            // 
            // btnGetProductList
            // 
            resources.ApplyResources(this.btnGetProductList, "btnGetProductList");
            this.btnGetProductList.Name = "btnGetProductList";
            this.btnGetProductList.UseVisualStyleBackColor = true;
            this.btnGetProductList.Click += new System.EventHandler(this.btnGetProductList_Click);
            // 
            // btnGetProductInfo
            // 
            resources.ApplyResources(this.btnGetProductInfo, "btnGetProductInfo");
            this.btnGetProductInfo.Name = "btnGetProductInfo";
            this.btnGetProductInfo.UseVisualStyleBackColor = true;
            this.btnGetProductInfo.Click += new System.EventHandler(this.btnGetProductInfo_Click);
            // 
            // btnBuyProduct
            // 
            resources.ApplyResources(this.btnBuyProduct, "btnBuyProduct");
            this.btnBuyProduct.Name = "btnBuyProduct";
            this.btnBuyProduct.UseVisualStyleBackColor = true;
            this.btnBuyProduct.Click += new System.EventHandler(this.btnBuyProduct_Click);
            // 
            // lblNotifications
            // 
            this.lblNotifications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lblNotifications, "lblNotifications");
            this.lblNotifications.Name = "lblNotifications";
            // 
            // lblID
            // 
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lblID, "lblID");
            this.lblID.Name = "lblID";
            // 
            // lblPrice
            // 
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lblPrice, "lblPrice");
            this.lblPrice.Name = "lblPrice";
            // 
            // lblStock
            // 
            this.lblStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lblStock, "lblStock");
            this.lblStock.Name = "lblStock";
            // 
            // lbIds
            // 
            this.lbIds.FormattingEnabled = true;
            resources.ApplyResources(this.lbIds, "lbIds");
            this.lbIds.Name = "lbIds";
            // 
            // lbPrices
            // 
            this.lbPrices.FormattingEnabled = true;
            resources.ApplyResources(this.lbPrices, "lbPrices");
            this.lbPrices.Name = "lbPrices";
            // 
            // lbStocks
            // 
            this.lbStocks.FormattingEnabled = true;
            resources.ApplyResources(this.lbStocks, "lbStocks");
            this.lbStocks.Name = "lbStocks";
            // 
            // lblConnectedClients
            // 
            resources.ApplyResources(this.lblConnectedClients, "lblConnectedClients");
            this.lblConnectedClients.Name = "lblConnectedClients";
            // 
            // WebShopClient
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblConnectedClients);
            this.Controls.Add(this.lbStocks);
            this.Controls.Add(this.lbPrices);
            this.Controls.Add(this.lbIds);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblNotifications);
            this.Controls.Add(this.btnBuyProduct);
            this.Controls.Add(this.btnGetProductInfo);
            this.Controls.Add(this.btnGetProductList);
            this.Controls.Add(this.btnGetWebShopName);
            this.Name = "WebShopClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetWebShopName;
        private System.Windows.Forms.Button btnGetProductList;
        private System.Windows.Forms.Button btnGetProductInfo;
        private System.Windows.Forms.Button btnBuyProduct;
        private System.Windows.Forms.Label lblNotifications;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.ListBox lbIds;
        private System.Windows.Forms.ListBox lbPrices;
        private System.Windows.Forms.ListBox lbStocks;
        private System.Windows.Forms.Label lblConnectedClients;
    }
}

