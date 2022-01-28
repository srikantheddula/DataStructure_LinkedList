﻿using System;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Append(56);
            list.Append(30);
            list.Append(70);
            Console.WriteLine("before LinkedList Sequence using append:");
            list.Display();
            Console.WriteLine("\nafter deletion of last element");
            list.DeleteLastNode();          
            list.Display();
        }
    }
}
