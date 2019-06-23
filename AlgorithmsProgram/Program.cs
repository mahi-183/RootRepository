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
                        "4. Binary_search_method_for_string \n5. InsertionSortAlgorithm_Program \n6. BubbleSortString_Program \n7. BinarySearchWordList_Program" +
                        "\n8. InsertionSortAlgorithm_Program \n9. BubbleSort_Program \n10. MergeSortForString_Program" +
                        "\n11. VendingMachine_Program \n12. PrintDayofWeek_Program\n13. TemperatureConversion_Program " +
                        "\n14. MonthlyPaymentSlip_Program \n15. SquareRootFunction_Program \n16. DecimalToBinary_Program" +
                        "\n17. BinaryToDecimal_Program \n18. BinarySearchForInteger_Program  \n19. BubbleSort_Program");
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
                            UtilityClass.SortMethod(); 
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
                            InsertionSortAlgorithm.InsertionSortForString();
                            break;
                        case 9:
                            BubbleSort.BubbleSortAlgorithm();
                            break;
                        case 10:
                            MergeSortForString.MergeSort();
                            break;
                        case 11:
                            VendingMachine.VendingMachineFunction();
                            break;
                        case 12:
                            PrintDayofWeek.PrintDay();
                            break;
                        case 13:
                            TemperatureConversion.TemperatureConversionFunction();
                            break;
                        case 14:
                            MonthlyPaymentSlip.MonthlyPayment();
                            break;
                        case 15:
                            SquareRootFunction.FindSquareRoot();
                            break;
                        case 16:
                            DecimalToBinary.DecimalToBinaryConversion();
                            break;
                        case 17:
                            BinaryToDecimal.BinaryToDecimalConversion();
                            break;
                        case 18:
                            BinarySearchForInteger.BinarySearchInteger();
                            break;
                        case 19:
                            BubbleSort.BubbleSortAlgorithm();
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
