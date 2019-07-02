// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Calender.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Mahesh Chidanand Aurad"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructure
{
    using System;

    /// <summary>
    /// displays the Calender of the specified month and year 
    /// </summary>
    public class Calender
    {
        public static int[,] arr = new int[5, 7];
        public static int[] month = { 31, 29, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30 };

        /// <summary>
        /// Initials this instance.
        /// </summary>
        public static void Initial()
        {
            try
            {
                int x = arr.GetLength(0);
                int y = arr.GetUpperBound(1);

                Console.WriteLine("Upper Bound" + x + "\nLower bound in intial " + y);

                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        arr[i, j] = -10;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("In initial " + e.Message);
            }

        }

        /// <summary>
        /// Displays the specified m.
        /// </summary>
        /// <param name="m">The m.</param>
        public static void Display(int m)
        {
            try
            {
                Console.WriteLine("	sun  	mon  	tue  	wed  	thu   	sat  	sun");
                int uBound0 = arr.GetLength(0);
                int uBound1 = arr.GetLength(1);

                Console.WriteLine("Upper Boundddddd" + uBound0 + "\nLower bound in intialllll " + uBound1);

                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < uBound0; j++)
                    {
                        if (arr[i, j] < 0 || arr[i, j] > month[m - 1])
                        {
                            Console.Write("\t");
                        }
                        else if (arr[i, j] > 0)
                        {
                            Console.Write("\t" + arr[i, j] + " ");
                        }
                    }

                    Console.WriteLine("\t");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Display Calender month" + e.Message);
            }
        }

        public static void DisplayCalender(int day)
        {
            try
            {
                int d1 = 1;
                int uBound0 = arr.GetUpperBound(0);
                int uBound1 = arr.GetUpperBound(1);

                Console.WriteLine("Upper Boundddddd" + uBound0 + "\nLower bound in intialllll " + uBound1);

                for (int i = day; i < uBound0; i++)
                {
                    arr[0, i] = d1;
                    d1++;
                }

                for (int i = 1; i < arr.Length; i++)
                {
                    for (int j = 0; j < uBound0; j++)
                    {
                        arr[i, j] = d1;
                        d1++;
                    }
                }
            }
            ///catch block
            catch (Exception e)
            {
                Console.WriteLine("DisplayCalender" + e.Message);
            }
        }

        public static void Display(int month, int year)
        {
            try
            {
                int day = DayOfWeek(month, year);
                Console.WriteLine("day is " + day);
                Initial();

                DisplayCalender(day);
                ///method to display moth
                Display(month);
            }
            catch (Exception e)
            {
                Console.WriteLine("Displayyyy" + e.Message);
            }
        }

        public static int DayOfWeek(int month, int year)
        {

            int day = 1;
            int year0, x, month0, d0;

            year0 = year - (14 - month) / 12;
            x = year0 + (year0 / 4) - (year0 / 100) + (year0 / 400);
            month0 = month + 12 * ((14 - month) / 12) - 2;
            return d0 = (day + x + 31 * month0 / 12) % 7;
        }

    }
}
