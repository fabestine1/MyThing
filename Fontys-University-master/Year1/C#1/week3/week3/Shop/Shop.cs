using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    using ProductInStock;

    class Shop
    {
        static void Main(string[] args)
        {
            int amountSofa, amountChair, amountTable;

            double totalPrice = 0;

            ProductInStock sofa = new ProductInStock("sofa", 1500, 15);
            ProductInStock chair = new ProductInStock("chair", 90, 20);
            ProductInStock table = new ProductInStock("table", 150, 10);

            Console.Write("Enter the amound of {0}'s you want to buy(there are only {1} {0}'s left): ", sofa.Name, sofa.Quanity, sofa.Price);

            amountSofa = int.Parse(Console.ReadLine());

            Console.Write("Enter the amound of {0}'s you want to buy(there are only {1} {0}'s left): ", chair.Name, chair.Quanity, chair.Price);

            amountChair = int.Parse(Console.ReadLine());

            Console.Write("Enter the amound of {0}'s you want to buy(there are only {1} {0}'s left): ", table.Name, table.Quanity, table.Price);

            amountTable = int.Parse(Console.ReadLine());

            if (amountSofa > sofa.Quanity && amountChair > chair.Quanity && amountTable > table.Quanity)
            {
                Console.WriteLine("Out of stock");
            }
                else
                {
                    for (int i = 0; i < amountSofa; i++)
                    {
                        sofa.SellOneProduct();

                        Console.WriteLine("{0}'s price is {1} and {2} {3}'s are left", sofa.Name, sofa.Price, sofa.Quanity, sofa.Name);

                        totalPrice += sofa.Price;

                        Console.WriteLine("Total price is: {0}", totalPrice);
                    }

                    for (int i = 0; i < amountChair; i++)
                    {
                        chair.SellOneProduct();

                        Console.WriteLine("{0}'s price is {1} and {2} {3}'s are left", chair.Name, chair.Price, chair.Quanity, chair.Name);

                        totalPrice += chair.Price;

                        Console.WriteLine("Total price is: {0}", totalPrice);
                    }

                    for (int i = 0; i < amountTable; i++)
                    {
                        table.SellOneProduct();

                        Console.WriteLine("{0}'s price is {1} and {2} {3}'s are left", table.Name, table.Price, table.Quanity, table.Name);

                        totalPrice += table.Price;

                        Console.WriteLine("Total price is: {0}", totalPrice);
                    }
                }

            Console.WriteLine("At the end, the total price is: {0}", totalPrice);

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
