//-----------------------------------------------------------------------
// <copyright file="PrumeAnagrameStack.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
// <creator name="Mahesh Aurad"/>
//-----------------------------------------------------------------------
namespace DataStructure
{
    using System;

    /// <summary>
    /// check numbers that are prime and anagram using stack
    /// </summary>
    public class PrimeAnagramStack
    {
        public void Primeanagramstack()
        {
            Stack<int> stack = new Stack<int>();

            int[] res = Utility.PrimeAnagram(50);

            for (int i = res.Length - 1; i >= 0; i--)
            {
                stack.push(res[i]);
            }
            stack.Display();
        }
    }
}

