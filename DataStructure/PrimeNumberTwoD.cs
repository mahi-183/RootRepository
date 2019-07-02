// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeNumbersTwoD.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Nikita Shriram C"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructure
{
    using System;

    public class PrimeNumberTwoD
    {
        public static int[,] primeArray = new int[10, 26];

        public static int Prime(int no)
        {

            int flag = 0;

            for (int i = 2; i < no / 2; i++)
            {
                if (no % i == 0)
                {
                    flag = 1;
                }
            }
            return flag;
        }

        public void Display()
        {
            int first = 0, second = 0, third = 0, fourth = 0, fifth = 0, sixth = 0, seventh = 0, eighth = 0, nineth = 0, tenth = 0;


            for (int i = 2; i < 1000; i++)
            {
                if (Prime(i) == 0)
                {
                    if (i > 0 && i <= 100)
                    {
                        primeArray[0, first] = i;
                        first++;
                    }
                    else if (i > 101 && i <= 200)
                    {
                        primeArray[1, second] = i;
                        second++;
                    }
                    else if (i > 201 && i <= 300)
                    {
                        primeArray[2, third] = i;
                        third++;
                    }
                    else if (i > 301 && i <= 400)
                    {
                        primeArray[3, fourth] = i;
                        fourth++;
                    }
                    else if (i > 401 && i <= 500)
                    {
                        primeArray[4, fifth] = i;
                        fifth++;
                    }
                    else if (i > 501 && i <= 600)
                    {
                        primeArray[5, sixth] = i;
                        sixth++;
                    }
                    else if (i > 601 && i <= 700)
                    {
                        primeArray[6, seventh] = i;
                        seventh++;
                    }
                    else if (i > 701 && i <= 800)
                    {
                        primeArray[7, eighth] = i;
                        eighth++;
                    }
                    else if (i > 801 && i <= 900)
                    {
                        primeArray[8, nineth] = i;
                        nineth++;
                    }
                    else if (i > 901 && i <= 1000)
                    {
                        primeArray[9, tenth] = i;
                        tenth++;
                    }

                }
            }

            int rowlength = primeArray.GetLength(0);
            int collength = primeArray.GetLength(1);
            for (int i = 0; i < rowlength; i++)
            {
                for (int j = 0; j < collength; j++)
                {
                    Console.Write(primeArray[i, j] + " ");
                }
            }

        }

    }
}
