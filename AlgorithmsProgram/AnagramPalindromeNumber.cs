//-----------------------------------------------------------------------
// <copyright file="AnagramPalindromeNumber.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmsProgram
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// To check whether given number is palindrome and anagram
    /// </summary>
    public class AnagramPalindromeNumber
    {
        /// <summary>
        /// AnagramPalindrome as function
        /// </summary>
        public static void AnagramPalindrome()
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                int number = 0;
                Console.WriteLine("\n...........................Extended Palindrome and Anagramme....................\n");
                Console.WriteLine("Enter Number");
                Utility.FindAnagramPalindrome(number);


                stopwatch.Stop();
                Console.WriteLine("Time Taken For Execution-->{0} ", stopwatch.ElapsedMilliseconds + " ms");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
