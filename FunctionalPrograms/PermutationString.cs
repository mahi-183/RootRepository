//-----------------------------------------------------------------------
// <copyright file="PermutationString.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Permutation String as class
    /// </summary>
   public class PermutationString
    {
        /// <summary>
        /// array of distinct string 
        /// </summary>
        //static String[] distinctPermutationStringArray = new String[10000];


        /// <summary>
        /// Permutation as function
        /// </summary>
        public static void Permutation()
        {
            try
            {
                string str = " ";
                Console.WriteLine("Enter the string:");
                str = Console.ReadLine();
                Utility u = new Utility();
                //stringPermutationObj.permute(inputString, 0, lenght - 1);
                u.FindPermutation(str);
                Console.WriteLine("Number of Distinct permutations are:"+ Utility.newlenght);
                Console.WriteLine("Distinct permutations are:");
                Console.WriteLine("[");
                for (int i = 0; i < Utility.newlenght; i++)
                {
                    Console.WriteLine(Utility.distinctPermutationStringArray[i] + "\t");
                }
                Console.WriteLine("]");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
