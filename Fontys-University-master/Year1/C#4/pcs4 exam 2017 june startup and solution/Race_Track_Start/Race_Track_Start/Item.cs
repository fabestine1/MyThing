using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_Track_Solution
{
    public class Item
    {
        private String name;
        private int counter;

        public String ParticipantName { get { return this.name; } }

        public Item(String name)
        {
            this.name = name;
            this.counter = 1;
        }

        public void IncrementCounter()
        {
            counter++;
        }

        public override String ToString()
        {
            return this.name + " " + this.counter;
        }
    }
}
