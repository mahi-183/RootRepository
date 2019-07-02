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
                                  "\n9. Calender Using Stack" +
                                  "\n10.Calender Using queue Programme" +
                                  "\n11.Prime Number to store 2D Array Programme" +
                                  "\n12.Extend Prime function check Anagrame Programme" +
                                  "\n13.Add Anagrame into stack Using LinkedList Programme" +
                                  "\n14.Display Prime Numebers:");

                    Console.WriteLine("Enter your choice ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            LinkedList<int> ll = new LinkedList<int>();
                            UnorderedList.ReadDataFromFile();
                            break;

                        case 2:
                            LinkedList<int> linkedList = new LinkedList<int>();
                            OrderedList.orderedList();
                            break;

                        case 3:
                            BalancedParanthesis bObj = new BalancedParanthesis();
                            bObj.balancedParanthesis();
                            break;

                        case 4:
                            CashCounter cash = new CashCounter();
                            int select = 0;
                            do
                            {
                                Console.WriteLine("1.deposit");
                                Console.WriteLine("2.withdrawl");
                                Console.WriteLine("3.number of people in queue");
                                Console.WriteLine("4.Exit");
                                Console.WriteLine("Enter your choice");
                                select = Convert.ToInt32(Console.ReadLine());
                                switch (select)
                                {

                                    case 1:
                                        Console.WriteLine("Enter the amount to deposit:");
                                        int depositAmount = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Amount deposited:::");
                                        cash.Insert(depositAmount);
                                        cash.Display();
                                        break;

                                    case 2:
                                        Console.WriteLine("Enter the withdrawal amount:");
                                        int withdrawAmount = Convert.ToInt32(Console.ReadLine());

                                        cash.Remove();
                                        Console.WriteLine("The avilable balance is::");
                                        cash.Display();
                                        break;

                                    case 3:
                                        int number = cash.GetSize();
                                        Console.WriteLine("The number of people in queue:" + number);
                                        break;
                                    case 4: return;

                                    default:
                                        Console.WriteLine("you entered wrong choice");
                                        break;
                                }

                            } while (select <= 4);

                            break;
                           
                        case 5:
                            PalindromeChecker palindrom = new PalindromeChecker();
                            palindrom.CheckPalindrome();
                            break;

                        case 6:
                            HashingFunction hobj = new HashingFunction();
                            hobj.hashingFunction();
                            break;

                        case 7:
                            BinarySearchTree binarySearchTree = new BinarySearchTree();
                            binarySearchTree.Binarysearch();
                            break;
                            
                        case 8:
                            Console.WriteLine("Enter month ");
                            int month = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(" Enter year to display calender");
                            int year = Convert.ToInt32(Console.ReadLine());
                            Calender.Display(month, year);
                            break;

                        case 9:
                            Console.WriteLine("Enter month ");
                            int month_queue = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(" Enter year to display calender");
                            int year_queue = Convert.ToInt32(Console.ReadLine());
                            CalenderQueue.Calenderqueue(month_queue, year_queue);
                            break;

                        case 10:
                            Console.WriteLine("Enter month ");
                            int month_stack = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(" Enter year to display calender");
                            int year_stack = Convert.ToInt32(Console.ReadLine());
                            CalenderStack.Calenderstack(month_stack, year_stack);
                            break;

                        case 11:
                            PrimeAnagramTwoD.PrimeAnagram();
                            break;
                        case 12:
                            PrimeAnagramStack anagramStack = new PrimeAnagramStack();
                            anagramStack.Primeanagramstack();
                            break;

                        case 13:
                            PrimeAnagramQueue anagramQueue = new PrimeAnagramQueue();
                            anagramQueue.Primeanagram();
                            break;

                        case 14:
                            PrimeNumberTwoD prime = new PrimeNumberTwoD();
                            Console.WriteLine("Prime 2D array");
                            prime.Display();
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
