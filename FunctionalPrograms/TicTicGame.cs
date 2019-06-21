//-----------------------------------------------------------------------
// <copyright file="TicTicGame.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Tic game as class
    /// </summary>
    public class TicTicGame
    {
        /// <summary>
        /// GameForTicTic as method
        /// </summary>
        public static void GameForTicTic()
        {
            try
            {
                Utility utility = new Utility();
                utility.CrossGame();                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
