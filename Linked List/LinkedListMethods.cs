using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedListMethods
    {
        public Node head;
        /// This method adds an entry to the list
        /// to the last by fetching the details of the last node
        public void InsertLast(int newData)
        {
            Node node = new Node(newData);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = node;
            }
            Console.WriteLine("Inserted: " + node.data);
        }
        /// A method to return the last node of the list
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        /// Method to enter a data from the front of the list
        public void InsertFront(int newData)
        {
            Node node = new Node(newData);
            node.next = this.head;
            this.head = node;
            Console.WriteLine("Inserted: " + node.data);
        }
        /// Method to insert an element in between 
        /// by fetching the size of the array
        public void InsertMid(int newData)
        {
            Node newNode = new Node(newData);
            if (head == null)
            { 
                head = newNode;
            }
            else
            {
                int size = GetSize();
                Node temp, currentNode;
                int count = (size % 2 == 0) ? (size / 2) : ((size + 1) / 2); 
                temp = head;
                currentNode = null; 
                for (int i = 0; i < count; i++)
                { 
                    currentNode = temp;  
                    temp = temp.next;
                }
                currentNode.next = newNode;
                newNode.next = temp;
            }
            Console.WriteLine("Inserted "+newNode.data+" to the middle");
        }
        //To print the list by traversing through the list
        //and printing till the last data
        public void DisplayList()
        {
            Console.WriteLine();
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write("\t" + temp.data);
                    temp = temp.next;
                }
            }
        }
        /// Method to give the size of the linked list
        /// by traversing through it
        public int GetSize() {
            Node temp = this.head;
            int size = 0;
            if (temp == null)
            {
                return size;
            }
            else {
                while (temp != null) {
                    temp = temp.next;
                    size++;
                }
                return size;
            }
        }
    }
}
