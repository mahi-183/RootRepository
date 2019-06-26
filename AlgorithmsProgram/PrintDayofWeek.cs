//-----------------------------------------------------------------------
// <copyright file="PrintDayofWeek.cs" company="Bridgelabz">
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
    /// Print Day of Week as class
    /// </summary>
    public class PrintDayofWeek
    {
        /// <summary>
        /// PrintDay as function
        /// </summary>
        public static void PrintDay()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                int year = 0, month = 0,  day = 0;
                Utility.DayOfWeek(year, month, day);
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
