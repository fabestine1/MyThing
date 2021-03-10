using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreakyGarage
{
    class LinkedListForTestDrives
    {
        private Node first;
        private Node last;
        public int nrOfTestDrivesWithCarsOfBrand(string brand)
        {
            Node current = first;
            int counter = 0;
            while(current != null)
            {
                if(current.Value.Brand == brand)
                {
                    counter++;
                }
                current = current.Next;
            }
            return counter;
        }
        public void addCarToList(Car c)
        {
            Node newNode = new Node(c);
            if (first == null)
            {
                first = newNode;
                last = newNode;
            }
            else
            {
                newNode.Next = first;
                first = newNode;
            }
        }
        public LinkedListForTestDrives()
        {
            first = null;
            last = null;
        }
    }
}
