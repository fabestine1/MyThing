using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS4EXAM
{
    public class Donation
    {
        private String name; // name of the donator
        private int amount; //amount of money that is donated

        public String Name { get { return this.name; } }
        public int Amount { get { return this.amount; } }

        public Donation(String name, int amount)
        {
            this.name = name;
            this.amount = amount;
        }

    }
}
