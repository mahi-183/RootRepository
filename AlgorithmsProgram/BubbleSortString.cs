//-----------------------------------------------------------------------
// <copyright file="BubbleSortString.cs" company="Bridgelabz">
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
    /// BubbleSortString as class
    /// </summary>
    public class BubbleSortString
    {
        /// <summary>
        /// SortStringUsingBubbleSort as class
        /// </summary>
        public static void SortStringUsingBubbleSort()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                Console.WriteLine("\n...........................Bubble Sort for String by using IComaparable method....................\n");
                Utility.BubbleSortForString();
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
