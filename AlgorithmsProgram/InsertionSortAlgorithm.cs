//-----------------------------------------------------------------------
// <copyright file="InsertionSortAlgorithm.cs" company="Bridgelabz">
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
    /// InsertionSortAlgorithm as class
    /// </summary>
   public class InsertionSortAlgorithm
    {
        /// <summary>
        /// InsertionSortForString as function
        /// </summary>
        public static void InsertionSortForString()
        {
            try {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                Console.WriteLine("\n...........................Insertion Sort for String by using IComaparable method....................\n");
                Console.WriteLine("Enter length of the array");
                int length = Convert.ToInt32(Console.ReadLine());

                Utility.SortStringUsingInsertionSort();

                sw.Stop();
                Console.WriteLine("Time Taken For Execution-->{0} ", sw.ElapsedMilliseconds + " ms");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
