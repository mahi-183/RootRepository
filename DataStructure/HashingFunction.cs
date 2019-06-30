//-----------------------------------------------------------------------
// <copyright file="HashingFunction.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
// <creator name="Mahesh Aurad"/>
//-----------------------------------------------------------------------

namespace DataStructure
{
    using System;
    using System.IO;
    /// <summary>
    /// hashing class is for hashing the number
    /// </summary>
    class HashingFunction
    {
        public void hashingFunction()
        {
            try
            {
                Utility utility = new Utility();

                string path = utility.GetOrderedFilePath();
                Hashingutility<int> hashlist = new Hashingutility<int>();

                string textFile = File.ReadAllText(path);
                Console.WriteLine("The string from file is: " + textFile);
                int[] integerArray = utility.IntegerArray(textFile);
                
                for (int i = 0; i < integerArray.Length; i++)
                {
                    hashlist.AddNumberList(integerArray[i]);
                }
                Console.WriteLine("The linked List is:");
                hashlist.DisplayList();

                Console.WriteLine("Enter the search Element:");
                int element = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
    }
}
