//-----------------------------------------------------------------------
// <copyright file="UtilityClass.cs" company="Bridgelabz">
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
    /// UtilityClass as class
    /// </summary>
    public class UtilityClass
    {
       
        /// <summary>
        /// Binary Search method for String as function
        /// </summary>
        public static void binarySearchString()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Console.WriteLine("\n...........................Binary Search for String ....................\n");
                int i = 0;              
                string[] array;
                string searchString = " ";
                Console.WriteLine("Enter the number of string:");
                int length = Convert.ToInt32(Console.ReadLine());
                array = new string[length];

                Console.WriteLine("Enter the string into string array:");

                for(i=0; i < array.Length; i++)
                {
                    array[i] = Console.ReadLine();
                }
                ///call for sorting method 

                array = Utility.InsertionSortForString(array);

                Console.WriteLine("After sorting the string array:");
                for (i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
                Console.WriteLine("Enter the string you want to search:");
                searchString = Console.ReadLine();

               int result = Utility.BinarySearchForString(array, searchString);

                if (result != -1)
                {
                    Console.WriteLine(searchString + " Found At Position " + result);
                }
                else {
                    Console.WriteLine(" String Not Found ..! ");
                }
                sw.Stop();
                Console.WriteLine("Time Taken For Execution-->{0} ", sw.ElapsedMilliseconds+" ms");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// SortMethod for integer as a function
        /// </summary>
        public static void binarySearchInteger()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Console.WriteLine("\n...........................Binary Search for Integer....................\n");
                int i = 0;
                int[] array = new int[i];
                int m_searchInput=0;

                Console.WriteLine("Enter the length of the array:");
                int m_lengthOfArray = Convert.ToInt32(Console.ReadLine());

                array = new int[m_lengthOfArray];

                Console.WriteLine("Enter the elements into array:");
                for (i = 0; i < m_lengthOfArray; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Entered elements of integer array are:");
                for (i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
                
                //call for BubbleSortForInteger method 

                array = Utility.bubbleSortForInteger(array);

                Console.WriteLine("Sorted Array is:");
                for (i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }

                Console.WriteLine("Enter the element you want search:");
                m_searchInput = Convert.ToInt32(Console.ReadLine());

                //call for BinarySearchForInteger method
                int m_position=Utility.BinarySearchForInteger(array, m_searchInput);

                if (m_position == -1)
                {
                    Console.WriteLine(m_searchInput + " Not Found ");
                }
                else {
                    Console.WriteLine(m_searchInput + " Found At " + m_position);
                }
                sw.Stop();
                Console.WriteLine("Time Taken For Execution-->{0} ", sw.ElapsedMilliseconds);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Insertion method for integer as a function
        /// </summary>
        public static void insertionSortInteger()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Console.WriteLine("\n...........................Insertion method for Integer....................\n");
                int i = 0;
                int[] array;
                int m_lengthOfArray;

                Console.WriteLine("Enter the length of the array:");
                m_lengthOfArray = Convert.ToInt32(Console.ReadLine());

                array = new int[m_lengthOfArray];

                Console.WriteLine("Enter the elements into array:");
                for (i = 0; i < m_lengthOfArray; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Before sorting the array:");
                for (i = 0; i < m_lengthOfArray; i++)
                {
                    Console.WriteLine("\t" + array[i]);
                }

                ///call for Insertion sort method
                array =Utility.InsertionSortForInteger(array);

                Console.WriteLine("After sorting the array:");
                for (i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("\t" + array[i]);
                }
                sw.Stop();
                Console.WriteLine("Time Taken For Execution-->{0} ", sw.ElapsedMilliseconds);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// insertionSortString for  as a function
        /// </summary>
        public static void insertionSortString()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Console.WriteLine("\n...........................Insertion sort method for String....................\n");
                
                string[] array;
                //string searchString = " ";

                Console.WriteLine("Enter the length of the string array:");
                int length = Convert.ToInt32(Console.ReadLine());
                array = new string[length];

                Console.WriteLine("Enter the string into string array:");
                for (int i = 0; i < array.Length; i++) {
                    array[i] = Console.ReadLine();
                }
                Console.WriteLine("Before sorting the string array:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }

                array = Utility.InsertionSortForString(array);

                Console.WriteLine("After sorting the string array:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
                sw.Stop();
                Console.WriteLine("Time Taken For Execution-->{0} ", sw.ElapsedMilliseconds);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// bubbleSortInteger for  as a function
        /// </summary>
        public static void bubbleSortInteger()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Console.WriteLine("\n...........................Insertion method for Integer....................\n");

                int i = 0, m_lengthOfArray = 0;
                int[] array;

                Console.WriteLine("Enter the length of the array:");
                m_lengthOfArray = Convert.ToInt32(Console.ReadLine());

                array = new int[m_lengthOfArray];
                Console.WriteLine("Enter the elements into array:");
                for(i =0; i < m_lengthOfArray; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine()); 
                }

                Console.WriteLine("Before sorting the array:");
                for (i = 0; i < m_lengthOfArray; i++)
                {
                    Console.WriteLine("\t"+array[i]);
                }

                array = Utility.bubbleSortForInteger(array);

                Console.WriteLine("After sorting the array:");
                for (i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("\t" + array[i]);
                }
                sw.Stop();
                Console.WriteLine("Time Taken For Execution-->{0}", sw.ElapsedMilliseconds);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// insertionSortString for  as a function
        /// </summary>
        public static void bubbleSortString()
        {
            
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Console.WriteLine("\n...........................Bubble Sort method for String....................\n");
                int i = 0;

                Console.WriteLine("Enter the length of the string array:");
                int m_lengthOfArray = Convert.ToInt32(Console.ReadLine());

                string[] array = new string[m_lengthOfArray];

                Console.WriteLine("Enter the string into string array:");
                for (i = 0; i < m_lengthOfArray; i++)
                {
                    array[i] = Console.ReadLine();
                }

                Console.WriteLine("Before sorting the string array:");
                for (i = 0; i < m_lengthOfArray; i++)
                {
                    Console.WriteLine("\t" + array[i]);
                }

                array = Utility.bubbleSortForString(array);


                Console.WriteLine("After sorting the string array:");
                for (i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("\t" + array[i]);
                }
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
