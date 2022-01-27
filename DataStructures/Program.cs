using System;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddLast(56);
            list.AddLast(30);
            list.AddLast(70);
            list.Display();
        }
    }
}
