using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Owner
    {
        //private variables
        //start autoincrementing userIDs from 1 on;
        private static int counter = 0;

        //properties
        internal int ID { get; }
        internal string LastName { get; }
        internal string Email { get; }

        //constructors
        public Owner(string lastName,string email)
        {
            LastName = lastName;
            Email = email;
            counter++;
            ID = counter;
        }

        //methods
    }
}
