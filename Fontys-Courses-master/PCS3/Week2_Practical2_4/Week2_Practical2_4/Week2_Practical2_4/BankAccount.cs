using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Practical2_4
{
    class BankAccount
    {
        // Instance variable
        private int accountNr;
        private decimal balance;
        // Properties
        public int AccountNr
        {
            get { return accountNr; }
        }
        public decimal Balance
        {
            get { return balance; }            
        }
        public string Name 
        { get; set; }
        
        // Constructor
        public BankAccount(int nwAccountNr, decimal nwBalance, string nwName)
        {
            accountNr = nwAccountNr;
            balance = nwBalance;
            Name = nwName;
        }
        // Methods
        public void Deposit(decimal amount)
        {
            balance += amount;
        }
        public bool Withdraw(decimal amount)
        {
            if(balance - amount  >= 0)
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
