using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInStock
{
    class ProductInStock
    {
        private double _price;
        private int _quanity;

        public ProductInStock()
        {

        }

        public ProductInStock(string productName, double productPrice, int productQuanity)
        {
            this.Name = productName;
            this.Price = productPrice;
            this._quanity = productQuanity;
        }

        public string Name { get; set; }

        public double Price
        {
            get
            {
                return this._price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price can NOT be negative");
                }
                this._price = value;
            }
        }

        public int Quanity
        {
            get
            {
                return this._quanity;
            }
            set
            {
                if (value < 0) { throw new ArgumentOutOfRangeException("Price can NOT be negative"); }
                this._quanity = value;
            }
        }

        public double SetDiscountPrice(double dis = 10, double temp = 0)
        {
            if (this._price > 10)
            {
                temp = this._price / dis;
                this._price -= temp;
                return this._price;
            }
                else
                {
                    return this._price;
                }
        }

        public int SellOneProduct(int dec = 1)
        {
            if (_quanity == 9)
            {
                SetDiscountPrice();
                this._quanity -= dec;
                return this._quanity;
            }

            this._quanity -= dec;
            return this._quanity;

        }
    }
}
