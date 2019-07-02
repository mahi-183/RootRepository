//-----------------------------------------------------------------------
// <copyright file="LinkedList.cs" company="Bridgelabz">
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

                    for (int i = 1; (i <= position-1); i++)
                    {
                        prevNode = currentNode;
                        currentNode = currentNode.next;
                    }
                    prevNode.next = newNode;
                    newNode.next = currentNode;
                    currentNode = newNode;
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

        //---------------------------------------------------ordered List Operations------------------------------------------------------

        public bool insertElementBySorting(T element)
        {
            try
            {
                Node<T> newNode = new Node<T>(element);
                Node<T> currentNode = head, previousNode = null;
                bool isInserted = false;

                if (currentNode == null)
                {
                    head = newNode;
                    isInserted = true;
                }
                else
                {
                    int linkedListData = Convert.ToInt32(currentNode.Data);
                    int fileData = Convert.ToInt32(element);

                    if (currentNode.next == null && fileData > linkedListData)
                    {
                        currentNode.next = newNode;
                        newNode.next = null;
                        isInserted = true;
                    }
                    else if (currentNode.next == null && fileData < linkedListData)
                    {
                        head = newNode;
                        newNode.next = currentNode;
                        isInserted = true;
                    }
                    else if (fileData < linkedListData) {
                        head = newNode;
                        newNode.next = currentNode;
                        isInserted = true;
                    }
                    else
                    {
                        while (currentNode.next != null && fileData > linkedListData)
                        {
                            previousNode = currentNode;
                            currentNode = currentNode.next;
                            linkedListData = Convert.ToInt32(currentNode.Data);
                        }
                        if (fileData > linkedListData)
                        {
                            currentNode.next = newNode;
                            isInserted = true;
                        }
                        if (fileData < linkedListData)
                        {
                            previousNode.next = newNode;
                            newNode.next = currentNode;
                            isInserted = true;
                        }

                    }

                }
                return isInserted;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        

    }//end of class linkedlist
}//end of namespace
