//-----------------------------------------------------------------------
// <copyright file="AnagramPalindromeNumber.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
// <creator name="Mahesh Aurad"/>
//-----------------------------------------------------------------------

namespace DataStructure
{
    using System;
    /// <summary>
    /// DeQueueUtility class which performs specific tasks
    /// </summary>
    class DeQueueUtility<E>
    {
        Dequeue<E> rear;
        Dequeue<E> front;
        LinkedList<E> linkedList = new LinkedList<E>();
        int size = 0;
        E value;

        //add front
        public void AddFront(E charecter)
        {
            if (front == null) //if no element in list
            {
                front.data = charecter;
                rear = front;
            }
            else  //if element in list
            {
                Dequeue<E> tNode = new Dequeue<E>(charecter);
                
                tNode.next = front;
                front.pre = tNode;
                front = tNode;
            }
            size++;
        }
        //add rear
        public void AddRear(E Charecter)
        {
            Dequeue<E> newNode = new Dequeue<E>(Charecter);

            if (rear == null) // if dequeue is empty
            {
                //linkedList.AddLastPosition(Charecter);
                front = newNode;
                rear = front;
                size++;
            }
            else //more than one element
            {
                rear.next = newNode;
                newNode.pre = rear;
                rear = newNode;
                size++;
            }
        }

        //remove front
        public E RemoveFront()
        {
            // T val;
            if (front == null)
            {
                Console.WriteLine("No elements to delete");
            }
            else
            {
                value = front.data;
                front = front.next;
            }
            size--;
            return value;
        }

        //remove rear
        public E RemoveRear()
        {
            // T val;
            if (front == null)
            {
                Console.WriteLine("No element to delete");
            }
            else
            {
                value = rear.data;
                rear = rear.pre;
                rear.next = null;
            }
            size--;
            return value;
        }
        //to remove
        public bool IsEmpty()
        {
            if (front == null)
                return true;
            else
                return false;
        }

        //return size of deque
        public int Size()
        {
            return size;
        }
    }
}
