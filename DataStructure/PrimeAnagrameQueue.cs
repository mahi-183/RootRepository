
//-----------------------------------------------------------------------
// <copyright file="PrimeAnagramQueue.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
// <creator name="Mahesh Aurad"/>
//-----------------------------------------------------------------------

namespace DataStructure
{
    using System;
    /// <summary>
    /// PrimeAnagrameQueue is class for primeAnagrameChecker
    /// </summary>
    public class PrimeAnagramQueue
    {
        /// <summary>
        /// Primeanagram methosd is for checking the prime number is anagrame or not
        /// </summary>
        public void Primeanagram()
        {
            Queue<int> queue = new Queue<int>();
            //calling prime Anagram method to check prime and anagram.
            int[] res = Utility.PrimeAnagram(1000);
            for (int i = 0; i < res.Length; i++)
            {
                //add elements in queue
                queue.Enque(res[i]);
               
            }
            
            //display queue
            queue.Display();
        }
    }
}