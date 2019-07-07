// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeckOfCardUsingQueue.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------



namespace Oops_Programms.DeckOfCards
{

    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// implents DeckOfCard queue using linked list
    /// </summary>
    class DeckOfCardUsingQueue
    {
        public void Cards()
        {
            try
            {
                Node<string>[] head; 
                DeckOfCardsUtility cardsUtility = new DeckOfCardsUtility();
                //// Storing the card inside the array
                cardsUtility.CardsDistributeUsingQueue();
                Console.WriteLine("Player1 \t Player2 \t Player3 \t Player4");
                Console.WriteLine();
                //int count1 = 0;
                //int count2 = 0;
                cardsUtility.DisplayCardList();
                ////// Loops over to store 9 cards for each palyer
                //for (int i = 0; i < 9; i++)
                //{
                //    for (int j = 0; j < 4; j++)
                //    {
                //        //// Prints the card
                //        Console.Write(playercard[count1, count2] + " \t ");
                //        count2++;
                //        if (count2 == 9)
                //        {
                //            count2 = 0;
                //            count1++;
                //        }
                //    }

                //    Console.WriteLine();
                //}

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
