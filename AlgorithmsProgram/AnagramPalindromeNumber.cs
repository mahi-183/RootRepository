//-----------------------------------------------------------------------
// <copyright file="AnagramPalindromeNumber.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmsProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Diagnostics;
    /// <summary>
    /// Anagram Palindrome Number as class
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
                Stopwatch sw = new Stopwatch();
                sw.Start();

                int number = 0;
                Console.WriteLine("\n...........................Extended Palindrome and Anagramme....................\n");
                Console.WriteLine("Enetr Number");
                Utility.FindAnagramPalindrome(number);


                sw.Stop();
                Console.WriteLine("Time Taken For Execution-->{0} ", sw.ElapsedMilliseconds + " ms");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
