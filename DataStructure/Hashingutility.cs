

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
                Node<T> tempNode;
                Node<T> newNode = new Node<T>(element);
                int linkedListData = Convert.ToInt32(newNode.Data);
                int rem = linkedListData % 11;

                tempNode = head[rem];
                
                Node<T> currentNode = head[rem], previousNode = null;

                bool isInserted = false;

                if (currentNode == null)
                {
                    head[rem] = newNode;
                    isInserted = true;
                }
                else
                {
                   
                    int fileData = Convert.ToInt32(element);

                    if (linkedListData > fileData)
                    {
                        head[rem] = newNode;
                        newNode.next = currentNode;
                    }

                    while (currentNode.next != null && fileData > linkedListData)
                    {
                        previousNode = currentNode;
                        currentNode = currentNode.next;
                        linkedListData = Convert.ToInt32(currentNode.Data);
                    }
                    if (currentNode.next == null && fileData > linkedListData)
                    {
                        currentNode.next = newNode;
                    }
                    if (fileData < linkedListData)
                    {
                        previousNode.next = newNode;
                        newNode.next = currentNode;
                    }
                    isInserted = true;
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
