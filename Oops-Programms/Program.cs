// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------


namespace Oops_Programms
{
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int YesOrNo;

                do
                {
                    Console.WriteLine("select from the following");
                    Console.WriteLine("1.Inventory\n");
                    Console.WriteLine("2.Regular Expression\n");
                    Console.WriteLine("3.Stock Report\n");
                    Console.WriteLine("4.Inventory Managment\n");
                    Console.WriteLine("5.Commercial Data Processing\n");
                    Console.WriteLine("6.Address Book\n");
                    Console.WriteLine("7.Deck of Cards\n");
                    Console.WriteLine("8.Deck of Cards using Queue implemented using linkedlist\n");


                    Console.WriteLine("Enter your choice");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            InventoryManager.InventoryManagerUtility.DisplayInventory ();
                            break;

                        case 2:
                            RegularExpression regularExpression = new RegularExpression();
                            regularExpression.Expression();
                            break;

                        case 3:
                            CompanyStock.StockReportClass stock = new CompanyStock.StockReportClass() ;
                            stock.StockReport();
                            break;

                        case 4:
                            InventoryManager.InventoryManager InventoryManagerObj = new InventoryManager.InventoryManager();
                            InventoryManagerObj.ManageInventory();
                            break;

                        case 5:
                            DataProceesing.StockAccount stockAccount = new DataProceesing.StockAccount();
                            stockAccount.DisplayDetails();
                            break;

                        case 6:
                        //    AddressBook addressBook = new AddressBook();
                        //    addressBook.Book();
                            break;

                        case 7:
                            DeckOfCards.DeckOfCard deckOfCards = new DeckOfCards.DeckOfCard();
                            deckOfCards.Cards();
                            break;

                        case 8:
                            DeckOfCards.DeckOfCardUsingQueue deckOfCardsUsingQueue = new DeckOfCards.DeckOfCardUsingQueue();
                            deckOfCardsUsingQueue.Cards();
                            break;

                        default:
                            Console.WriteLine("Invalid Choice..!!!");
                            break;
                    }
                    Console.WriteLine("Do you wants to continue...(Y/N)");
                    YesOrNo = Convert.ToChar(Console.ReadLine());


                } while (YesOrNo == 'Y' || YesOrNo == 'y');

            }
            catch (Exception e)
            {
                Console.WriteLine("In Main of program" + e.Message);
            }
        }
    }
}
