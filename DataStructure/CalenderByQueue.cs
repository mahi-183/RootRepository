// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CalenderQueue.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Mahesh Chidanand Aurad"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructure
{
    using System;

    /// <summary>
    /// display Clander using Queue
    /// </summary>
    public class CalenderQueue
    {
        //calendar using queue
        public static void Calenderqueue(int month, int year)
        {
            string[] months = new string[]{ "January", "Februry", "March", "April", "May", "June", "July", "August", "September", "October",
                "November", "December" };

            Queue<string> q1 = new Queue<string>();

            // get d0 value hence upto d0 we will add null values

            int d = 1, y = year, m = month;

            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            Console.WriteLine("d0 is :" + d0);
            int start = d0;
            int totalDaysOfMonth = 0, count = 1;//days starts from 1,2,3

            if (month == 2)
            {
                if (IsLeapYear(year)) // if leap year days = 29
                    totalDaysOfMonth = 29;
                else
                    totalDaysOfMonth = 28; // if not leap year days= 28
            }
            else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                totalDaysOfMonth = 31;
            else
                totalDaysOfMonth = 30;

            while (start != 0)
            {
                q1.Enque("   ");//insert into queue and prints"_ "
                start--;
            }

            while (count <= totalDaysOfMonth)
            {
                q1.Enque(Convert.ToInt32(count) + "  "); // add data to the queue
                count++;
            }

            Console.WriteLine(months[month - 1] + " " + year);
            Console.WriteLine("Sun\tMon\tTue\tWed\tThu\tFri\tSat");
            count = 1;
            while (!q1.IsEmpty()) // traverse till queue is not empty
            {
                string result = q1.Deque();
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