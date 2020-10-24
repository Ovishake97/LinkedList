using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListMethods list = new LinkedListMethods();
            list.InsertFront(56);
            list.InsertFront(70);
            list.InsertInBetween(30);
            Console.WriteLine(list.DeleteFirstNode());
            Console.WriteLine(list.DeleteLastNode());
            list.DisplayList();
            Console.ReadLine();
        }
    }
}
