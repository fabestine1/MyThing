using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double rate, amount, result;
            int choise;

            Console.Write("Enter the exchange rate <how many dollars do I get from 1 euro> : ");
            rate = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter 1 if you want to convert euros to dollars.");

            Console.WriteLine("Enter 2 if you want to convert dollars to euros.");

            Console.Write("Enter your choise now: ");

            choise = int.Parse(Console.ReadLine());

            if (choise == 1)
            {
                Console.Write("Enter the amount of euros: ");

                amount = double.Parse(Console.ReadLine());

                result = amount * rate;

                Console.WriteLine("You get {0} dollars from {1} euros.", result.ToString("#.##"), amount);
            }
            else if (choise == 2)
            {
                Console.Write("Enter the amount of dollars: ");

                amount = double.Parse(Console.ReadLine());

                result = amount / rate;

                Console.WriteLine("You get {0} euros from {1} dollars.", result.ToString("#.##"), amount);
            }
            else
            {
                Console.WriteLine("Invalid value");
            }

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
