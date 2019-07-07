// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookMain.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Oops_Programms.AddressBook
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// 
    /// </summary>
    class AddressBookMain
    {
        public void Book()
        {
            AddressBookUtility utilityAddress = new AddressBookUtility();
            //// choose an option to perform
            Console.WriteLine("select the following::\n  1. Add new entry \n 2. Delete an entry\n 3. Update an entry\n 4. sort by zip\n 5. Display Address Book");
            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    //// calling a method from address utility class
                    //utilityAddress.NewEntry();
                    break;

                case "2":
                    //utilityAddress.DeleteEntry();
                    break;
                case "3":
                    //utilityAddress.UpdateEntry();
                    break;
                case "4":
                    //utilityAddress.SortByPin();
                    break;
                case "5":
                    utilityAddress.DisplayAddressBook();
                    break;
            }

        }
    }
}
