using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS4EXAM
{
    class LinkedList
    {
        private Node first;
        private Node last;
        public Node FirstNode { get { return first; } }
        public LinkedList()
        {
            first = last = null;
        }
        public void addDonationToLinkedList(String startupName, String donatorName, int amount)
        {
            Node newNode = new Node(startupName, donatorName, amount);
            if(first == null) first = last = newNode;
            else
            {
                Node current = first;
                int counter = 0;
                while (current.Next != last && current.Next != null)
                {
                    counter++;
                    current = current.Next;
                }
                if (counter == 8)
                {
                    current.Next = null;
                    last = current;
                }
                newNode.Next = first;
                first = newNode;
            }
        }
    }
}
