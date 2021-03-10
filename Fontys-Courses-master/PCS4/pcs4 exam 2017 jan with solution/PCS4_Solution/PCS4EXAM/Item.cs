using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCS4EXAM
{
    public class Item
    {
        private String nameStartup;    
        private String nameDonator;
        private int amount;          

        public Item(String nameStartup, String nameDonator, int amount)
        {
            this.nameStartup = nameStartup;
            this.nameDonator = nameDonator;
            this.amount = amount;
        }


        public override string ToString()
        {
            return this.nameStartup + "; " + this.nameDonator + "; " + this.amount.ToString();
        }
    }
}
