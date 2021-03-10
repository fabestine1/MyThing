using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreakyGarage
{
    public class Node
    {
        private Car theCar;
        private Node next; 

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
