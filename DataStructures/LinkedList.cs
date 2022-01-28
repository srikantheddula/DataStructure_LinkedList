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
        public void insertBetween(Node prev_node,
                        int new_data)
        {
            /* 1. Check if the given Node is null */
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node" +
                                        " cannot be null");
                return;
            }
            Node nodeobj = new Node(new_data);
            nodeobj.next = prev_node.next;
            prev_node.next = nodeobj;
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
