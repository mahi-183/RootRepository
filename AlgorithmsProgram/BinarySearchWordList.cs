//-----------------------------------------------------------------------
// <copyright file="BinarySearchWordList.cs" company="Bridgelabz">
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
    /// BinarySearchWord_List as class
    /// </summary>
    public class BinarySearchWordList
    {
        /// <summary>
        /// FindWord as function
        /// </summary>
        public static void FindWord()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                string path = "C:/Users/admin/source/repos/AlgorithmsProgram/AlgorithmsProgram/wordList.txt";
                Console.WriteLine(path);
                Console.WriteLine("Enter search word");
                string word = Convert.ToString(Console.ReadLine());
                Utility.BinarySearchFromWordList(path, word);

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
