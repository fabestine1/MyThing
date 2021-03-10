using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deliveries
{

    public class Deliverable/* : IComparable<Deliverable>*/
    {
        private int id;    //the unique id of a deliverable
        private int weight; //the weight (in grams) of this deliverable
        private Person buyer; //the person who bought this deliverable

        public Deliverable(int id, int weight, Person buyer)
        {
            this.id = id;
            this.weight = weight;
            this.buyer = buyer;
        }

        public int ID { get { return this.id; } }
        public int Weight { get { return this.weight; } }
        public Person Buyer { get { return this.buyer; } }


        public override string ToString()
        {
            return "Id:" + id + ", weight:" + weight + ", to be delivered at: " + buyer.Name + " - " + buyer.Street + " " + buyer.Housenumber + " - " + buyer.Postalcode + " " + buyer.City; //todo
        }

        //public int CompareTo(Deliverable d)
        //{
        //    if (this.buyer.Street == d.buyer.Street)
        //    {
        //        if (this.buyer.Housenumber % 2 == 1)
        //        {
        //            return -1;
        //        }
        //        else return 1;
        //    }
        //    else
        //    {
        //        int result = string.Compare(this.buyer.Street, d.buyer.Street);
        //        if (result == 1)
        //        {
        //            return 1;
        //        }
        //        if (result == -1)
        //        {
        //            return -1;
        //        }
        //    }
        //    return this.buyer.Street.CompareTo(d.buyer.Street);
        //}
    }
}
