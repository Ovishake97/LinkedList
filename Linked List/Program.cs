using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListMethods list = new LinkedListMethods();
            list.InsertLast(70);
            list.InsertLast(30);
            list.InsertLast(56);
            list.DisplayList();

        }
    }
}
