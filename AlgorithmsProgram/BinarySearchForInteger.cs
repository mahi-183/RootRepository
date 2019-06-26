//-----------------------------------------------------------------------
// <copyright file="BinarySearchForInteger.cs" company="Bridgelabz">
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
    /// BinarySearchForInteger as class
    /// </summary>
    public class BinarySearchForInteger
    {
        /// <summary>
        /// BinarySearchInteger as function
        /// </summary>
        
        public static void BinarySearchInteger()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Console.WriteLine("\n...........................Binary Search for Integer By recursive ....................\n");
                int[] array = { };             
                Utility.IntegerBinarySearch(array);
                sw.Stop();
                Console.WriteLine("Time Taken For Execution-->{0}", sw.ElapsedMilliseconds);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
