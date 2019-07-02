//-----------------------------------------------------------------------
// <copyright file="Stack.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
// <creator name="Mahesh Aurad"/>
//-----------------------------------------------------------------------

namespace DataStructure
{

    using System;
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Stack<T>
    {
         internal Node<T> head;


        int Top = -1, size = 0, size1 = 0, top = -1;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Data"></param>
        public bool push(T Data)
        {
            try
            {

                Node<T> newNode = new Node<T>(Data);
                Node<T> tempNode = head;
                bool isPushed = false;
                if (tempNode == null)
                {
                    head = newNode;
                    Top++;
                    return true;
                }
                else
                {
                    while (tempNode.next != null)
                    {
                        tempNode = tempNode.next;
                    }
                    tempNode.next = newNode;
                    Top++;
                    size++;
                    isPushed = true;
                }
                return isPushed;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Data"></param>
        public bool pop()
        {
            try
            {
                Node<T> currentNode = head;
                Node<T> previousNode = null;
                bool isPopedElement = false;

                if (currentNode == null)
                {
                    return false;
                    
                }
                else
                {
                    if(currentNode.next == null) {
                        currentNode = null;
                        Top--;
                        return true;
                    }
                    while (currentNode.next != null)
                    {
                        previousNode = currentNode;
                        currentNode = currentNode.next;
                    }
                    previousNode.next = null;
                    Top--;
                    isPopedElement = true;
                }
                return isPopedElement;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// remove element from stack
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            Node<T> current = head;
            head = current.next;
            top--;
            size1--;

            return current.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            return (head == null);
        }


        public int Size()
        {
            return Top;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Display()
        {
            Node<T> tempNode = head;
            int size = Size();
            for (int i = 0; i < size; i++)  //traverse till last
            {
                Console.WriteLine(tempNode.Data + " ");
                tempNode = tempNode.next;

            }

        }
    }
}
