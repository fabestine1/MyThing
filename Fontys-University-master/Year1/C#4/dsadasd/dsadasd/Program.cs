using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsadasd
{
    class Program
    {
        static void Main(string[] args)
        {
            linkedlist temp = new linkedlist();
            temp.addNode("1");
            temp.addNode("2");
            temp.addNode("3");
            temp.addNode("4");

            Console.WriteLine(temp.itemCounter);
            Console.WriteLine(temp.first.getItem());
            Console.WriteLine(temp.first.getNext().getItem());
            Console.WriteLine(temp.first.getNext().getNext().getItem());
            Console.WriteLine(temp.last.getItem());
            Console.WriteLine(temp.PrintAllNodes());
        }
    }

    class linkedlist
    {
        public Node first;
        public Node last;
        public int itemCounter;

        public linkedlist()
        {
            this.first = null;
            this.itemCounter = 0;
        }

        public void addNode(string name)
        {
            if (first == null)
            {
                first = new Node(name);
                last = first;
                itemCounter++;
            }
            else
            {
                //add at the start of the list

                //Node temp = new Node(name);
                //temp.setNext(first);
                //first = temp;

                //add at the end of the list

                Node temp = new Node(name);
                last.setNext(temp);
                last = temp;

                itemCounter++;
            }
        }

        public string PrintAllNodes()
        {
            //Traverse from head
            string temp = first.getItem() + "->";
            Node curr = first;
            while (curr.getNext() != null)
            {
                curr = curr.getNext();
                temp += curr.getItem();
                temp +="->";
            }
            temp+= "NULL";
            return temp;
        }
    }

    class Node
    {
        private string theItem; //the item it refers to
        private Node next;    // the next node it refers to; null if there does not exist a next node

        public Node(string aItem)
        {
            this.theItem = aItem;
            this.next = null;
        }

        public string getItem() { return this.theItem; }

        public Node getNext() { return this.next; }
        public void setNext(Node n) { this.next = n; }
    }
}
