//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmsProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Utility as class
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// AnagramFunction as function
        /// </summary>
        /// <param name="input1">input1 as parameter</param>
        /// <param name="input2">input2 as parameter</param>
        public static Boolean AnagramFunction(string m_FirstString, string m_SecondString)
        {
            Boolean m_IsAnagrame = true;
            try
            {
                
                int i = 0, count = 0;
                ///integer array which is used to check store the frequency of the charecter 
                int[] array = new int[26];

                ///if length of two string are not equal then it returns false
                if (m_FirstString.Length != m_SecondString.Length)
                {
                    return false;
                }

                
                ///while loop is for the first string which is used to find the 
                ///charecter and increment the that position of value by 1
                while (i < m_FirstString.Length)
                {
                    for (int j = 0; j < 26; j++)
                    {
                        ///case ignore logic
                        if ((m_FirstString[i] - 65 == j) || (m_FirstString[i] - 97 == j))
                        {
                            array[j]++;
                            break;
                        }

                    }
                    for (int k = 0; k < 26; k++)
                    {
                        ///case ignore logic
                        if ((m_SecondString[i] - 65 == k) || (m_SecondString[i] - 97 == k))
                        {
                            array[k]--;
                            break;
                        }
                    }
                    i++;
                }
                for (int j = 0; j < 26; j++)
                {
                    if (array[j] != 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    m_IsAnagrame=true;
                }
                else
                {
                    m_IsAnagrame = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return m_IsAnagrame;
        }

        /// <summary>
        /// FindPrimeNumber as function
        /// </summary>
        /// <param name="number">number as parameter</param>
        /// static array which stores the prime factors
        public static int[] prime_Array;
        public static void FindPrimeNumber(int number)
        {
            
            try
            {
                bool prime = true;
                Console.WriteLine("Print 0 to 1000 prime number");
               
                for (int outerLoopCounter = 2; outerLoopCounter <= number/2; outerLoopCounter++)
                {
                    for (int innerLoopCounter = 2; innerLoopCounter <= outerLoopCounter / 2; innerLoopCounter++)
                    {
                        if (outerLoopCounter % innerLoopCounter == 0)
                        {
                            prime = false;
                            break;
                        }
                    }

                    if (prime)
                    {
                        Console.Write("\t" + outerLoopCounter);
                    }

                    prime = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// FindAnagramPalindrome as method
        /// </summary>
        /// <param name="number">number as parameter</param>       
        public static void FindAnagramPalindrome(int number)
        {
            try
            {
                int reverse = 0, length = 0;
                Boolean prime = true;
                int[] prime_Array=new int[1000];
                int  remainder;
                number = Convert.ToInt32(Console.ReadLine());                
                if (number <= 0 )
                {
                    Console.WriteLine("Please enter the number should be positive");
                    FindAnagramPalindrome(number);
                }


                /// <summary>
                /// to get prime numbers and store it into prime_Array
                /// </summary>
                /// <param name="number">prime_Array[j] as parameter</param>  
                
                Console.WriteLine("Prime numbers between 0 to "+ number +" are:");
                for (int outerLoopCounter = 2; outerLoopCounter <= number; outerLoopCounter++)
                {
                    for (int innerLoopCounter = 2; innerLoopCounter <= outerLoopCounter / 2; innerLoopCounter++)
                    {
                        if (outerLoopCounter % innerLoopCounter == 0)
                        {
                            prime = false;
                            break;
                        }
                    }

                    if (prime)
                    {
                        prime_Array[length] = outerLoopCounter;
                        Console.Write(outerLoopCounter+ "\t");
                        length++;
                    }

                    prime = true;
                }

                /// <summary>
                /// FindPalindrome as method
                /// </summary>
                /// <param name="number">prime_Array[j] as parameter</param>

                Console.WriteLine("\n Prime palindrome numbers between 0 to " + number + " are:");
               
                for (int j=0; j< length; j++) {
                    int result = palindromeCalculate(prime_Array[j]);

                    if (prime_Array[j] == result)
                    {
                        Console.WriteLine(result + "\t");
                    }
                    //result = 0;
                }

                /// <summary>
                /// anagrammeChecker as method call
                /// </summary>
                /// <param name="number">prime_Array[j] as parameter</param>

                Console.WriteLine("\n Prime Anagramme numbers between 0 to " + number + " are:");

                for (int i = 0; i < length; i++)
                {
                    for (int j = 1; j < length - 1; j++) {
                        if (prime_Array[i] <= 9 || prime_Array[j] <= 9)
                        {

                        }
                        else if (prime_Array[i] == prime_Array[j]) {

                        } else {
                            Boolean result = anagrammeChecker(prime_Array[i], prime_Array[j]);
                            if (result == true)
                            {
                                Console.WriteLine("[" + prime_Array[i] + "," + prime_Array[j] + "]");

                            }
                        }
                    }
                }


                /// <summary>
                /// palindromeCalculate as method
                /// </summary>
                /// <param name="m_input_number"> as parameter</param>
                int palindromeCalculate(int m_input_number) {
                    reverse = 0;
                    while (m_input_number != 0)
                    {
                        remainder = m_input_number % 10;
                        m_input_number = m_input_number / 10;
                        reverse = (reverse * 10) + remainder;
                    }
                    return reverse;
                }


                /// <summary>
                /// anagrammeChecker as method
                /// </summary>
                /// <param name="m_input_number1"> as parameter</param>
                /// <param name="m_input_number2"> as parameter</param>
               
                Boolean anagrammeChecker(int m_input_number1,int m_input_number2)
                {
                    int[] freq_array=new int[10];
                    int freqCount = 0;
                    reverse = 0;
                    while (m_input_number1 != 0)
                    {
                        remainder = m_input_number1 % 10;
                        m_input_number1 = m_input_number1 / 10;
                        freq_array[remainder]++;
                    }
                    while (m_input_number2 != 0)
                    {
                        remainder = m_input_number2 % 10;
                        m_input_number2 = m_input_number2 / 10;
                        freq_array[remainder]--;
                    }
                    for (int i = 0; i < 10; i++) {
                        if (freq_array[i] != 0)
                        {
                            freqCount ++;
                            break;
                        }
                    }
                    if (freqCount == 0)
                    {
                        return true;
                    }
                    else {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// BinarySearchForString as function
        /// </summary>
        /// <param name="array">array as parameter</param>
        /// <param name="input">input as parameter</param>
        public static int BinarySearchForString(string[] array, string input)
        {
            int start = 0, end = array.Length - 1;
            int mid = 0, result = -1;

            while (start <= end)
            {
                mid = (start + end) / 2;
                char[] stringCharArray = array[mid].ToCharArray();
                char[] inputstringCharArray = input.ToCharArray();
                if (stringCharArray[0] == inputstringCharArray[0])
                {
                    int no = checkStringEqual(array[mid], input);
                    if ( no == 1) {
                        result = mid;
                        break;
                    }
                    
                }
                else if (inputstringCharArray[0] < stringCharArray[0])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
           
           
            return result+1;
        }
        /// <summary>
        /// checkStringEqual is a method to check input string is present or not
        /// </summary>
        /// <param name="arrayString">first paramerter is the string array element.</param>
        /// <param name="inputString">second string parameter is the serch element.</param>
        /// <returns></returns>
        public static int checkStringEqual(string arrayString, string inputString)
        {
            int icnt = 0, Result = 0 ;
            char[] arrayStringChar = arrayString.ToCharArray();
            char[] inputStringChar = inputString.ToCharArray();

            if (inputString.Length == arrayString.Length)
            {
                for (int i = 0; i < arrayString.Length; i++)
                {
                    if (arrayStringChar[i] != inputStringChar[i])
                    {
                        icnt++;
                        break;
                    }
                }

            }
            else
            {
                Result = -1;

            }
            if (icnt == 0)
            {
                Result = 1;
            }
            return Result;
        }
        /// <summary>
        /// BinarySearchForInteger as function
        /// </summary>
        /// <param name="array">array as parameter</param>
        /// <param name="input">input as parameter</param>
        public static int BinarySearchForInteger(int[] array, int input)
        {
            int start = 0, end = array.Length-1;
            int mid = 0, result = -1 ;

            while (start <= end) {
                mid = (start + end) / 2;
                if (array[mid] == input)
                {
                    result = mid;
                    break;
                }
                else if (input < array[mid])
                {
                    end = mid - 1;
                }
                else {
                    start = mid + 1;
                }
            }
            return result;
        }

        /// <summary>
        /// InsertionSortForInteger as function
        /// </summary>
        /// <param name="array">array as parameter</param>
        public static int[] InsertionSortForInteger(int[] array)
        { 
            int n = array.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = array[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], 
                // that are greater than key, 
                // to one position ahead of 
                // their current position 
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
            return array;
        }

        /// <summary>
        /// InsertionSortForString as function
        /// </summary>
        /// <param name="array">array as parameter</param>
        /// <param name="m_Searchinput">input as parameter</param>
        public static string[] InsertionSortForString(string[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                string firstString = array[i];
                char[] stringToCharArray1 = firstString.ToCharArray();

                for (int j = i; j < array.Length; j++)
                {
                    string temp = " ";
                    string secondString = array[j];
                    char[] stringToCharArray2 = secondString.ToCharArray();
                    if (stringToCharArray1[0] >= stringToCharArray2[0])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                        stringToCharArray1 = temp.ToCharArray();
                    }
                }
                /*    // Insert s[j] at its correct position 
                    int j = i - 1;
                    while (j >= 0 && temp.Length < array[j].Length)
                    {
                        array[j + 1] = array[j];
                        j--;
                    }
                    array[j + 1] = temp;
                */
            }
            return array;
        }

        /// <summary>
        /// bubbleSortForInteger as function
        /// </summary>
        /// <param name="array">array as parameter</param>

        public static int[] bubbleSortForInteger(int[] array)
        {
            //int[] sortArray;1
            int temp = 0;
            int length = array.Length;
            //sortArray = new string[length];
            for (int i = 0; i < length-1; i++)
            {
                for (int j = i+1; j < length; j++) {
                    if(array[i] > array[j]) {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        /// <summary>
        /// bubbleSortForString as function
        /// </summary>
        /// <param name="array">array as parameter</param>

        public static string[] bubbleSortForString(string[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                string firstString = array[i];
                char[] stringToCharArray1 = firstString.ToCharArray();

                for (int j = i; j < array.Length; j++)
                {
                    string temp = " ";
                    string secondString = array[j];
                    char[] stringToCharArray2 = secondString.ToCharArray();
                    if (stringToCharArray1[0] >= stringToCharArray2[0])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                        stringToCharArray1 = temp.ToCharArray();
                    }
                }
            }
            return array;
        }

        /// <summary>
        /// BinarySearchFromWordList as function
        /// </summary>
        /// <param name="word">word as parameter</param>
        /// <param name="line">line as parameter</param>
        public static void BinarySearchFromWordList(string word, string line)
        {
            int count = 0;
            int i = 0;
            string key = " ";
            string[] array = new string[i];

            for (i = 0; i < word.Length; i++)
            {
                if (key.Equals(array[i] == word))
                {
                    Console.WriteLine("String found" + key);
                }
                else if (count == 0)
                {
                    Console.WriteLine("Not found");
                    BinarySearchFromWordList(word, line);
                }
            }
        }


        /// <summary>
        /// SortStringUsingInsertionSort as function
        /// </summary>
        public static void SortStringUsingInsertionSort()
        {
            try
            {
                int i = 0, j = 0;
                int length = 0;
                Console.WriteLine("Enter length of the array");
                length = Convert.ToInt32(Console.ReadLine());
                IComparable[] list = new string[length];
                Console.WriteLine("Add word into array");
                for (i = 0; i < list.Length; i++)
                {
                    list[i] = string.Copy(Console.ReadLine());
                }

                for (i = 0; i < list.Length; i++)
                {
                    IComparable value = list[i];
                    j = i - 1;
                    while ((j >= 0) && list[j].CompareTo(value) > 0)
                    {
                        list[j + 1] = list[j];
                        j--;
                    }

                    list[j + 1] = value;
                }

                Console.WriteLine("Sorted String Array");
                {
                    IComparable newArray = list.Length;
                    for (i = 0; i < list.Length; ++i)
                    {
                        Console.WriteLine(list[i] + " ");
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// SortStringUsingMergeSort as function
        /// </summary>
        public static void SortStringUsingMergeSort()
        {
            try
            {
                int i = 0;
                int length = 0;
                Console.WriteLine("Enter length of the array");
                length = Convert.ToInt32(Console.ReadLine());
                string[] list = new string[length];
                Console.WriteLine("Add word into array");
                for (i = 0; i < list.Length; i++)
                {
                    list[i] = string.Copy(Console.ReadLine());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// DayOfWeek as function
        /// </summary>
        /// <param name="year">year sa parameter</param>
        /// <param name="month">month as parameter</param>
        /// <param name="date">date as parameter</param>
        public static void DayOfWeek(int year, int month, int date)
        {
            try
            {
                string[] dayofweek = { "Sunday", "Monday", "Tuesday", "Wensday", "Thursday", "Friday", "Saturday" };

                Console.WriteLine("Enter the year");
                year = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the month");
                month = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the date");
                date = Convert.ToInt32(Console.ReadLine());

                if (month > 12 || date > 31)
                {
                    Console.WriteLine("Invalid");
                }
                else
                {
                    int printday = dayofweek.Length;
                    int y0 = year - ((14 - month) / 12);
                    int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
                    int m0 = ((month + 12) * ((14 - month) / 12)) - 2;
                    int d0 = (date + x + 31) * (m0 / (12 % 7));
                    if (d0 <= printday)
                    {
                        Console.WriteLine("The day of week is " + dayofweek[d0]);
                        Console.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// TemperatureConversionMethod as function
        /// </summary>
        /// <param name="temperature">temperature as parameter</param>
        public static void TemperatureConversionMethod(int temperature)
        {
            try
            {
                Console.WriteLine("Enter Temperatur ");
                temperature = Convert.ToInt32(Console.ReadLine());
                int fahrenheit = 0;
                int celsius = 0;
                fahrenheit = (temperature * 9 / 5) + 32;
                Console.WriteLine("Celsius to Fahrenheit " + fahrenheit + "F");
                celsius = (temperature - 32) * 5 / 9;
                Console.WriteLine("Fahrenheit to Celsius " + celsius + "C");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// PaymentSlip as method
        /// </summary>
        /// <param name="amount">amount as parameter</param>
        /// <param name="year">year as parameter</param>
        /// <param name="rate">rate as parameter</param>
        public static void PaymentSlip(int amount, int year, int rate)
        {
            try
            {
                double n, r, payment;
                n = 12 * year;
                r = rate / (12 * 100);
                payment = amount * r / (1 - Math.Pow(1 + r, -n));
                Console.WriteLine(payment);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// VendingMachineMethod as function
        /// </summary>
        /// <param name="amount">amount as parameter</param>
        public static void VendingMachineMethod(int amount)
        {
            int[] notes = { 2000, 1000, 500, 300, 200, 100, 50, 5, 1 };
            int[] counter = new int[9];
            Console.WriteLine("Enter your amount");
            amount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 9; i++)
            {
                if (amount >= notes[i])
                {
                    counter[i] = amount / notes[i];
                    amount = amount - (counter[i] * notes[i]);
                }
            }

            Console.WriteLine("Total number of changed notes");
            for (int i = 0; i < 9; i++)
            {
                if (counter[i] != 0)
                {
                    Console.WriteLine("required changes {0} is {1} =" + (notes[i], counter[i]));
                    Console.ReadLine();
                }
            }
        }

        /// <summary>
        /// Square rootMethod as function
        /// </summary>
        /// <param name="number">number as parameter</param>
        public static void SquarerootMethod(int number)
        {
            double epsilon = 1e-15;
            Console.WriteLine("Enter Number");
            number = Convert.ToInt32(Console.ReadLine());
            int temp = number;
            if (number > 0)
            {
                while (Math.Abs(temp - (number / temp)) > (epsilon * temp))
                {
                    Console.WriteLine(temp);
                }
            }
            else
            {
                Console.WriteLine("Please Enter Positive Number");
                SquarerootMethod(number);
            }
        }

        /// <summary>
        /// ToBinaryConversion as function
        /// </summary>
        /// <param name="number">number as parameter</param>
        public static void ToBinaryConversion(int number)
        {
            try
            {
                Console.WriteLine("Enter number");
                number = int.Parse(Console.ReadLine());
                //int remainder;
                string result = " ";
                while (number >= 1)
                {
                    number = number / 2;
                    result += (number % 2).ToString();
                    
                }

                string binarynumber = " ";
                for (int i = result.Length - 1; i >= 0; i--)
                {
                    binarynumber = binarynumber + result[i];
                }

                Console.WriteLine("Binary number format is = " + binarynumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// BinaryToDecimal as function
        /// </summary>
        /// <param name="number">number as parameter</param>
        public static void BinaryToDecimal(int number)
        {
            try
            {
                int basevalue = 1;
                int temp;
                int decvalue = 0, num = 1, result;
                Console.WriteLine("Enter Number");
                number = int.Parse(Console.ReadLine());
                temp = number;

                for (int j = temp; j > 0; j = j / 10)
                {
                    result = j % 10;
                    if (num == 1)
                    {
                        basevalue *= 1;
                    }
                    else
                    {
                        basevalue *= 2;
                    }

                    decvalue = decvalue + (result * basevalue);
                    num++;
                }

                Console.WriteLine("Decimal to binary = " + decvalue);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// IntegerBinarySearch as function
        /// </summary>
        /// <param name="inputArray">array as parameter</param>
        public static void IntegerBinarySearch(int[] inputArray)
        {
            try
            {               
                int length;               
                Console.WriteLine("Enter length of the array");
                length = Convert.ToInt32(Console.ReadLine());
                inputArray = new int[length];
                Console.WriteLine("Enter array Element");
                for (int i = 0; i <= inputArray.Length - 1; i++)
                {
                    inputArray[i] = int.Parse(Console.ReadLine());
                }
                int temp = 0;
                for (int i = 0; i < inputArray.Length - 1; i++)
                {
                    for (int j = i+1; j <= inputArray.Length - 1; j++) {
                        if(inputArray[i] > inputArray[j]) {
                            temp = inputArray[i];
                            inputArray[i] = inputArray[j];
                            inputArray[j] = temp;
                        }
                        
                    }
                }

                ///sorted array element are
                Console.WriteLine("Sorted array:");
                for (int i = 0; i <= inputArray.Length - 1; i++)
                {
                    Console.WriteLine(inputArray[i]);
                }
                Console.WriteLine("Enter Search Element");
                    int search = int.Parse(Console.ReadLine());
                    //int low = 0;
                int min = 0;
                int max = inputArray.Length - 1;

                BinarySearchRecursive( inputArray, search, min,max);
              /*  int high = array.Length - 1;
                while (low <= high)
                {
                    int mid = (low + high - 1) / 2;
                    if (array[mid] == search)
                    {
                        Console.WriteLine(mid);
                    }

                    if (array[mid] < search) 
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }  
                    
                }*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
       static  void BinarySearchRecursive(int[] inputArray1, int key, int min, int max)
        {
            if (min > max)
            {
                Console.WriteLine("Element Not Found");
            }
            else
            {
                int mid = (min + max) / 2;
                if (key == inputArray1[mid])
                {
                    Console.WriteLine(inputArray1[mid] + "Element found at " + mid);
                }
                else if (key < inputArray1[mid])
                {
                    BinarySearchRecursive(inputArray1, key, min, mid - 1);
                }
                else
                {
                    BinarySearchRecursive(inputArray1, key, mid + 1, max);
                }
            }
        }

        /// <summary>
        /// BubbleSortForString as method
        /// </summary>
        public static void BubbleSortForString()
        {
            try
            {
                int i, l;
                int length = 0;
                IComparable temp;
                Console.WriteLine("Enter length of the array");
                length = Convert.ToInt32(Console.ReadLine());
                IComparable[] list = new string[length];
                Console.WriteLine("Add word into array");
                l = list.Length - 1;
                for (i = 0; i < list.Length; i++)
                {
                    list[i] = string.Copy(Console.ReadLine());
                }

                for (i = 0; i < l; i++)
                {
                    for (int j = 0; j < l - 1; j++)
                    {
                        if (list[j].CompareTo(list[j + 1]) > 0)
                        {
                            temp = list[j];
                            list[j] = list[j + 1];
                            list[j + 1] = temp;
                        }
                    }
                }

                Console.WriteLine("\n Sort Array");
               for (i = 0; i < l; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
