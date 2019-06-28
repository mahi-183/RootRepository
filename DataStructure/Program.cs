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
    /// Programe is a class which contain the entry point function
    /// </summary>
    class Program
    {

        /// <summary>
        /// main method is Entry point function of Application 
        /// </summary>
        static void Main(string[] args)
        {
            int choice = 0;
            char ch = 'Y';
            try
            {
                do
                {
                    Console.WriteLine("\n1. UnOrderedList Programme " +
                                  "\n2. OrderedList Programme" +
                                  "\n3. Simple Balanced Paranthesis Programme" +
                                  "\n4. Simulate Banking Cash Counter Programme" +
                                  "\n5. Palindrome Checker Programme" +
                                  "\n6. Hashing Function Programme" +
                                  "\n7. Binary Search Tree Programme" +
                                  "\n8. Calender Programme" +
                                  "\n9. WeekDay Programme" +
                                  "\n10.Implement Stack Using linkedList Programme" +
                                  "\n11.Prime Number to store 2D Array Programme" +
                                  "\n12.Extend Prime function check Anagrame Programme" +
                                  "\n13.Add Anagrame into stack Using LinkedList Programme" +
                                  "\n14.Add Anagrame into queue using LinkedList Programme");

                    Console.WriteLine("Enter your choice ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            LinkedList<int> ll = new LinkedList<int>();
                            UnorderedList.ReadDataFromFile();
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

                        case 9:

                            break;

                        case 10:

                            break;

                        case 11:

                            break;

                        case 12:

                            break;

                        case 13:

                            break;

                        case 14:

                            break;

                        default:
                            Console.WriteLine("Invalid choice ...!");
                            Console.WriteLine("ReEnter choice");
                            break;
                    }
                    Console.WriteLine("Enter Y / N for continue:");
                    ch = Convert.ToChar(Console.ReadLine());
                } while (ch != 'N');
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
