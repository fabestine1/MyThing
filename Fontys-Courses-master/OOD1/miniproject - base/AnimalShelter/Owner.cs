using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    internal class Owner
    {
        //private variables
        //start autoincrementing userIDs from 1 on;
        private static int counter = 0;

        //properties
        internal int ID { get; }
        internal string LastName { get; }

        //constructors
        internal Owner(string lastName)
        {
            LastName = lastName;
            counter++;
            ID = counter;
        }

        //methods
    }
}
