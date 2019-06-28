//-----------------------------------------------------------------------
// <copyright file="AnagramPalindromeNumber.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
// <creator name="Mahesh Aurad"/>
//-----------------------------------------------------------------------

namespace DataStructure
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Generic linked list operations
    /// </summary>
    public class LinkedList<T>
    {
        internal Node<T> head;
        //LinkedList<T> ListObj = new <T>LinkedList();

        /// <summary>
        /// AddFirstPosition method for inserting the element into linkedlist at first position 
        /// </summary>
        /// <param name="element"></param>
        public bool AddFirstPosition(T element)
        {
            Node<T> newNode = new Node<T>(element);
            bool isNodeInserted = false;
            Node<T> tempNode = head;
            try
            {
                if (tempNode == null)
                {
                    head = newNode;
                    isNodeInserted = true;
                }
                else
                {
                    head = newNode;
                    newNode.next = tempNode;
                    isNodeInserted = true;
                }
                return isNodeInserted;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// AddLastPosition for inserting the element into linkedlist at Last position 
        /// </summary>
        /// <param name="element"></param>
        public bool AddLastPosition(T element)
        {
            Node<T> newNode = new Node<T>(element);
            Node<T> tempNode = head;
            bool isNodeInserted = false;
            try
            {

                if (tempNode == null)
                {
                    head = newNode;
                    isNodeInserted = true;
                }
                else
                {
                    while (tempNode.next != null)
                    {
                        tempNode = tempNode.next;
                    }
                    tempNode.next = newNode;
                    isNodeInserted = true;
                }
                return isNodeInserted;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// AddAtPosition method for insert the element at spefic position
        /// </summary>
        /// <param name="element"></param>
        /// <param name="position"></param>
        public bool AddAtPosition(T element,int position)
        {
            //call for size function which gives the count of linked list element 
            int size = SizeOfList();
            bool isNodeInserted = false;

            try
            {

                if (position == 0 || position < 0 || position > (size + 1))
                {
                    return false;
                }
                else if (position == 1)
                {
                    isNodeInserted = AddFirstPosition(element);
                    
                }
                else if (position == size + 1)
                {
                    isNodeInserted = AddLastPosition(element);
                }
                else
                {
                    Node<T> newNode = new Node<T>(element);
                    Node<T> currentNode = head,prevNode=null;

                    for (int i = 1; i <= position; i++)
                    {
                        prevNode = currentNode;
                        currentNode = currentNode.next;
                    }
                    prevNode.next = newNode;
                    newNode.next = currentNode;
                    isNodeInserted = true;
                }
                return isNodeInserted;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// SearchElementAtPositon method for search element from linkedlist 
        /// </summary>
        /// <param name="element"></param>
        public bool SearchElement(T element)
        {
            Node<T> tempNode = head;
            bool isElementFound = false;

            try
            {

                if (tempNode == null)
                {
                    return false;
                }
                else
                {
                    while (tempNode != null)
                    {
                        if (element.Equals(tempNode.Data))
                        {
                           
                            isElementFound = true;
                           
                            break;
                        }
                        tempNode = tempNode.next;
                    }
                }
                return isElementFound;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// DisplayLinkedList method for displaying the element of likedlist 
        /// </summary>
        /// <param name="element"></param>
        public void DisplayLinkedList()
        {
            Node<T> tempNode = head;
            
            try
            {

                if (tempNode == null)
                {
                    return;
                }

                while (tempNode != null)
                {
                    Console.WriteLine("| " + tempNode.Data + " |->");
                    tempNode = tempNode.next;

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// RemoveElement method for delete the the element from likedlist 
        /// </summary>
        /// <param name="element"></param>
        public bool RemoveElement(T element)
        {
            Node<T> CurrentNode = head;
            bool isInserted = false;
            Node<T> previousNode = null;
            try
            {
                if (CurrentNode.Data.Equals(element) && CurrentNode == head)
                {
                    head = CurrentNode.next;
                    return false;
                }
                while (CurrentNode != null)
                {
                    if (CurrentNode.Data.Equals(element))
                    {
                        previousNode.next = CurrentNode.next;
                        break;
                    }
                    previousNode = CurrentNode;
                    CurrentNode = CurrentNode.next;
                }
                
                return isInserted;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// SizeOfList method for count the number of in the linked list 
        /// </summary>
        public int SizeOfList()
        {
            Node<T> tempNode = head;
            int size = 0;
            try
            {

                if (tempNode == null)
                {
                    return size;
                }
                else
                {
                    while (tempNode != null)
                    {
                        size++;
                        tempNode = tempNode.next;
                    }
                }
                return size;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /*  internal class Node
         {
             internal <t> data;
             internal Node<T> next;

             public Node(int data)
             {
                 this.data = data;
                 this.next = null;
             }
         }

         public void Insert(int data)
         {
             Node NewNode = new Node(data);
             Node currentNode = ListObj.head;

             if (ListObj.head == null)
             {
                 ListObj.head = NewNode;
                 return;
             }
             while(currentNode.next != null)
             {
                 currentNode = currentNode.next;
             }
             currentNode.next = NewNode;

         }

         public Boolean searchElement(int data)
         {
             Node currentNode = ListObj.head;
             bool elementFound = false;
             while(currentNode.next != null)
             {
                 if(currentNode.data == data)
                 {
                     elementFound = true;
                     break;
                 }
                 currentNode = currentNode.next;
             }
             return elementFound;
         }


         public void RemoveNode(int data)
         {
             Node NewNode = new Node(data);
             Node previousNode = null;

             Node currentNode = ListObj.head;
             if (currentNode.data == data && currentNode == ListObj.head)
             {
                 ListObj.head = currentNode.next;
                 return;
             }

             while (currentNode.next != null)
             {
                 if (currentNode.data == data)
                 {
                     previousNode.next = currentNode.next;
                     break;
                 }
                 previousNode = currentNode;
                 currentNode = currentNode.next;
             }

         }


         public void displayList()
         {
             Node currentNode = ListObj.head;
             Console.WriteLine("LinkedList:");
             while (currentNode != null)
             {
                 Console.WriteLine(currentNode.data);
                 currentNode = currentNode.next;
             }
         }
         */






    }











}
