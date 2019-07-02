
using System.Collections;
namespace DataStructure
{
    using System;
    /// <summary>
    /// PrimeAnagrameTwoD is for check prime Number anagram or not
    /// </summary>
    public class PrimeAnagramTwoD
    {
        static string[,] primeAnagramArray = new string[13, 13];

        //created  ArrayList object primeList
        static ArrayList primeList = new ArrayList();
        //created ArrayList object anagramList
        static ArrayList anagramList = new ArrayList();

        //this method will check number is prime or not if yes then check for Anagram
        public static void PrimeAnagram()
        {
            bool flag = true;
            for (int i = 2; i <= 1000; i++)
            {
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        //if flag== false then its not a prime no.
                        flag = false;
                        //  break;
                    }
                }
                if (flag == true)
                    primeList.Add(i);

            }

            for (int i = 0; i < primeList.Count; i++)
            {
                for (int j = i + 1; j < primeList.Count; j++)
                {

                    if (Anagram(i, j))//anagram calling 
                    {

                        anagramList.Add(primeList[i]);
                    }
                }
            }
            //calling to storeElement()
            StoreElement();
            // calling to display()
            Display();
        }

        //this method is used for store elements in primeAnagramArray.
        public static void StoreElement()
        {
            int index = 0;
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 13; j++)
                {

                    primeAnagramArray[i, j] = anagramList[index].ToString();
                    index++;
                }
            }
        }

        //this method is used for display elements from primeAnagramArray.
        public static void Display()
        {
            for (int i = 0; i < primeAnagramArray.Length; i++)
            {
                for (int j = 0; j < primeAnagramArray.Length; j++)
                {
                    Console.WriteLine(primeAnagramArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //this method checks number is prime or not.
        public static bool Anagram(int n1, int n2)
        {
            int[] n1count = Counting(n1);
            int[] n2count = Counting(n2);
            for (int i = 0; i < n2count.Length; i++)
            {
                //if count of two numbers are not equal then 
                if (n1count[i] != n2count[i])
                {
                    return false;
                }
            }
            return true;
        }
        //this method is used for counting the digits of number.
        private static int[] Counting(int n1)
        {
            int[] count = new int[10];
            int temp = n1;
            while (temp != 0)
            {
                int rem = temp % 10;
                count[rem]++;
                temp = temp / 10;
            }
            return count;
        }
    }
}