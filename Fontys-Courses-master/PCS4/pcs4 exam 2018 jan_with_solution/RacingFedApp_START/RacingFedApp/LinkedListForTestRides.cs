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
        private Node last;
        public int nrOfTestRidesWithPlayersOfTeam(string team)
        {
            Node current = first;
            int count = 0;
            while(current != null)
            {
                if(current.Value.Type == team)
                {
                    count++;
                }
                current = current.Next;
            }
            return count;
        }
        public void addRacerToList(Racer r)
        {
            Node newNode = new Node(r);
            if(first == null)
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
        public LinkedListForTestRides()
        {
            first = null;
            last = null;
        }
    }
}
