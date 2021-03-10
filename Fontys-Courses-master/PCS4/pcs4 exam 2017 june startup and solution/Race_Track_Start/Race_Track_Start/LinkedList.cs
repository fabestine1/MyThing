using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_Track_Solution
{
    class LinkedList
    {
        private Node first;
        private Node last;
        public LinkedList()
        {
            first = null;
            last = null;
        }
        public void AddWinner(Participant p)
        {
            Node newNode = new Node(p.Name);
            if (first == null)
            {
                first = newNode;
                last = newNode;
            }
            else
            {
                Node winner = FindWinner(p);
                if (winner != null) winner.WonTimes++;
                else
                {
                    newNode.Next = first;
                    first = newNode;
                }
            }
        }
        public Node FindWinner(Participant p)
        {
            Node current = first;
            while (current != null)
            {
                if (current.Player == p.Name)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }
        public List<string> GetAllWinners()
        {
            List<string> temp = new List<string>();
            Node current = first;
            while(current != null)
            {
                temp.Add(current.ToString());
                current = current.Next;
            }
            return temp;
        }
    }
}
