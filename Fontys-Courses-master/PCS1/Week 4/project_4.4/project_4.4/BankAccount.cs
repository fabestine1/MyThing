using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4._4
{
    class BankAccount
    {
        private decimal balance;

        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            {
                return random.Next(min, max);
            }
        }

        public int AccountNumber
        {
            get {
                    return RandomNumber(1, 999999);
            }
        }

        public decimal Balance
        {
            get { return balance; }
            private set {
                if (value >= 0)
                {
                    balance = value;
                }
            }
        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}
