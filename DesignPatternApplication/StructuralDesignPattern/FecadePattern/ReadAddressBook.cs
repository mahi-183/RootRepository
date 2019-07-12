using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternApplication.StructuralDesignPattern.FecadePattern
{
    using System;
    using System.IO;

    /// <summary>
    /// reads address book from text file
    /// </summary>
    public class ReadAdressBook
    {
        /// <summary>
        /// Displays the address.
        /// </summary>
        public void DisplayAddress()
        {
            try
            {
                string textFile = @"..\..\..\Addressbook.txt";

                if (File.Exists(textFile))
                {
                    using (StreamReader reader = new StreamReader(textFile))
                    {
                        string content = reader.ReadToEnd();
                        Console.WriteLine(content);
                        reader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
