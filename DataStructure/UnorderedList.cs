//-----------------------------------------------------------------------
// <copyright file="AnagramPalindromeNumber.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
// <creator name="Mahesh Aurad"/>
//-----------------------------------------------------------------------

namespace DataStructure
{
    using System;
    using System.IO;
    

    /// <summary>
    /// To create unordered linked list
    /// </summary>
    class UnorderedList
    {
       ///read data from file 
       
        
        public static void ReadDataFromFile()
        {
            try
            {
                //int choice = 0;
                //char ch = 'y';
                LinkedList<string> linkedList = new LinkedList<string>();
                //linkedList.DisplayLinkedList();
                Utility utility = new Utility();
                string path = utility.GetFilePath();
                string textFileDataString = File.ReadAllText(path);

                bool isElementFound = false;

                //String Array method is converting the whole string file in string array
                string[] stringArray = utility.StringArray(textFileDataString);

                // LinkedList<string> linkedList = new LinkedList<string>();

                for (int i = 0; i < stringArray.Length; i++)
                {
                    linkedList.AddLastPosition(stringArray[i]);
                }

                Console.WriteLine("The linked List is:");
                linkedList.DisplayLinkedList();

                Console.WriteLine("Enter the search element:");
                string element = Console.ReadLine();

                isElementFound = linkedList.SearchElement(element);

                if (isElementFound == true)
                {
                    linkedList.RemoveElement(element);
                }
                else
                {
                    linkedList.AddLastPosition(element);
                }
                Console.WriteLine("The linked List is:");
                linkedList.DisplayLinkedList();

                /*    Console.WriteLine("Enter the search element:");
                  string element1 = Console.ReadLine();

                  Console.WriteLine("Enter the position :");
                  int position =Convert.ToInt32( Console.ReadLine());

                  linkedList.AddAtPosition(element1, position);

                  Console.WriteLine("The linked List is:");
                  linkedList.DisplayLinkedList();


                 do
                   {
                       Console.WriteLine("\n1. AddFirstPosition " +
                                   "\n2. AddLastPosition " +
                                   "\n3. AddAtPosition " +
                                   "\n4. SearchElement " +
                                   "\n5. DisplayLinkedList " +
                                   "\n6. RemoveElement " +
                                   "\n7. SizeOfList ");

                       Console.WriteLine("Enter the choice for perform following operations:");
                       choice = Convert.ToInt32(Console.ReadLine());

                       UnorderedList unorderedlist = new UnorderedList();

                       switch (choice)
                       {
                           case 1:
                               unorderedlist.UnordereList();
                               break;

                           case 2:

                               break;

                           case 3:

                               break;

                           case 4:

                               break;

                           case 5:

                               break;

                           case 6:

                               break;

                           case 7:

                               break;

                           case 8:

                               break;

                          default:
                               Console.WriteLine("Invalid choice ...!");
                               Console.WriteLine("ReEnter choice");
                               break;
                       }
                       Console.WriteLine("Enter y / n for continue:");
                        ch = Convert.ToChar(Console.ReadLine());
                    } while (ch != 'N') ;*/
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        void UnordereList()
        {
            
        }
    }
}
