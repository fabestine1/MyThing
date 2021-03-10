using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._8
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

                balance += change;

                Console.WriteLine("Current balance is: {0}", balance);
                
                Console.WriteLine();
            }
            while (change != 0);

            if(balance > 0)
            {
                Console.WriteLine("Congrats, you saved {0}", balance);
            }
            else if(balance == 0)
            {
                Console.WriteLine("You waster all your money");
            }
            else
            {
                Console.WriteLine("You own {0} euros", (balance * -1));
            }

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
