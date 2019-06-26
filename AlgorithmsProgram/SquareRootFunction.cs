//-----------------------------------------------------------------------
// <copyright file="SquareRootFunction.cs" company="Bridgelabz">
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
    /// SquareRootFunction as class
    /// </summary>
    public class SquareRootFunction
    {
        /// <summary>
        /// FindSquareRoot of function
        /// </summary>
        public static void FindSquareRoot()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Console.WriteLine("\n...........................Programme for finding squar root ....................\n");
                int number = 0;
                Utility.SquarerootMethod(number);
                sw.Stop();
                Console.WriteLine("Time Taken For Execution -->{0} ", sw.ElapsedMilliseconds);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
