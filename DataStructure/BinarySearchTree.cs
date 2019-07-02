// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BinarySearchTree.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Mahesh Chidanand Aurad"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructure
{
    using System;

    /// <summary>
    /// class to find number of binary search tree
    /// </summary>
    public class BinarySearchTree
    {
        /// <summary>
        /// Binarysearches this instance.
        /// </summary>
        public void Binarysearch()
        {
            //to enter the limits so that they can find the possible node of numbers nth times.
            Console.WriteLine("Enter the limits :");
            int limit = Convert.ToInt32(Console.ReadLine());
            int[] number = new int[limit];
            //Loop will work till the entered numbers of limit.
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine("Enter a number:");
                number[i] = Convert.ToInt32(Console.ReadLine());

                //calling the method factnumber
                long x = Factnumber(number[i]);
                Console.WriteLine("Possible number of " + number[i] + " node is " + x);
            }
        }

        /// <summary>
        /// Factnumbers the specified number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>fact</returns>
        public static long Factnumber(int number)
        {
            long x = 2 * number;
            //Finding the value of x
            x = Factorial(x);

            long y = number + 1;
            //Finding the value of y					
            y = Factorial(y);

            //Finding the value 
            long z = Factorial(number);

            long possiblevalue = x / (y * z);
            return possiblevalue;
        }

        //method to find the factorial of a number
        public static long Factorial(long y)
        {
            long fact = 1;
            for (long i = 1; i <= y; i++)
            {
                fact = fact * i;
            }
            return fact;
        }


    }
}