//-----------------------------------------------------------------------
// <copyright file="VendingMachine.cs" company="Bridgelabz">
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
    /// VendingMachine as class
    /// </summary>
    public class VendingMachine
    {
        /// <summary>
        /// VendingMachineFunction as class
        /// </summary>
        public static void VendingMachineFunction()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                int amount = 0;
                Utility.VendingMachineMethod(amount);
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
