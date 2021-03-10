using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2._4_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Account number: ");
            int accountnr = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter balance for account 1: ");
            decimal balance = Convert.ToDecimal(Console.ReadLine());
            BankAccounts ba = new BankAccounts(accountnr, balance, name);
            Console.Write("Enter balance for account 2: ");
            balance = Convert.ToDecimal(Console.ReadLine());
            BankAccounts ba2 = new BankAccounts(accountnr, balance, name);
            Console.Write("Enter balance for account 3: ");
            balance = Convert.ToDecimal(Console.ReadLine());
            BankAccounts ba3 = new BankAccounts(accountnr, balance, name);
            Console.Write("Choose an account [1/2/3]: ");
            int account = Convert.ToInt32(Console.ReadLine());
            while (account >= 1 && account <= 3)
            {
                Console.Write("Choose an action: Deposit / Withdraw [d/w]: ");
                char choice = Convert.ToChar(Console.ReadLine());
                while (choice == 'd' || choice == 'w')
                {
                    decimal amount;
                    Console.Write("Enter amount: ");
                    amount = Convert.ToDecimal(Console.ReadLine());
                    if (choice == 'd')
                    {
                        switch (account)
                        {
                            case 1:
                                ba.Deposit(amount);
                                break;
                            case 2:
                                ba2.Deposit(amount);
                                break;
                            case 3:
                                ba3.Deposit(amount);
                                break;
                        }
                    }
                    else if (choice == 'w')
                    {
                        switch (account)
                        {
                            case 1:
                                ba.Withdraw(amount);
                                break;
                            case 2:
                                ba2.Withdraw(amount);
                                break;
                            case 3:
                                ba3.Withdraw(amount);
                                break;
                        }
                    }
                    Console.WriteLine("Current balance:\nAccount 1: {0}\nAccount 2: {1}\nAccount 3: {2}", ba.Balance, ba2.Balance, ba3.Balance);
                    Console.Write("Choose an account [1/2/3]: ");
                    account = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Choose an action: Deposit / Withdraw [d/w]: ");
                    choice = Convert.ToChar(Console.ReadLine());
                }
            }
        }
    }
}
