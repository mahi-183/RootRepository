// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookUtility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Oops_Programms.AddressBook
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    
    class AddressBookUtility
    {
        /// <summary>
        /// Displays the address book.
        /// </summary>
        public static void DisplayAddressBook()
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Creates new entry.
        /// </summary>
        public static void NewEntry()
        {
            try
            {
                Console.WriteLine("Enter full name;");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the address");
                string address = Console.ReadLine();
                Console.WriteLine("Enter the state");
                string state = Console.ReadLine();
                Console.WriteLine("Enter the city");
                string city = Console.ReadLine();
                Console.WriteLine("Enter the pin code");
                string pin = Console.ReadLine();
                Console.WriteLine("Enter the phone number");
                string phoneNumber = Console.ReadLine();
                SaveEntry(name, address, state, city, pin, phoneNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Saves the entry.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="address">The address.</param>
        /// <param name="state">The state.</param>
        /// <param name="city">The city.</param>
        /// <param name="pin">The pin.</param>
        /// <param name="phoneNumber">The phone number.</param>
        public static void SaveEntry(string name, string address, string state, string city, string pin, string phoneNumber)
        {
            try
            {
                IList<AddressBookData> addressBook = new List<AddressBookData>();

                if (Regex.IsMatch(phoneNumber, @"[0-9]{10}") && Regex.IsMatch(pin, @"[0-9]") && Regex.IsMatch(name, @"[a-zA-Z]") && Regex.IsMatch(city, @"[a-zA-Z]") && Regex.IsMatch(state, @"[a-zA-Z]"))
                {
                    AddressBookData addressBookModel = new AddressBookData()
                    {
                        FullName = name,
                        Address = address,
                        City = city,
                        State = state,
                        Pin = pin,
                        MobileNumber = phoneNumber
                    };
                    string path = @"C:\Users\Admin\source\repos\OOP\OOP\AddressBook.json";
                    StreamReader reader = File.OpenText(path);

                    string jsonsBook = reader.ReadToEnd();
                    addressBook = JsonConvert.DeserializeObject<List<AddressBookData>>(jsonsBook);
                    addressBook.Add(addressBookModel);
                    var convertedJson = JsonConvert.SerializeObject(addressBook);
                    reader.Close();

                    File.WriteAllText(path, convertedJson);
                    Console.WriteLine("New Entry Added to the file");
                    DisplayAddressBook();

                }
                else
                {
                    Console.WriteLine("Enter proper details");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }



        /// <summary>
        /// Deletes the entry.
        /// </summary>
        public static void DeleteEntry()
        {
            try
            {
                Console.WriteLine("Enter your phone number to delete your entry");
                string phoneNumber = Console.ReadLine();
                string path = @"..\AddressBook.json";

                List<AddressBookData> addressData = new List<AddressBookData>();

                StreamReader reader = File.OpenText(path);

                // IList<AddressData> addressData = new List<AddressData>();
                string jsonsBook = reader.ReadToEnd();

                addressData = JsonConvert.DeserializeObject<List<AddressBookData>>(jsonsBook);
                bool ifNumber = false;
                foreach (var data in addressData)
                {
                    if (data.MobileNumber == phoneNumber)
                    {
                        Console.Write("Ful Name::: " + data.FullName + "\n Address:::  " + data.Address + "\n City:::  " + data.City + "\n State:::  " + data.State + "\n Pin Code:::  " + data.Pin + "\n Mobile Number:::  " + data.MobileNumber);
                        ifNumber = true;
                    }
                }

                if (ifNumber == false)
                {
                    Console.WriteLine("No Entry with the above number found");
                }

                var itemToRemove = addressData.Find(x => x.MobileNumber == phoneNumber);
                addressData.Remove(itemToRemove);
                ////searilizeing the object
                var convertedJson = JsonConvert.SerializeObject(addressData);
                reader.Close();
                ////writing in to the file
                File.WriteAllText(path, convertedJson);
                Console.WriteLine("your record deleted");
                DisplayAddressBook();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Updates the entry.
        /// </summary>
        public static void UpdateEntry()
        { ////using try block to hold unwanted excecption
            try
            {
                Console.WriteLine("Enter your phone number to update");
                string phoneNumber = Console.ReadLine();
                ////Creating object of constant class
                string path = @"../../../InventoryJson.json";
                ////creating list class object
                IList<AddressBookData> addressData = new List<AddressBookData>();
                ////Rdaing dat from file and assigning it to string variable
                StreamReader reader = File.OpenText(path);

                // IList<AddressData> addressData = new List<AddressData>();
                string jsonsBook = reader.ReadToEnd();

                ////Deseralizing the object
                addressData = JsonConvert.DeserializeObject<List<AddressBookData>>(jsonsBook);
                bool number = false;
                ////foreach loop iterated
                foreach (var data in addressData)
                {
                    if (data.MobileNumber == phoneNumber)
                    {
                        Console.WriteLine(data.FullName + " " + data.Address + " " + data.City + " " + data.State + " " + data.Pin + " " + data.MobileNumber);

                        number = true;
                        string doCondition = null;
                        Console.WriteLine("Enter the field you want to update");
                        do
                        {
                            Console.WriteLine("1. Update phone number");
                            Console.WriteLine("2. Udate address");
                            Console.WriteLine("3 Update state");
                            Console.WriteLine("4 Update city");
                            int update = Convert.ToInt32(Console.ReadLine());
                            
                            switch (update)
                            {
                                case 1:
                                    UpdateNumber(data);
                                    break;
                                case 2:
                                    UpdateAdd(data);
                                    break;
                                case 3:
                                    UpdateState(data);
                                    break;
                                case 4:
                                    UpdateState(data);
                                    break;
                            }

                            Console.WriteLine("enter y to continue or enter any key to stop");
                            doCondition = Console.ReadLine();
                        }
                        while (doCondition.Equals("y"));

                        var convertedJson = JsonConvert.SerializeObject(addressData);
                        reader.Close();
                        ////writing in to the file
                        File.WriteAllText(path, convertedJson);
                        Console.WriteLine("Record updated");
                        DisplayAddressBook();
                    }
                    if (number == true)
                    {
                        Console.WriteLine("enter proper phone number");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        /// <summary>
        /// Updates the number.
        /// </summary>
        /// <param name="items">The items.</param>
        public static void UpdateNumber(AddressBookData data)
        {
            Console.WriteLine("enter new number");
            string newPhoneNumber = Console.ReadLine();
            if (Regex.IsMatch(newPhoneNumber, @"[0-9]{10}"))
            {
                data.MobileNumber = newPhoneNumber;
            }
            else
            {
                Console.WriteLine("Enter a valid number");
            }
        }

        /// <summary>
        /// Updates the add.
        /// </summary>
        /// <param name="items">The items.</param>
        public static void UpdateAdd(AddressBookData data)
        {
            Console.WriteLine("enter new address");
            // string newAddress = Console.ReadLine();
            data.Address = Console.ReadLine();
        }

        /// <summary>
        /// Updates the state.
        /// </summary>
        /// <param name="items">The items.</param>
        public static void UpdateState(AddressBookData data)
        {
            Console.WriteLine("enter new state");
            string newState = Console.ReadLine();
            if (Regex.IsMatch(newState, @"[a-zA-Z]"))
            {
                data.State = newState;
            }
            else
            {
                Console.WriteLine("invalid data");
            }
        }

        /// <summary>
        /// Updates the city.
        /// </summary>
        /// <param name="items">The items.</param>
        public static void UpdateCity(AddressBookData data)
        {
            Console.WriteLine("enter new city");
            string newCity = Console.ReadLine();
            if (Regex.IsMatch(newCity, @"[a-zA-Z]"))
            {
                data.City = newCity;
            }
            else
            {
                Console.WriteLine("invalid data");
            }
        }

        /// <summary>
        /// Sorts the by zip.
        /// </summary>
        public static void SortByPin()
        {
            try
            {
                string path = @"../../../InventoryJson.json";
                ////creating list class object
                List<AddressBookData> addressData = new List<AddressBookData>();
                ////Rdaing dat from file and assigning it to string variable
                StreamReader reader = File.OpenText(path);

                // IList<AddressData> addressData = new List<AddressData>();
                string jsonsBook = reader.ReadToEnd();


                addressData = JsonConvert.DeserializeObject<List<AddressBookData>>(jsonsBook);
                var ascending = addressData.OrderBy(x => x.Pin);
                var orderedByPin = JsonConvert.SerializeObject(ascending);
                var convertedJson = JsonConvert.SerializeObject(addressData);
                reader.Close();
                ////writing in to the file
                File.WriteAllText(path, convertedJson);
                Console.WriteLine("Sorted by Pin code");
                DisplayAddressBook();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
