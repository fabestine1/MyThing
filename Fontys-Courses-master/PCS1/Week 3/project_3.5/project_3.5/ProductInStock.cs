using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3._5
{
    class ProductInStock
    {
        public string productName;
        public double price;
        public int quantity;

        public void SellOneProduct()
        {
            quantity -= 1;
        }
        public void SetDiscountPrice()
        {
            if (price >= 10)
            {
                price = price - price * 0.1;
            }
        }
    }
}
