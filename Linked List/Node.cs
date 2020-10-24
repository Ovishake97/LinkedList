using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class Node
    {
        /// The following class contains the data part and the link
        /// which contains the address of the next node
      
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
}
