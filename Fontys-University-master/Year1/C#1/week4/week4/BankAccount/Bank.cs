using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Bank
    {
        static void Main(string[] args)
        {
           /* int birthDay, birthMonth, birthYear;

            Console.Write("Enter your birth date({birthday} {birthmonth} {birthyear}): ");

            birthDay = int.Parse(Console.ReadLine());
            birthMonth = int.Parse(Console.ReadLine());
            birthYear = int.Parse(Console.ReadLine());*/

            DateTime birthDate = new DateTime();

            BankAccount myCheckingsAccount = new BankAccount(25, 150);

            BankAccount mySavingsAccount = new BankAccount(26, 2000);

            Client David = new Client("David", "Stanislavov", birthDate, myCheckingsAccount, mySavingsAccount);

            David.ShowClientOverview();

            David.CheckingsDeposit(50);

            David.ShowClientOverview();

            David.CheckingsWithdraw(180);

            David.SavingsDeposit(180);

            David.ShowClientOverview();

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
