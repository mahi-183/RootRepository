//-----------------------------------------------------------------------
// <copyright file="OrderedList.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
// <creator name="Mahesh Aurad"/>
//-----------------------------------------------------------------------

namespace DataStructure
{
    using System;
    using System.IO;

    class OrderedList
    {
        public static void orderedList()
        {
            try
            {
                Utility utility = new Utility();

                string path = utility.GetOrderedFilePath();
                LinkedList<int> linkedList = new LinkedList<int>();

                string textFile = File.ReadAllText(path);
                Console.WriteLine("The string from file is: " + textFile);
                int[] integerArray = utility.IntegerArray(textFile);

               // Console.ReadLine();
                for (int i = 0; i < integerArray.Length; i++)
                {
                    linkedList.insertElementBySorting(integerArray[i]);
                }
                Console.WriteLine("The linked List is:");
                linkedList.DisplayLinkedList();

                Console.WriteLine("Enter the search Element:");
                int element = Convert.ToInt32(Console.ReadLine());

                bool isFound = linkedList.SearchElement(element);

                if (isFound == true)
                {
                    linkedList.RemoveElement(element);

                }
                else
                {
                    linkedList.AddLastPosition(element);
                }
                Console.WriteLine("The Linked list is:");
                linkedList.DisplayLinkedList();
               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
