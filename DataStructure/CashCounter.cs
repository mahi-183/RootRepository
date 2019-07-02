// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CashCounter.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Mahesh Chidanand Aurad"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructure
{
    using System;

    /// <summary>
    /// deposit cash,withdraw cash and maintain balance
    /// </summary>
    public class Node
    {
        int data;
        Node next;

        Node()
        {
            data = 0;
            next = null;
        }

        public Node(int d, Node n)
        {
            data = d;
            next = n;
        }

        public void SetNode(int d)
        {
            data = d;
        }

        public void SetLink(Node n)
        {
            next = n;
        }

        public int GetNode()
        {
            return data;
        }

        public Node GetLink()
        {
            return next;
        }
    }

    /// <summary>
    /// functions to add cash,remove cash and display
    /// </summary>
    public class CashCounter
    {
        public Node front, rear;
        public int size;

        //initialise members
        public CashCounter()
        {
            front = null;
            rear = null;
            size = 0;
        }

        public bool IsEmpty()
        {
            return front == null && rear == null;
        }

        //returnss size of the queue
        public int GetSize()
        {

            return size;
        }


        // Inserts the specified data.
        public void Insert(int data)
        {
            Node newnode = new Node(data, null);

            if (rear == null)
            {
                front = newnode;
                rear = newnode;
            }
            else //move elements
            {
                rear.SetLink(newnode);
                rear = rear.GetLink();
            }
            size++;
        }

        //removes the specified value and returns remaining balance
        public void Remove()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Underflow Exception");
            }
            Node ptr = front;
            front = ptr.GetLink();
            if (front == null)
            {
                rear = null;
                size--;
            }
            return;
        }

        //returns the node
        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack underflow");
            }

            int data = front.GetNode();
            return data;

        }

        //displays the queue
        public void Display()
        {
            int ptr1 = 0;

            if (size == 0)
            {
                Console.WriteLine("Empty");
            }

            Node ptr = front;

            while (ptr != rear.GetLink())
            {
                ptr1 = ptr1 + ptr.GetNode();
                Console.WriteLine(ptr1);

                ptr = ptr.GetLink();
            }
            Console.WriteLine();
        }
    }
}
