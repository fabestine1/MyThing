using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_6._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("I am your financial advisor.\nI will help you calculate how much money you save or owe!\nPlease enter the starting balance of your bank account: ");
            decimal startAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter:\n\t- your incomes <as positive decimal numbers>,\n\t- expenses <as negative decimal numbers>, and\n\t- 0 <zero> to exit this program.\n");
            decimal transaction;
            do
            {
                Console.Write("Please enter an income or expense: ");
                transaction = Convert.ToDecimal(Console.ReadLine());
                    startAmount += transaction;
                    Console.WriteLine("Current balance is:\t{0}", startAmount);
                Console.WriteLine("-------------------------------------------------------------");
            }
            while (transaction != 0 && startAmount > 0);
            if (startAmount > 0)
            {
                Console.WriteLine("Congratulations, you saved {0} euros!", startAmount);
            }
            else if(startAmount == 0)
            {
                Console.WriteLine("Be careful, you spend everything you earn!");
            }
            else
            {
                Console.WriteLine("Reconsider your plans, you owe {0} euros to the bank!", startAmount - 2*startAmount);
            }
            Console.ReadKey();
        }
    }
}
