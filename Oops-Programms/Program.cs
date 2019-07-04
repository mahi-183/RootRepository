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
                int select;

                do
                {
                    Console.WriteLine("select from the following");
                    Console.WriteLine("1.Inventory\n");
                    Console.WriteLine("2.Regular Expression\n");
                    Console.WriteLine("3.Inventory Managment\n");
                    Console.WriteLine("4.Stock\n");
                    Console.WriteLine("5.Commercial Data Processing\n");
                    Console.WriteLine("6.Address Book\n");
                    Console.WriteLine("7.Deck of Cards\n");
                    Console.WriteLine("8.Deck of Cards using Queue implemented using linkedlist\n");


                    Console.WriteLine("Enter your choice");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            InventoryManagement.DisplayInventory inventorydisplay = new InventoryManagement.DisplayInventory();
                            inventorydisplay.Display ();
                            break;

                        case 2:
                            RegularExpression regularExpression = new RegularExpression();
                            regularExpression.Expression();
                            break;

                        case 3:
                            //InentoryManager inentoryManager = new InentoryManager();
                            //inentoryManager.Manage();
                            //break;

                        //case 4:
                        //    Stock stock = new Stock();
                        //    stock.StockReport();
                        //    break;

                        //case 5:
                        //    break;

                        //case 6:
                        //    AddressBook addressBook = new AddressBook();
                        //    addressBook.Book();
                        //    break;

                        //case 7:
                        //    DeckOfCards deckOfCards = new DeckOfCards();
                        //    deckOfCards.Cards();
                        //    break;

                        //case 8:
                        //    DeckOfCardsUsingQueue deckOfCardsUsingQueue = new DeckOfCardsUsingQueue();
                        //    deckOfCardsUsingQueue.CardInQueue();
                        //    break;

                        default:
                            Console.WriteLine("Invalid Choice..!!!");
                            break;
                    }
                    Console.WriteLine("Do you wants to continue...(Y/N)");
                    select = Convert.ToChar(Console.ReadLine());


                } while (select == 'Y' || select == 'y');

            }
            catch (Exception e)
            {
                Console.WriteLine("In Main of program" + e.Message);
            }
        }
    }
}
