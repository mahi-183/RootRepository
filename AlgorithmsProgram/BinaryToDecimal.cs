//-----------------------------------------------------------------------
// <copyright file="BinaryToDecimal.cs" company="Bridgelabz">
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
    /// BinaryToDecimal as class
    /// </summary>
    public class BinaryToDecimal
    {
        /// <summary>
        /// BinaryToDecimalConversion as class
        /// </summary>
        public static void BinaryToDecimalConversion()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                Console.WriteLine("\n...........................Programme for convert Binary Number To Decimal Number....................\n");
                int number = 0;
                Utility.BinaryToDecimal(number);
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
