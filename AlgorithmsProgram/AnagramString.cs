﻿//-----------------------------------------------------------------------
// <copyright file="AnagramString.cs" company="Bridgelabz">
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
    /// AnagramString as class
    /// </summary>
   public class AnagramString
    {
        /// <summary>
        /// CheckAnagram as function
        /// </summary>
        public static void CheckAnagram()
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                string m_FirstString = "", m_SecondString = "";

                Console.WriteLine("\n...........................Anagram Programme for String....................\n");
                Console.WriteLine("Enter the first string:");
                m_FirstString = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter the Second string:");
                m_SecondString = Convert.ToString(Console.ReadLine());

               /// calling a function to find given string is anagram or not
                Boolean m_IsAnagaram = Utility.AnagramFunction(m_FirstString, m_SecondString);

                if (m_IsAnagaram == true)
                {
                    Console.WriteLine("Given string " + m_FirstString + " and " + m_SecondString + " are Anagrame");
                }
                else
                {
                    Console.WriteLine("Given string " + m_FirstString + " and " + m_SecondString + " are not Anagrame");
                }

                stopwatch.Stop();
                Console.WriteLine("Time Taken for Execution-->{0} ", stopwatch.ElapsedMilliseconds + " ms");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
