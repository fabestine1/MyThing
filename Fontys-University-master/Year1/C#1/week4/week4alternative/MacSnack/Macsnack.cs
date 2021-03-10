using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacSnack
{
    class MacSnack
    {
        static void Main(string[] args)
        {
            int wingsBought, saladBought, burgersBought;
            double priceWings, priceSalad, priceBurger, totalPrice;

            Snack wings = new Snack("Wings", false, 40, 4.25);
            Snack salad = new Snack("Salad", true, 10, 1.50);
            Snack burger = new Snack("Burger", false, 100, 5);

            Console.WriteLine(wings.Info());
            Console.WriteLine(salad.Info());
            Console.WriteLine(burger.Info());

            Console.Write("Enter how many wings you want to buy: ");
            wingsBought = int.Parse(Console.ReadLine());

            Console.Write("Enter how many salad you want to buy: ");
            saladBought = int.Parse(Console.ReadLine());

            Console.Write("Enter how many burgers you want to buy: ");
            burgersBought = int.Parse(Console.ReadLine());

            priceWings = wings.Price(wingsBought);
            priceSalad = salad.Price(saladBought);
            priceBurger = burger.Price(burgersBought);

            totalPrice = priceWings + priceSalad + priceBurger;

            Console.WriteLine();
            
            Console.WriteLine("You ordered: {0} wings, {1} salad, {2} burgers and the total price is {3}"
                , wingsBought, saladBought, burgersBought, totalPrice);

            wings.Bought(wingsBought);
            salad.Bought(saladBought);
            burger.Bought(burgersBought);

            Console.WriteLine();

            Console.WriteLine(wings.Info());
            Console.WriteLine(salad.Info());
            Console.WriteLine(burger.Info());

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
