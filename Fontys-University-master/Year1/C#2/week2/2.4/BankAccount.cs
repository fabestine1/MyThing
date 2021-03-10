using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankAccount
    {
        private int _accountNumber;
        private decimal _balance;

        public BankAccount()
        {

        }

        public BankAccount(int accountNumber, decimal balance)
        {
            this.AccountNumber = accountNumber;
            this.Balance = balance;
        }

        public int AccountNumber
        {
            get
            {
                return this._accountNumber;
            }

            private set
            {
                if (value < 0)
                {

                }
                else
                {
                    this._accountNumber = value;
                }
            }
        }

        public decimal Balance
        {
            get
            {
                return this._balance;
            }

            private set
            {
                if (value < 0)
                {

                }
                else
                {
                    this._balance = value;
                }
            }
        }

        public decimal Deposit(decimal deposit)
        {
            Balance += deposit;
            return this.Balance;
        }

        public decimal Withdraw(decimal withdraw)
        {
            Balance -= withdraw;
            return this.Balance;
        }
    }
}
