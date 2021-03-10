using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5._1
{
    class LinkedList
    {
        public delegate void UpdatedListHandler();
        public event UpdatedListHandler UpdatedList;
        public Node firstNode { get; set; }
        public Node lastNode { get; set; }
        public LinkedList()
        {
            firstNode = new Node("Nikolay");
            lastNode = firstNode;
        }
        public void InsertAtFront(string name)
        {
            Node newNode = new Node(name);
            if (firstNode == null)
            {
                firstNode = newNode;
                lastNode = newNode;
            }
            else
            {
                newNode.Next = firstNode;
                firstNode = newNode;
            }
            if (UpdatedList != null)
            {
                UpdatedList();
            }
        }
        public void Insert(string name)
        {
            Node newNode = new Node(name);
            if (firstNode == null)
            {
                firstNode = newNode;
                lastNode = newNode;
            }
            else if (newNode.Name.CompareTo(firstNode.Name) == 0 || newNode.Name.CompareTo(firstNode.Name) == -1)
            {
                newNode.Next = firstNode;
                firstNode = newNode;
            }
            else
            {
                Node current = firstNode;
                while (current.Next != null && current.Next.Name.CompareTo(newNode.Name) == -1)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;
                if(newNode.Next == null)
                {
                    lastNode = newNode;
                }
            }
            if (UpdatedList != null)
            {
                UpdatedList();
            }
        }
        public void Delete(string name)
        {
            Node nodeToDelete = new Node(name);
            if (firstNode != null) // if not empty
            {
                if (nodeToDelete.Name == firstNode.Name)
                {
                    if (firstNode == lastNode) //if only one
                    {
                        firstNode = null;
                        lastNode = null;
                    }
                    else
                    {
                        if (firstNode.Next != null)
                        {
                            firstNode = firstNode.Next;
                        }
                    }
                }
                else
                {
                    Node current = firstNode;
                    while (current.Next != null)
                    {
                        if(current.Next.Name != nodeToDelete.Name)
                        {
                            current = current.Next;
                        }
                    }
                    if (current.Next.Name == nodeToDelete.Name)
                    {
                        current.Next = current.Next.Next;
                    }
                }
            }
            if (UpdatedList != null)
            {
                UpdatedList();
            }
        }
    }
}
