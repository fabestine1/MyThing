using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2._5
{
    class Client
    {
        private BankAccount checkingAccount = new BankAccount(1, 0);
        private BankAccount savingAccount = new BankAccount(2, 0);
        private DateTime birthDate;
        public string Name { get; set; }

        public Client(string newName, DateTime newBirthDate)
        {
            Name = newName;
            birthDate = newBirthDate;
        }

        public void DepositCheckings(decimal amount)
        {
            checkingAccount.Deposit(amount);
        }
        public void WithDrawCheckings(decimal amount)
        {
            checkingAccount.Withdraw(amount);
        }
        public void DepositSavings(decimal amount)
        {
            savingAccount.Deposit(amount);
        }
        public void WithDrawSAvings(decimal amount)
        {
            savingAccount.Withdraw(amount);
        }
        public string ShowClientOverview()
        {
            return "Client name: " + Name + ",Birth date: " + birthDate + ",Savings account:,\tAccount number: " + savingAccount.AccountNr + ",\tBalance: " + savingAccount.Balance + ",Checkings account:,\tAccount number: " + checkingAccount.AccountNr + ",\tBalance: " + checkingAccount.Balance + ",Total Balance: " + (savingAccount.Balance + checkingAccount.Balance);
        }
    }
}
