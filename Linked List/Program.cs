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
            list.InsertFront(40);
            list.InsertFront(65);
            list.InsertMid(30);
            list.DisplayList();
        }
    }
}
