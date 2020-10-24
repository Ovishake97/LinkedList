﻿using System;
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