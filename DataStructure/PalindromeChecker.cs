//-----------------------------------------------------------------------
// <copyright file="PalindromeChecker.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
// <creator name="Mahesh Aurad"/>
//-----------------------------------------------------------------------

namespace DataStructure
{
    using System;
    /// <summary>
    /// palindrome checker class is for check the string is palindrome or not
    /// </summary>
    class PalindromeChecker
    {
        public void CheckPalindrome()
        {
            bool isValid = false;
            string inputString = "";
            Utility utility = new Utility();
            Console.WriteLine("Enter the string");
            do {
                Console.WriteLine("ReEnter the string");
                inputString = Console.ReadLine();
                isValid = utility.IsAlphaNum(inputString);
            } while (isValid != true);


            DeQueueUtility<char> utilitydequeue = new DeQueueUtility<char>();

            //adding each character to the rear of the deque
            for (int i = 0; i < inputString.Length; i++)
            {
                char c = inputString[i];
                utilitydequeue.AddRear(c);
            }
            int flag = 0;

            while (utilitydequeue.Size() > 1)
            {
                if (utilitydequeue.RemoveFront() != utilitydequeue.RemoveRear())
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                Console.WriteLine("String is not palindrome");
            }
        }
    }
}
