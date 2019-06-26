//-----------------------------------------------------------------------
// <copyright file="MergeSortForString.cs" company="Bridgelabz">
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
    /// MergeSortForString as class
    /// </summary>
   public class MergeSortForString
    {
        /// <summary>
        /// MergeSort as parameter
        /// </summary>
        public static void MergeSort()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                Utility.SortStringUsingMergeSort();

                sw.Stop();
                Console.WriteLine("Time Taken For Execution-->{0} ", sw.ElapsedMilliseconds);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
