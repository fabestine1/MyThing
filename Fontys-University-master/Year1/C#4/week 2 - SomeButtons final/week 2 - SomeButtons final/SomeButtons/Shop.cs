using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SomeButtons
{
    class Shop
    {
        private List<DeliciousStuff> myDeliciousStuff;

        public Shop()
        {
            myDeliciousStuff = new List<DeliciousStuff>();

            myDeliciousStuff.Add(new DeliciousStuff("Chips", 3));
            myDeliciousStuff.Add(new DeliciousStuff("Coca cola",4));
            myDeliciousStuff.Add(new DeliciousStuff("Bavaria",4));
            myDeliciousStuff.Add(new DeliciousStuff("Black bean burger",6));
            myDeliciousStuff.Add(new DeliciousStuff("Egg muffin",4));
            myDeliciousStuff.Add(new DeliciousStuff("Frites",7));
            myDeliciousStuff.Add(new DeliciousStuff("Ice tea",3));
            myDeliciousStuff.Add(new DeliciousStuff("Cauliflower",7));
            myDeliciousStuff.Add(new DeliciousStuff("Salt",1));
            myDeliciousStuff.Add(new DeliciousStuff("Pepper",1));
        }

        public List<DeliciousStuff> getMyDeliciousStuff() {return this.myDeliciousStuff;}
    }
}
