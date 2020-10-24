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
        /// Method to insert an element
        /// after an element as chosen by the user
        public void InsertInBetween(int newData) {
            Console.WriteLine("Enter the node where you want to add");
            int data = Convert.ToInt32(Console.ReadLine());
            Node newNode = new Node(newData);
            Node temp = this.head;
            while (temp.data!=data) {
                temp = temp.next;
            }
            newNode.next = temp.next;
            temp.next = newNode;
        }
        /// Method to delete the first node by
        /// moving the head to the next node
        public Node DeleteFirstNode() {
            if (this.head == null) {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
        //Method to delete the last node
        //by traversing through the list till the node points to null
        public Node DeleteLastNode() {
            if (this.head == null) {
                return null;
            }
            if (this.head.next == null) {
                return null;
            }
            Node newNode = this.head;
            while (newNode.next.next == null) {
                newNode = newNode.next;
            }
            newNode.next = null;
            return null;
        }
        /// Method to search an element present in the list
        /// by traversing through the list till it appears
        public int Search(int value) {
            int count = 0;
            while (this.head != null) {
                Console.WriteLine("The value " +value+" is found");
                return count;
            }
            this.head = this.head.next;
            count++;
            return count;
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
        }    }
}
