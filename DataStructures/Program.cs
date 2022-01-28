using System;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Append(56);
            list.Append(70);
            list.insertBetween(list.head,30);
            Console.WriteLine("LinkedList Sequence using append:");
            list.Display();
        }
    }
}
