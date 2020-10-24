using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListMethods list = new LinkedListMethods();
            list.InsertFront(70);
            list.InsertFront(30);
            list.InsertFront(40);
            list.InsertFront(56);
            list.DeleteRequiredData(40);
            list.DisplayList();
            Console.ReadLine();
        }
    }
}
