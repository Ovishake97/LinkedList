using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListMethods list = new LinkedListMethods();
            list.InsertFront(56);
            list.InsertFront(30);
            list.InsertFront(70);
            list.DisplayList();

        }
    }
}
