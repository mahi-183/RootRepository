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
    /// 
    /// </summary>

    public class Dequeue<E>
    {

        public E data;
        public Dequeue<E> next;
        public Dequeue<E> pre;

        public Dequeue()
        {
            next = null;
            pre = null;
        }

        public Dequeue(E value)
        {
            data = value;
            next = null;
            pre = null;
        }
    }

}
