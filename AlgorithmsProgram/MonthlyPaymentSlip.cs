//-----------------------------------------------------------------------
// <copyright file="MonthlyPaymentSlip.cs" company="Bridgelabz">
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
    /// MonthlyPaymentSlip as class
    /// </summary>
   public class MonthlyPaymentSlip
    {
        /// <summary>
        /// monthlyPayment as function
        /// </summary>
        public static void MonthlyPayment()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Console.WriteLine("\n...........................Programme Of Monthly Payment ....................\n");
                Console.WriteLine("Enter amount");
                int amount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter number of years");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter rate of interest");
                int rate = Convert.ToInt32(Console.ReadLine());
                Utility.PaymentSlip(amount, year, rate);
               
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
