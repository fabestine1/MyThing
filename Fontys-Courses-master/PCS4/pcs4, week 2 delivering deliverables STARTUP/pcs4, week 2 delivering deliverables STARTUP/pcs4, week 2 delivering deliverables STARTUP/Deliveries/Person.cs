using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deliveries
{
    public class Person
    {
        private int id;
        private String name;
        private String street;
        private int housenumber;
        private String postalcode;
        private String city;

        public Person(int id, String name, String street, int housenumber, String postalcode, String city)
        {
            this.id = id;
            this.name = name;
            this.street = street;
            this.housenumber = housenumber;
            this.postalcode = postalcode;
            this.city = city;
        }

        public int ID { get { return this.id; } }
        public String Name { get { return this.name; } }
        public String Street { get { return this.street; } }
        public int Housenumber { get { return this.housenumber; } }
        public String Postalcode { get { return this.postalcode; } }
        public String City { get { return this.city; } }


        public override string ToString()
        {
            return this.name + " - " + this.street + "  " + this.housenumber + " - " + this.postalcode + "  " + this.city;
        }

    }
}
