using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_Track_Solution
{
    public class LinkedList
    {
        private Node first;
        //private Node last;

        public LinkedList()
        {
            this.first = null;
           // this.last = null;
        }

        public void registerWinner(String name)
        {
            if (this.first == null)
            {
                this.first = new Node(new Item(name));
            }   
            else
            {
                Node myFinger = first;
                while (myFinger !=null && myFinger.getItem().ParticipantName == name)
                {
                    myFinger = myFinger.getNext();
                }

                if (myFinger !=null)
                {
                    myFinger.getItem().IncrementCounter();
                }
                else
                {
                    Node temp = new Node(new Item(name));
                    temp.setNext(this.first);
                    this.first = temp;
                }
            }
        }

        public void GetInfo()
        {

        }
    }
}
