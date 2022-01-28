﻿using System;
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

        public Node Pop()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
    }
}
