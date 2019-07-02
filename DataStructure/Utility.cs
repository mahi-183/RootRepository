//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
// <creator name="Mahesh Aurad"/>
//-----------------------------------------------------------------------

namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    /// <summary>
    /// Utility class which contains the all logic methods which performs various task
    /// </summary>
    class Utility
    {
        /// <summary>
        /// GetFilePath method for getting text fil path.
        /// </summary>
        /// <returns> file path</returns>
        public string GetFilePath()
        {
            string path = null;
            try
            {
                path = @"E:\ProgrammeFile\C#programmes\DataStructure\DataStructure\DataFile.txt";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return path;
        }

        /// <summary>
        /// GetFilePath method for getting text fil path of orderlist file.
        /// </summary>
        /// <returns> file path</returns>
       
        public string GetOrderedFilePath()
        {
            string path = null;
            try
            {
                path = @"E:\ProgrammeFile\C#programmes\DataStructure\DataStructure\OrderedListFile.txt";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return path;
        }

        /// <summary>
        /// StringArray is a method which is return the string array Converting the hole line into string array.
        /// </summary>
        /// <param name="text">The text parameter is hole line of word string.</param>
        /// <returns>array</returns>
        public string[] StringArray(string text)
        {
            string[] stringArray = new string[text.Length];

            //// seperating words to charachter
            foreach (int int1 in text)
            {
                stringArray = text.Split(' ').ToArray();
            }
            return stringArray;
        }

        /// <summary>
        /// IntegerArray is a method which is return the integer array Converting the hole line into integer array.
        /// </summary>
        /// <param name="text">The text parameter is hole line of word string.</param>
        /// <returns>array</returns>
        public int[] IntegerArray(string text)
        {
            string[] stringArray = new string[text.Length];

            //// seperating string to integer
            foreach (int int1 in text)
            {
                stringArray = text.Split(' ').ToArray();
            }
            int[] integerArray = Array.ConvertAll(stringArray, Int32.Parse);
            return integerArray;
        }

        /// <summary>
        /// Validation for input string
        /// </summary>
        /// <param name="str"> string parameter</param>
        /// <returns></returns>
        public bool IsAlphaNum(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            for (int i = 0; i < str.Length; i++)
            {
                if (!(char.IsLetter(str[i])) && (!(char.IsNumber(str[i]))))
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Validation for input Expression like { } $ @ & 
        /// </summary>
        /// <param name="str"> string parameter</param>
        /// <returns></returns>
        public bool IsExpression(string expression)
        {
            if (string.IsNullOrEmpty(expression))
                return false;
           // char[] charArray = expression.ToCharArray();
            for (int i = 0; i < expression.Length; i++)
            {
                if (   expression[i] == '@' || expression[i] == '$' || expression[i] == '&' || expression[i] == '~' ||
                       expression[i] == '{' || expression[i] == '}' || expression[i] == '[' || expression[i] == ']'
                    )
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Primes the anagram.
        /// </summary>
        /// <param name="range">The range.</param>
        /// <returns>int</returns>
        public static int[] PrimeAnagram(int range)
        {
            int index = 0;
            int[] array = new int[200];
            int[] anagram = new int[158];
            int count = 0;

            for (int i = 2; i < range; i++)
            {
                if (IsPrime(i))
                {
                    array[index] = i;
                    index++;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    string string1 = array[i].ToString();
                    string string2 = array[j].ToString();

                    if (IsAnagram(string1, string2))
                    {
                        count++;
                        anagram[count] = array[j];
                        count++;
                    }
                }
            }
            return anagram;
        }

        /// <summary>
        /// Determines whether the specified no is prime.
        /// </summary>
        /// <param name="no">The no.</param>
        /// <returns>
        ///   <c>true</c> if the specified no is prime; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPrime(int no)
        {

            for (int i = 2; i < no / 2; i++)
            {
                if (no % i == 0)
                {
                    return false;
                }

            }
            return true;
        }

        /// <summary>
        /// Determines whether the specified STR1 is anagram.
        /// </summary>
        /// <param name="str1">The STR1.</param>
        /// <param name="str2">The STR2.</param>
        /// <returns>
        ///   <c>true</c> if the specified STR1 is anagram; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsAnagram(string str1, string str2)
        {
            bool status = true;

            if (str1.Length != str2.Length)
            {
                status = false;
            }
            else
            {
                char[] array1 = str1.ToCharArray();
                char[] array2 = str2.ToCharArray();
                Array.Sort(array1);
                Array.Sort(array2);
                status = Equals(array1, array2);
            }
            if (status)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
