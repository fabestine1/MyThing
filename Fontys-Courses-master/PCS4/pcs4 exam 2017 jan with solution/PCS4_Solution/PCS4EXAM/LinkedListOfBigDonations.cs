using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS4EXAM
{
    class LinkedListOfBigDonations
    {
        private Node first;
        private int itemCounter;

        public LinkedListOfBigDonations()
        {
            this.first = null;
            this.itemCounter = 0;
        }

        public void addDonationToLinkedList(String startupName, String donatorName, int amount)
        {
            Item i = new Item(startupName, donatorName, amount);
            Node temp = new Node(i);
            temp.setNext(first);
            first = temp;
            this.itemCounter++;
            if (this.itemCounter==11)
            {   //remove the last item in the list
                Node helpNode = first;
                while (helpNode.getNext().getNext()!=null)
                { helpNode = helpNode.getNext();  }
                //now helpNode is the node before the last node in the linked list
                helpNode.setNext(null);
                this.itemCounter--;
            }
        }

        public List<String> getInfoOfAllItems()
        {
            List<String> temp = new List<string>();

            if (first == null)
            {// there are no items in the linked list
                temp.Add("There are no items in the linked list");
                return temp;
            }
            else
            {// there are items in the linked list
                Node helpNode = first;
                while (helpNode!= null)
                {
                    temp.Add(helpNode.getItem().ToString());
                    helpNode = helpNode.getNext();
                }
                return temp;
            }
        }
    }
}
