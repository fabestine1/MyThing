namespace WebShopClient
{
    partial class Form1
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
            this.GetWebShopNameBtn = new System.Windows.Forms.Button();
            this.GetProductListBtn = new System.Windows.Forms.Button();
            this.GetProductInfoBtn = new System.Windows.Forms.Button();
            this.BuyProductBtn = new System.Windows.Forms.Button();
            this.NameLable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetWebShopNameBtn
            // 
            this.GetWebShopNameBtn.Location = new System.Drawing.Point(72, 19);
            this.GetWebShopNameBtn.Name = "GetWebShopNameBtn";
            this.GetWebShopNameBtn.Size = new System.Drawing.Size(170, 37);
            this.GetWebShopNameBtn.TabIndex = 0;
            this.GetWebShopNameBtn.Text = "Get WebShop Name";
            this.GetWebShopNameBtn.UseVisualStyleBackColor = true;
            this.GetWebShopNameBtn.Click += new System.EventHandler(this.GetWebShopNameBtn_Click);
            // 
            // GetProductListBtn
            // 
            this.GetProductListBtn.Location = new System.Drawing.Point(72, 74);
            this.GetProductListBtn.Name = "GetProductListBtn";
            this.GetProductListBtn.Size = new System.Drawing.Size(170, 42);
            this.GetProductListBtn.TabIndex = 1;
            this.GetProductListBtn.Text = "Get Product List";
            this.GetProductListBtn.UseVisualStyleBackColor = true;
            this.GetProductListBtn.Click += new System.EventHandler(this.GetProductListBtn_Click);
            // 
            // GetProductInfoBtn
            // 
            this.GetProductInfoBtn.Location = new System.Drawing.Point(72, 134);
            this.GetProductInfoBtn.Name = "GetProductInfoBtn";
            this.GetProductInfoBtn.Size = new System.Drawing.Size(170, 44);
            this.GetProductInfoBtn.TabIndex = 2;
            this.GetProductInfoBtn.Text = "Get Product Info";
            this.GetProductInfoBtn.UseVisualStyleBackColor = true;
            this.GetProductInfoBtn.Click += new System.EventHandler(this.GetProductInfoBtn_Click);
            // 
            // BuyProductBtn
            // 
            this.BuyProductBtn.Location = new System.Drawing.Point(72, 222);
            this.BuyProductBtn.Name = "BuyProductBtn";
            this.BuyProductBtn.Size = new System.Drawing.Size(170, 42);
            this.BuyProductBtn.TabIndex = 3;
            this.BuyProductBtn.Text = "Buy Product";
            this.BuyProductBtn.UseVisualStyleBackColor = true;
            this.BuyProductBtn.Click += new System.EventHandler(this.BuyProductBtn_Click);
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Location = new System.Drawing.Point(405, 19);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(115, 17);
            this.NameLable.TabIndex = 6;
            this.NameLable.Text = "Web Shop Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Product Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stock";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(282, 116);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 148);
            this.listBox1.TabIndex = 10;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(408, 116);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 148);
            this.listBox2.TabIndex = 11;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(540, 116);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 148);
            this.listBox3.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Number of clinets: ";
            // 
            // btnNumber
            // 
            this.btnNumber.AutoSize = true;
            this.btnNumber.Location = new System.Drawing.Point(405, 56);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(34, 17);
            this.btnNumber.TabIndex = 14;
            this.btnNumber.Text = "Nub";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 314);
            this.Controls.Add(this.btnNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameLable);
            this.Controls.Add(this.BuyProductBtn);
            this.Controls.Add(this.GetProductInfoBtn);
            this.Controls.Add(this.GetProductListBtn);
            this.Controls.Add(this.GetWebShopNameBtn);
            this.Name = "Form1";
            this.Text = "WebShopClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetWebShopNameBtn;
        private System.Windows.Forms.Button GetProductListBtn;
        private System.Windows.Forms.Button GetProductInfoBtn;
        private System.Windows.Forms.Button BuyProductBtn;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btnNumber;
    }
}

