using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4._4
{
    class Client
    {
        private string firstName;
        private string lastName;
        private int bY;
        private int bM;
        private int bD;
        private BankAccount checkingsAccount = new BankAccount();
        private BankAccount savingsAccount = new BankAccount();
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int BirthYear
        {
            get { return bY; }
            set { bY = value; }
        }
        public int BirthMonth
        {
            get { return bM; }
            set { bM = value; }
        }
        public int BirthDay
        {
            get { return bD; }
            set { bD = value; }
        }
        public BankAccount CheckingsAccount
        {
            get { return checkingsAccount; }
        }
        public BankAccount SavingsAccount
        {
            get { return savingsAccount; }
        }
        public void DepositCheckings(decimal amount)
        {

         CheckingsAccount.Deposit(amount);
        }
        public void WithdrawCheckings(decimal amount)
        {

            CheckingsAccount.Withdraw(amount);
        }
        public void DepositToSavings(decimal amount)
        {

            SavingsAccount.Deposit(amount);
        }
        public void WithdrawFromSavings(decimal amount)
        {

            SavingsAccount.Withdraw(amount);
        }
        public string ShowClientOverview()
        {
            string info = "Client name: " + FirstName + " " + LastName + "\nBirth date: " + BirthYear + "/" + BirthMonth + "/" + BirthDay + "\nSavings Account:\n\tAccount number: " + SavingsAccount.AccountNumber + "\n\tBalance: " + SavingsAccount.Balance + "\nCheckings Account:\n\tAccount number: " + CheckingsAccount.AccountNumber + "\n\tBalance: " + CheckingsAccount.Balance + "\nTotal Balance: " + (SavingsAccount.Balance + CheckingsAccount.Balance);
            return info;
        }
    }
}
