using System;
namespace DataStructure
{
    using System;

    /// <summary>
    /// opeartions over Queue
    /// </summary>
    /// <typeparam name="T">head</typeparam>
    public class Queue<T>
    {
        Node<T> head;
        int length = 0;

        //add element in queue

        public Node<T> Enque(T data)
        {

            Node<T> new_node = new Node<T>(data);  //create new node
            Node<T> temp = head;
            if (head == null)  // if no element present in queue new node will be head
            {
                head = new_node;
                length++;
                return head;
            }
            while (temp.next != null) // traverse till last node
            {
                temp = temp.next;
            }
            temp.next = new_node; // add element after present element
            length++;
            new_node.next = null;
            return head;
        }

        //remove first in element
        public T Deque(T element)
        {
            if (head == null)
            {
                Console.WriteLine("queue is empty");
            }
            T result = head.Data;
            head = head.next;
            length--;
            return result;
        }

        public T Deque()
        {
            if (head == null)
            {
                Console.WriteLine("queue is empty");
            }
            T result = head.Data;
            head = head.next;
            length--;
            return result;
        }

        //check queue is empty or not
        public bool IsEmpty()
        {
            return (length == 0);
        }

        //find size 
        public int Size()
        {
            return length;
        }

        //return first element from queue
        public T TopElement()
        {
            return head.Data;
        }

        //print queue
        public void Display()
        {
            Node<T> new_node = head;
            int size = Size();
            for (int i = 0; i < size; i++)  //traverse till last
            {
                Console.WriteLine(new_node.Data + " ");
                new_node = new_node.next;

            }

            return;
        }
    }

}