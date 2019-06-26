//-----------------------------------------------------------------------
// <copyright file="TemperatureConversion.cs" company="Bridgelabz">
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
    /// TemperatureConversion as class
    /// </summary>
    public class TemperatureConversion
    {
        /// <summary>
        /// TemperatureConversionFunction as method
        /// </summary>
        public static void TemperatureConversionFunction()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                int temperatur = 0;
                Console.WriteLine("------------------------------------Temperature Conversion Programme-----------------------------------");
                Utility.TemperatureConversionMethod(temperatur);

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
