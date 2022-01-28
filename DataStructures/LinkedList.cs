using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    /// <summary>
    /// simple linked list uc6 deletenode from last
    /// </summary>
    class LinkedList
    {
        public Node head;
        public void Append(int d)
        {
            Node nodeobj = new Node(d);
            if (this.head == null)
            {
                this.head = nodeobj;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = nodeobj;
            }
            Console.WriteLine("{0} inserted into Linked List", nodeobj.data);
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
        public Node Search(int value)  
        {
            while (this.head!= null)
            {
                if (this.head.data==value)
                {
                    Console.WriteLine("data exists"+this.head.data);
                }
                this.head = this.head.next;
            }
            return null;
        }
    }
}
