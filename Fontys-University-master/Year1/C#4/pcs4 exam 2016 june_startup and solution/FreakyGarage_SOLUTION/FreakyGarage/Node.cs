using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreakyGarage
{
    class Node // assignment 3a
    {
        private Car theCar; // the car it refers to
        private Node next; // the next node it refers to; null if there does not exist a next node

        public Node(Car c)
        {
            this.theCar = c;
            this.next = null;
        }

        public Car getCar() { return this.theCar; }

        public Node getNext() { return this.next; }
        public void setNext(Node n) { this.next = n; }
    }
}
