using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
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

                }
                else
                {
                    this._firstName = value;
                }
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

                }
                else
                {
                    this._lastName = value;
                }
            }
        }

        public decimal CheckingsDeposit(decimal deposit)
        {
            this.CheckingsAccount.Deposit(deposit);
            return this.CheckingsAccount.Balance;
        }

        public decimal CheckingsWithdraw(decimal deposit)
        {
            this.CheckingsAccount.Withdraw(deposit);
            return this.CheckingsAccount.Balance;
        }

        public decimal SavingsDeposit(decimal deposit)
        {
            this.SavingsAccount.Deposit(deposit);
            return this.SavingsAccount.Balance;
        }

        public decimal SavingsWithdraw(decimal deposit)
        {
            this.SavingsAccount.Withdraw(deposit);
            return this.SavingsAccount.Balance;
        }

        public String ShowClientOverview()
        {
            String info;

            info = "Client name: " + this.FirstName + "Birth date: " + this.BirthDate +
                "Savings account:" +
                "Account number: " + this.SavingsAccount.AccountNumber +
                "Balance: " + this.SavingsAccount.Balance +
                "Checkings account:" +
                "Account number: " + this.CheckingsAccount.AccountNumber +
                "nBalance: " + this.CheckingsAccount.Balance +
                "Total Balance: " + (this.CheckingsAccount.Balance + this.SavingsAccount.Balance);

            return info;
        }

    }
}
