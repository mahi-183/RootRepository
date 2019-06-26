//-----------------------------------------------------------------------
// <copyright file="DecimalToBinary.cs" company="Bridgelabz">
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
    /// DecimalToBinary as class
    /// </summary>
    public class DecimalToBinary
    {
        /// <summary>
        /// DecimalToBinaryConversion as function
        /// </summary>
        public static void DecimalToBinaryConversion()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                Console.WriteLine("\n...........................Programme for convert Decimal Number To Binary Number....................\n");
                int number = 0;
                Utility.ToBinaryConversion(number);
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
