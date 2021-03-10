using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = new string[5] { "sofa", "chair", "table", "bed", "wardrobe" };
            double[] price = new double[5] { 1500, 90, 150, 120, 300 };
            int[] quantity = new int[5] { 4, 20, 10, 5, 9 };
            char b = 'y';
            while (b == 'y')
            {
                Console.WriteLine("Products: ");
                foreach (var item in products)
                {
                    Console.WriteLine("{0}", item);
                }
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("\nFor {0} enter {1}.", products[i], i + 1);
                }
                Console.Write("\n\nYour choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                ProductInStock product = new ProductInStock();
                product.productName = products[choice - 1];
                product.price = price[choice - 1];
                product.quantity = quantity[choice - 1];

                if (product.quantity != 0)
                {
                    if (product.quantity < 10)
                    {
                        product.SetDiscountPrice();
                        product.SellOneProduct();
                        quantity[choice - 1] -= 1;
                    }
                    else
                    {
                        product.SellOneProduct();
                        quantity[choice - 1] -= 1;
                    }
                Console.WriteLine("Product: {0}, Price: {1}, Remaining quantity: {2}", product.productName, product.price, product.quantity);
                }
                else
                {
                    Console.WriteLine("This product is sold out!");
                }
                Console.Write("\nDo you want to buy anything else? Enter \"y\" to continue. ");
                b = Convert.ToChar(Console.ReadLine());
            }
            
        }
    }
}
