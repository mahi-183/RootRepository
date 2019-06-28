//-----------------------------------------------------------------------
// <copyright file="AnagramPalindromeNumber.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
// <creator name="Mahesh Aurad"/>
//-----------------------------------------------------------------------

namespace DataStructure
{

    using System;

    /// <summary>
    /// Node class which creates a Node of the linkedList
    /// </summary>
    ///<typeparam name="T"> word </typeparam>
    public class Node<T>
    {
        public Node<T> next;
        public T Data;
        internal T word;

        public Node(T Data)
        {
            this.Data = Data;
            this.next = null;
        }
    }
}
