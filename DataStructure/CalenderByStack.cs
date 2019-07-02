// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CalenderStack.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Mahesh Chidanand Aurad"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructure
{
    using System;

    /// <summary>
    /// class to display Clander using Stack
    /// </summary>
    public class CalenderStack
    {
        /// <summary>
        /// Calenderstacks the specified month.
        /// </summary>
        /// <param name="month">The month.</param>
        /// <param name="year">The year.</param>
        public static void Calenderstack(int month, int year)
        {

            string[] months = new string[] { "January", "Februry", "March", "April", "May", "June", "July", "August", "September", "October",
                "November", "December" };

            Stack<string> stack = new Stack<string>();

            int d = 1, y = year, m = month;

            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            Console.WriteLine("d0 is :" + d0);
            int start = d0;
            int totalDaysOfMonth = 0, count = 1;//days starts from 1,2,3

            ///check if leap year
            if (month == 2)
            {
                if (IsLeapYear(year))
                {
                    totalDaysOfMonth = 29;
                }
                else
                {
                    totalDaysOfMonth = 28;
                }
            }

            else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                totalDaysOfMonth = 31;
            }
            else
            {
                totalDaysOfMonth = 30;
            }

            while (start != 0)
            {
                stack.push("  ");
                start--;
            }

            while (count <= totalDaysOfMonth)
            {
                stack.push(Convert.ToInt32(count) + " ");
                count++;
            }

            Console.WriteLine(months[month - 1] + "  " + year);
            Console.WriteLine("Sun\tMon\tTue\tWed\tThu\tFri\tSat");
            count = 1;
            while (!stack.isEmpty())
            {
                string result = stack.Pop();
                Console.Write(result + "\t");

                if (count % 7 == 0)
                {
                    Console.WriteLine();
                }
                count++;
            }
        }

        private static bool IsLeapYear(int year)
        {
            if ((year % 4 == 0) && (year % 100 != 0)) return true;
            if (year % 400 == 0) return true;
            return true;
        }
    }
}