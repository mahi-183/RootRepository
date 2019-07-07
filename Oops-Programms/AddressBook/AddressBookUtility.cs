// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookUtility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Oops_Programms.AddressBook
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    using Newtonsoft.Json;
    class AddressBookUtility
    {
        /// <summary>
        /// Displays the address book.
        /// </summary>
        public void DisplayAddressBook()
        {
            try
            {
                //string path = @"C:\Users\Admin\source\repos\OOP\OOP\AddressBook.json";

                Constant path = new Constant();

                IList<AddressBookData> addressBook = new List<AddressBookData>();

                StreamReader reader = File.OpenText(path.AddressBookJsonFile);

                string jsonsBook = reader.ReadToEnd();

                    addressBook = JsonConvert.DeserializeObject<List<AddressBook.AddressBookData>>(jsonsBook);

               // IList<AddressBookList> person = addressBook.Person;
                    foreach (var data in addressBook)
                    {
                        Console.Write("Ful Name::: " + data.FullName + "\n Address:::  " + data.Address + "\n City:::  " + data.City + "\n State:::  " + data.State + "\n Pin Code:::  " + data.Pin + "\n Mobile Number:::  " + data.MobileNumber);
                        Console.WriteLine();
                    }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
