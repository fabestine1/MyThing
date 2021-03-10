using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Store
    {
        private List<Drumble> myDrumbles;

        public Store()
        {
            this.myDrumbles = new List<Drumble>();
        }

        public List<Drumble> Drumbles { get { return this.myDrumbles; } }

        public void AddDrumble(Drumble d)
        {
            this.myDrumbles.Add(d);
        }


        /// <summary>
        /// SortById sorts the elements of the list by id (from a low value to a high value).
        /// It it is based on the IComparable-interface
        /// </summary>
        public void SortById()
        {
            this.myDrumbles.Sort();
            // no parameters, so it will use the CompareTo-method of the Drumble-class,
            // as specified in one of the IComparable-interfaces.
        }

        /// <summary>
        /// SortByName sorts the elements of the list by name.
        /// It is based on using the delegate Comparison<Drumble>
        /// </summary>
        public void SortByName()
        {
            this.myDrumbles.Sort(new Comparison<Drumble>(this.compareByName));
            //Remark: The method ????? fits to the delegate Comparison<Drumble>       
        }

        public int compareByName(Drumble firstDrumble, Drumble secondDrumble)
        {
           return  firstDrumble.Name.CompareTo(secondDrumble.Name);
        }




        /// <summary>
        /// SortByNumberOfCredits sorts the elements of the list by number of credits.
        /// It is based on using an object of a class that implements the IComparer<Drumble>
        /// </summary>
        public void SortbyNumberOfCredits()
        {
                        Helper flupke = new Helper();
                        this.myDrumbles.Sort(flupke);
        }

    }
}
