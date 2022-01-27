using System;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddFirst(70);
            list.AddFirst(30);
            list.AddFirst(56);
            list.Display();
        }
    }
}
