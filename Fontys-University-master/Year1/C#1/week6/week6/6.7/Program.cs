using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._7
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal balance, change;

            Console.Write("Enter the starting balance on yout bank account: ");
            balance = int.Parse(Console.ReadLine());

            Console.WriteLine();
            
            do
            {
                Console.Write("Enter income or expense: ");
                change = int.Parse(Console.ReadLine());

                if(change * -1 > balance)
                {
                    Console.WriteLine("You too poor boy");
                }
                else
                {
                    balance += change;

                    Console.WriteLine("Current balance is: {0}", balance);
                }

                Console.WriteLine();
            }
            while (change != 0);

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
