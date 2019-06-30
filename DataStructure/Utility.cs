﻿//-----------------------------------------------------------------------
// <copyright file="AnagramPalindromeNumber.cs" company="Bridgelabz">
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

    }
}
