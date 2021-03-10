using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Client
    {
        private String _firstName;
        private String _lastName;

        public Client(String firstName, String lastName, DateTime birthDate, BankAccount checkingsAccount, BankAccount savingsAccount)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.CheckingsAccount = checkingsAccount;
            this.SavingsAccount = savingsAccount;
        }

        public BankAccount CheckingsAccount { get; set; }
        public BankAccount SavingsAccount { get; set; }
        public DateTime BirthDate { get; set; }

        public String FirstName
        {
            get
            {
                return this._firstName;
            }

            private set
            {
                if (value == "")
                {
                    throw new ArgumentOutOfRangeException("First Name can NOT be without character");
                }

                this._firstName = value;
            }
        }
        public String LastName
        {
            get
            {
                return this._lastName;
            }

            private set
            {
                if (value == "")
                {
                    throw new ArgumentOutOfRangeException("First Name can NOT be without character");
                }

                this._lastName = value;
            }
        }

        public decimal CheckingsDeposit(decimal deposit)
        {
            CheckingsAccount.Deposit(deposit);
            return CheckingsAccount.Balance;
        }

        public decimal CheckingsWithdraw(decimal deposit)
        {
            CheckingsAccount.Withdraw(deposit);
            return CheckingsAccount.Balance;
        }

        public decimal SavingsDeposit(decimal deposit)
        {
            SavingsAccount.Deposit(deposit);
            return SavingsAccount.Balance;
        }

        public decimal SavingsWithdraw(decimal deposit)
        {
            SavingsAccount.Withdraw(deposit);
            return SavingsAccount.Balance;
        }

        public void ShowClientOverview()
        {
            Console.WriteLine("Client name: {0}", FirstName);
            Console.WriteLine("Birth date: {0}", BirthDate);
            Console.WriteLine("Savings account:");
            Console.WriteLine("     Account number: {0}", SavingsAccount.AccountNumber);
            Console.WriteLine("     Balance: {0}", SavingsAccount.Balance);
            Console.WriteLine("Checkings account:");
            Console.WriteLine("     Account number: {0}", CheckingsAccount.AccountNumber);
            Console.WriteLine("     Balance: {0}", CheckingsAccount.Balance);
            Console.WriteLine("Total Balance: {0}", (CheckingsAccount.Balance + SavingsAccount.Balance));
        }

    }
}
