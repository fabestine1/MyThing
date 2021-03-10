using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RacingFedApp
{
    public class Node
    {
        private Racer theRacer; //the item it refers to
        private Node next;    // the next node it refers to; null if there does not exist a next node

        public Node(Racer r)
        {
            this.theRacer = r;
            this.next = null;
        }
        
        public Racer getItem() { return this.theRacer; }

        public Node getNext() { return this.next; }
        public void setNext(Node n) { this.next = n; }

    }
}
