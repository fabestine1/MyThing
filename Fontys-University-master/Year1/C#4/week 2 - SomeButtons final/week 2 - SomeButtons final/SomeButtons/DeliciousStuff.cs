using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SomeButtons
{
    class DeliciousStuff
    {
        private String name;
        private int price;

        public DeliciousStuff(String name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public String Name { get { return this.name; } }
        public int Price { get { return this.price; } }

    }
}
