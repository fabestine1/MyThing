using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double euros = -1;
            double eurocents = -1;
            while (euros < 0)
            {
                Console.Write("Enter euros: ");
                euros = Convert.ToInt32(Console.ReadLine());
            }
            while (eurocents < 0)
            {
                Console.Write("Enter eurocents: ");
                eurocents = Convert.ToInt32(Console.ReadLine());
            }
            double value = (euros * 100 + eurocents)/100;
            Console.WriteLine("\nMinimizing the coins:");
            double in2coins = value / 2;
            Console.WriteLine("2 euro coins:                {0}", (int) in2coins);
            double in2coinsRemainder = value - (int) in2coins * 2;
            double in1coins = in2coinsRemainder / 1;
            Console.WriteLine("1 euro coins:                {0}", (int)in1coins);
            double in50eurocentCoinsRemainder = in2coinsRemainder % 1;
            double in50eurocentCoins = in50eurocentCoinsRemainder / 0.50;
            Console.WriteLine("50 eurocent coins:           {0}", (int)in50eurocentCoins);
            double in20eurocentCoinsRemainder = in50eurocentCoinsRemainder % 0.50;
            double in20eurocentCoins = in20eurocentCoinsRemainder / 0.20;
            Console.WriteLine("20 eurocent coins:           {0}", (int)in20eurocentCoins);
            double in10eurocentCoinsRemainder = in20eurocentCoinsRemainder % 0.20;
            double in10eurocentCoins = in10eurocentCoinsRemainder / 0.10;
            Console.WriteLine("10 eurocent coins:           {0}", (int)in10eurocentCoins);
            double in5eurocentCoinsRemainder = in10eurocentCoinsRemainder % 0.10;
            double in5eurocentCoins = in5eurocentCoinsRemainder / 0.05;
            Console.WriteLine("5 eurocent coins:            {0}", (int)in5eurocentCoins);
            double in2eurocentCoinsRemainder = in5eurocentCoinsRemainder % 0.05;
            double in2eurocentCoins = in2eurocentCoinsRemainder / 0.02;
            Console.WriteLine("2 eurocent coins:            {0}", (int)in2eurocentCoins);
            double in1eurocentCoinsRemainder = in2eurocentCoinsRemainder % 0.02;
            double in1eurocentCoins = in1eurocentCoinsRemainder / 0.01;
            Console.WriteLine("1 eurocent coins:            {0}", (int)in1eurocentCoins);
            Console.ReadKey();

        }
    }
}
