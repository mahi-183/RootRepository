// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeckOfCardsUtility.cs" company="Bridgelabz">
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
    /// 
    /// </summary>
    class DeckOfCardsUtility
    {

        /// <summary>
        /// Cards the distribute.
        /// </summary>
        /// <returns></returns>
        public string[,] CardsDistribute()
        {
            string[,] playercard = new string[4, 9];
            try
            {
                ////creating string array 
                string[,] arrary1 = new string[4, 13];
                CardInsert(arrary1);
                CardShuffle(arrary1);
                ////creating the playcard string array

                //// Looping over the playcards
                for (int i = 0; i < playercard.GetLength(0); i++)
                {
                    for (int j = 0; j < playercard.GetLength(1); j++)
                    {
                        playercard[i, j] = arrary1[i, j];
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            return playercard;
        }

        /// <summary>
        /// Cards the insert.
        /// </summary>
        /// <param name="array1">The array1.</param>
        public static void CardInsert(string[,] array1)
        {
            try
            {
                //// creating string array of suits
                string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
                //// creating string array of ranks
                string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "King", "Queen", "Ace" };
                ////loooping the lengthof the suite
                for (int i = 0; i < array1.GetLength(0); i++)
                {
                    for (int j = 0; j < array1.GetLength(1); j++)
                    {
                        array1[i, j] = suits[i] + " " + rank[j];
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Cards the shuffle.
        /// </summary>
        /// <param name="array1">The array1.</param>
        public static void CardShuffle(string[,] array1)
        {
            try
            {
                //// creating the random object
                Random random = new Random();
                for (int i = 0; i < 20; i++)
                {
                    ////Generating randome numbers
                    int x1 = Convert.ToInt32(random.Next(4));
                    int x2 = Convert.ToInt32(random.Next(13));
                    int x3 = Convert.ToInt32(random.Next(4));
                    int x4 = Convert.ToInt32(random.Next(13));
                    Swap(array1, x1, x2, x3, x4);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Swaps the specified array1.
        /// </summary>
        /// <param name="array1">The array1.</param>
        /// <param name="x1">The x1.</param>
        /// <param name="x2">The x2.</param>
        /// <param name="x3">The x3.</param>
        /// <param name="x4">The x4.</param>
        public static void Swap(string[,] array1, int x1, int x2, int x3, int x4)
        {
            try
            {
                //// Swapping of strings
                string temp = array1[x1, x2];
                array1[x1, x2] = array1[x3, x4];
                array1[x3, x4] = temp;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Cards the distribute.
        /// </summary>
        /// <returns></returns>
        public void CardsDistributeUsingQueue()
        {
            string[,] playercard = new string[4, 9];
            try
            {
                ////creating string array 
                string[,] arrary1 = new string[4, 13];
                CardInsert(arrary1);
                CardShuffle(arrary1);
                ////creating the playcard string array

                //// Looping over the playcards
                for (int i = 0; i < playercard.GetLength(0); i++)
                {
                    for (int j = 0; j < playercard.GetLength(1); j++)
                    {
                        playercard[i, j] = arrary1[i, j];
                        insertLast(playercard[i, j],i);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        static Node<string>[] Player = new Node<string>[4];
        public void insertLast(string card,int position)
        {
            try
            {
               
                Node<string> tempNode = Player[position];
                Node<string> newNode = new Node<string>(card);
                if(tempNode == null)
                {
                    Player[position] = newNode;
                }
                else
                {
                    while(tempNode.next!=null)
                    {
                        tempNode = tempNode.next;
                    }
                    tempNode.next = newNode;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DisplayCardList()
        {
            try
            {

                for(int i =0; i < 4; i++)
                {
                    Node<string> tempNode = Player[i];
                    Console.Write("|" + "Player" + i + "|->");
                    while (tempNode != null)
                    {
                        Console.Write("|" + tempNode.Data + "|->");
                        tempNode = tempNode.next;
                    }
                    Console.WriteLine();
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
