
//-----------------------------------------------------------------------
// <copyright file="HashingUtility.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
// <creator name="Mahesh Aurad"/>
//-----------------------------------------------------------------------

namespace DataStructure
{
    using System;

    class Hashingutility<T>
    {
        Node<T>[] head = new Node<T>[11];
        LinkedList<T> linkedList = new LinkedList<T>();

        public void AddNumberList(T number)
        {
            
            insertElementBySorting(number);

        }

        public bool insertElementBySorting(T element)
        {
            try
            {

                Node<T> newNode = new Node<T>(element);
                int filedata = Convert.ToInt32(newNode.Data);
                int position = filedata % 11;
                
                Node<T> currentNode = head[position], previousNode = null;

                bool isInserted = false;

                if (currentNode == null)
                {
                    head[position] = newNode;
                    isInserted = true;
                }
                else
                {
                   
                    int fileData = Convert.ToInt32(element);
                    int linkedListData = Convert.ToInt32(currentNode.Data);

                    if (currentNode.next == null && fileData > linkedListData)
                    {

                        currentNode.next = newNode;
                        newNode.next = null;
                        isInserted = true;
                    }
                    else if (currentNode.next == null && fileData < linkedListData)
                    {
                        head[position] = newNode;
                        newNode.next = currentNode;
                        isInserted = true;
                    }
                    else if (fileData < linkedListData)
                    {
                        head[position] = newNode;
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

        public void DisplayList()
        {
            for(int i =0; i < 11; i++)
            {
                Node<T> tempNode = head[i];
                Console.Write("| "+i+" |->");
                while (tempNode != null)
                {
                    Console.Write("| "+tempNode.Data + "|->");
                    tempNode = tempNode.next;
                }
                Console.WriteLine();
            }
        }
    }
}
