//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmsProgram
{
    using System;

    /// <summary>
    /// Program as class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main is method
        /// </summary>
        /// <param name="args">args as parameter</param>
        public static void Main(string[] args)
        {
            try
            {
                int choice;
                char ch = 'Y';
                do
                {                    
                    Console.WriteLine("1. Anagram_String \n2. Prime_Number \n3. Extend_Pirme_Anagram_Palindrome_Number \n" +
                        "4. Binary_search_method_for_string \n5. InsertionSortForStrin_By_Using_IComparable_Program \n6. BubbleSortForString_Using_Comparable_Program \n7. BinarySearchWordList_Program" +
                        "\n9. MergeSortForString_Program" +
                        "\n10. VendingMachine_Program \n11. PrintDayofWeek_Program\n12. TemperatureConversion_Program " +
                        "\n13. MonthlyPaymentSlip_Program \n14. SquareRootFunction_Program \n15. DecimalToBinary_Program" +
                        "\n15. BinaryToDecimal_Program \n16. BinarySearchForInteger_At_Recursive_Program \n17. BinarySearchForString_programme"+
                        "\n18.insertionSortInteger_Programme \n19. insertionSortString_Programme \n20. bubbleSortInteger_Programme"+
                        "\n21. bubbleSortString_Programme");
                    Console.WriteLine("Enter your choice ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            AnagramString.CheckAnagram();
                            break;
                        case 2:
                            PrimeNumber.CheckPrimeNumber();
                            break;
                        case 3:
                            AnagramPalindromeNumber.AnagramPalindrome();
                            break;
                        case 4:
                            UtilityClass.binarySearchString(); 
                            break;
                        case 5:
                            InsertionSortAlgorithm.InsertionSortForString();
                            break;
                        case 6:
                            BubbleSortString.SortStringUsingBubbleSort();
                            break;
                        case 7:
                            BinarySearchWordList.FindWord();
                            break;
                        
                        case 8:
                            MergeSortForString.MergeSort();
                            break;
                        case 9:
                            VendingMachine.VendingMachineFunction();
                            break;
                        case 10:
                            PrintDayofWeek.PrintDay();
                            break;
                        case 11:
                            TemperatureConversion.TemperatureConversionFunction();
                            break;
                        case 12:
                            MonthlyPaymentSlip.MonthlyPayment();
                            break;
                        case 13:
                            SquareRootFunction.FindSquareRoot();
                            break;
                        case 14:
                            DecimalToBinary.DecimalToBinaryConversion();
                            break;
                        case 15:
                            BinaryToDecimal.BinaryToDecimalConversion();
                            break;
                        case 16:
                            BinarySearchForInteger.BinarySearchInteger();
                            break;
                        case 17:
                            UtilityClass.binarySearchInteger();
                            break;
                        case 18:
                            UtilityClass.insertionSortInteger();
                            break;
                        case 19:
                            UtilityClass.insertionSortString();
                            break;
                        case 20:
                            UtilityClass.bubbleSortInteger();
                            break;
                        case 21:
                            UtilityClass.bubbleSortString();
                            break;
                        default:
                            Console.WriteLine("Invalid case");
                            break;
                    }
                    Console.WriteLine("Enter Y / N For continue:");
                    ch = Convert.ToChar(Console.ReadLine());
                }
                while (ch != 'N');
                Console.WriteLine();  

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
