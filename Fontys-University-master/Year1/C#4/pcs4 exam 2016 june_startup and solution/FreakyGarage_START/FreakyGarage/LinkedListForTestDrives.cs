using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreakyGarage
{
    public class LinkedListForTestDrives
    {
        private Node first;
        private Node last;

        public LinkedListForTestDrives()
        {
            first = null;
            last = null;
        }


        public void addCarToList(Car c)
        {
            if (first == null)
            {
                // there are no items in the linked list
                this.first = new Node(c);
                this.last = this.first;
            }
            else
            {
                // add car at the front of the list
                Node temp = first;
                this.first = new Node(c);
                this.first.setNext(temp);
            }
        }

        public int nrOfTestDrivesWithCarsOfBrand(string brand)
        {
            if (this.first == null)
                return 0;
            else
            {
                Node curr = this.first;
                int counter = 0;
                while (curr != null)
                {
                    if (curr.getCar().Brand.Equals(brand))
                    {
                        counter++;
                    }
                    curr = curr.getNext();
                }
                return counter;
            }
        }

    }
}
