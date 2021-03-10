using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingFedApp
{
    class LinkedListForTestRides
    {
        private Node first;
        private int itemCounter;

        public LinkedListForTestRides()
        {
            this.first = null;
            this.itemCounter = 0;
        }

        public int nrOfTestRides() { return this.itemCounter; }

        public void addRacerToList(Racer r)
        {        
            if (this.itemCounter == 0)
            {//linked list is empty
                this.first = new Node(r);
            }
            else
            {//linked list is not empty
                Node temp = new Node(r);
                temp.setNext(first);
                first = temp;
            }
            this.itemCounter++;
        }

    }
}
