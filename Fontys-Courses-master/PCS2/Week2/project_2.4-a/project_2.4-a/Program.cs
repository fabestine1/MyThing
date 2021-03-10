using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2._4_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Account number: ");
            int accountnr = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter balance: ");
            decimal balance = Convert.ToDecimal(Console.ReadLine());
            BankAccounts ba = new BankAccounts(accountnr, balance, name);
            Console.Write("Choose an action: Deposit / Withdraw [d/w]: ");
            char choice = Convert.ToChar(Console.ReadLine());
            while (choice == 'd' || choice == 'w')
            {
                decimal amount;
                Console.Write("Enter amount: ");
                amount = Convert.ToDecimal(Console.ReadLine());
                if (choice == 'd')
                {
                    ba.Deposit(amount);
                }
                else if (choice == 'w')
                {
                    ba.Withdraw(amount);
                }
                Console.WriteLine("Current balance: {0}", ba.Balance);
                Console.Write("Choose an action: Deposit / Withdraw [d/w]: ");
                choice = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
