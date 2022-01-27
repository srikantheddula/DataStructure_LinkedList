using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Node
    {
        public int data;
        public  Node next;

        // Constructor to create a new node.Next is by default initialized as null  
        public Node(int d)
        {
            this.data = d;
            this.next = null;
        }
    }
}
