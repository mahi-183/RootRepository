﻿//-----------------------------------------------------------------------
// <copyright file="PrimeNumber.cs" company="Bridgelabz">
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
    /// PrimeNumber as class
    /// </summary>
    public class PrimeNumber
    {
        /// <summary>
        /// CheckPrimeNumber as function
        /// </summary>
        public static void CheckPrimeNumber()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                int number = 1000;
                Console.WriteLine("\n...........................Extended Palindrome....................\n");
                Utility.FindPrimeNumber(number);

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