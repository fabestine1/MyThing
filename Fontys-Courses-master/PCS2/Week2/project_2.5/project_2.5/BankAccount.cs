using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2._5
{
    class BankAccount
    {
        private int accountNr;
        private decimal balance;

        public int AccountNr
        {
            get { return accountNr; }
        }
        public decimal Balance
        {
            get { return balance; }
        }

        public BankAccount(int newAccountNr, decimal newBalance)
        {
            accountNr = newAccountNr;
            balance = newBalance;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }
        public bool Withdraw(decimal amount)
        {
            if (balance - amount >= 0)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
