using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    /// <summary>
    /// simple linked list uc1 adding first to the lsit
    /// </summary>
    class LinkedList
    {
        Node head;
        public void AddFirst(int d)
        {
            Node nodeobj = new Node(d);
            nodeobj.next = this.head;
            this.head = nodeobj;
            Console.WriteLine("{0} inserted into Linked List",nodeobj.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
