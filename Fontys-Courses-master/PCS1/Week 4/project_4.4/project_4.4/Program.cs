using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            BankAccount acc = new BankAccount();

            Console.Write("Enter your first name: ");
            client.FirstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            client.LastName = Console.ReadLine();
            Console.Write("Enter year of birth: ");
            client.BirthYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month of birth: ");
            client.BirthMonth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter day of birth: ");
            client.BirthDay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(client.ShowClientOverview());

            Console.Write("Choose an bank account: 1 / 2 [checkings account / savings account] ");
            int chooseid = Convert.ToInt32(Console.ReadLine());
            string choice = "";
           
            while (choice != "e" && (choice == "d" || choice == "w") && chooseid != 0 || choice == "") {
                if (choice == "")
                {
                    Console.Write("\nChoose an option: Deposit / Withdraw / Switch account / Exit [ d / w / n / e ] ");
                    choice = Console.ReadLine();
                }
                if (chooseid == 1)
                {
                    while (choice == "d")
                    {
                        Console.Write("\nEnter amount for deposit: ");
                        client.DepositCheckings(Convert.ToDecimal(Console.ReadLine()));
                        Console.WriteLine("Balance: {0}", client.CheckingsAccount.Balance);
                        Console.WriteLine("\nSavings Account: {0}", client.SavingsAccount.Balance);
                        choice = "";
                    }
                while (choice == "w")
                {
                    Console.Write("\nEnter amount for withdrawal: ");
                    client.WithdrawCheckings(Convert.ToDecimal(Console.ReadLine()));
                    Console.WriteLine("Balance: {0}", client.CheckingsAccount.Balance);
                        Console.WriteLine("\nSavings Account: {0}", client.SavingsAccount.Balance);
                        choice = "";
                    }
                while (choice == "n")
                {
                        Console.Write("Choose an bank account: 1 / 2 [checkings account / savings account] ");
                        chooseid = Convert.ToInt32(Console.ReadLine());
                        choice = "";
                }
            }
                else if (chooseid == 2)
                {
                    }
                    while (choice == "d")
                    {
                        Console.Write("\nEnter amount for deposit: ");
                        client.DepositToSavings(Convert.ToDecimal(Console.ReadLine()));
                        Console.WriteLine("Balance: {0}", client.SavingsAccount.Balance);
                    Console.WriteLine("\nCheckings Account: {0}", client.CheckingsAccount.Balance);
                    choice = "";
                }
                    while (choice == "w")
                    {
                        Console.Write("\nEnter amount for withdrawal: ");
                        client.WithdrawFromSavings(Convert.ToDecimal(Console.ReadLine()));
                        Console.WriteLine("Balance: {0}", client.SavingsAccount.Balance);
                    Console.WriteLine("\nCheckings Account: {0}", client.CheckingsAccount.Balance);
                    choice = "";
                }
                while (choice == "n")
                {
                    Console.Write("Choose an bank account: 1 / 2 [checkings account / savings account] ");
                    chooseid = Convert.ToInt32(Console.ReadLine());
                    choice = "";
                }
            }
            }
        }
    }
