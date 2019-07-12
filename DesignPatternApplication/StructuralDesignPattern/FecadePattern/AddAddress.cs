using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternApplication.StructuralDesignPattern.FecadePattern
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    /// <summary>
    /// class to add address to file
    /// </summary>
    public class AddAdress
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the pin.
        /// </summary>
        /// <value>
        /// The pin.
        /// </value>
        public int Pin { get; set; }

        /// <summary>
        /// Addd the details.
        /// </summary>
        public void AddDetails()
        {
            try
            {
                AddAdress addAdress = new AddAdress();

                string path = @"..\..\..\Addressbook.txt";
                using (FileStream file = new FileStream(path, FileMode.Append))
                using (StreamWriter streamWriter = new StreamWriter(file))
                {
                    Console.WriteLine("Enter Full name");
                    string name = Console.ReadLine();
                    bool ifName = Regex.IsMatch(name, @"^[a-zA-Z]+$");
                    while (string.IsNullOrEmpty(name) || !ifName)
                    {
                        Console.WriteLine("Name cannot be empty and should be only alphabets,Please enter the valid full name");
                        name = Console.ReadLine();
                        ifName = Regex.IsMatch(name, @"^[a-zA-Z]+$");
                    }

                    Console.WriteLine("Enter Address");
                    string address = Console.ReadLine();
                    bool ifAddress = Regex.IsMatch(name, @"^[a-zA-Z0-9]+$");
                    while (string.IsNullOrEmpty(address) || !ifAddress)
                    {
                        Console.WriteLine("Address cannot be empty and should be only alphabets,Please enter the valid address");
                        name = Console.ReadLine();
                        ifName = Regex.IsMatch(address, @"^[a-zA-Z0-9]+$");
                    }

                    Console.WriteLine("Enter State");
                    string state = Console.ReadLine();
                    bool ifState = Regex.IsMatch(name, @"^[a-zA-Z]+$");
                    while (string.IsNullOrEmpty(state) || !ifState)
                    {
                        Console.WriteLine("state cannot be empty and should be only alphabets,Please enter valid the state");
                        name = Console.ReadLine();
                        //// ifState = Regex.IsMatch(state, @"^[a-zA-Z]+$");
                    }

                    Console.WriteLine("Enter city");
                    string city = Console.ReadLine();
                    bool ifCity = Regex.IsMatch(name, @"^[a-zA-Z]+$");
                    while (string.IsNullOrEmpty(city) || !ifCity)
                    {
                        Console.WriteLine("city cannot be empty and should be only alphabets,Please enter valid city");
                        name = Console.ReadLine();
                        ////   ifCity = Regex.IsMatch(city, @"^[a-zA-Z]+$");
                    }

                    Console.WriteLine("Enter city pin");
                    int pin = Convert.ToInt32(Console.ReadLine());
                    bool ifPin = Regex.IsMatch(name, @"^[0-9]+$");
                    //// while (pin == null || !ifPin)
                    ////{
                    ////    Console.WriteLine("Pin cannot be empty and should be only numbers,Please enter valid pin");
                    ////    pin = Convert.ToInt32(Console.ReadLine());
                    ////    ifPin = Regex.IsMatch(name, @"^[0-9]+$");
                    ////   }

                    addAdress.Name = name;
                    addAdress.Address = name;
                    addAdress.State = state;
                    addAdress.City = city;
                    addAdress.Pin = pin;

                    string fullText = "\nName: " + name + " \nAddress: " + address + "\nstate: " + state + "\ncity: " + city + "\nPin: " + pin;
                    streamWriter.Close();
                    File.AppendAllText(path, fullText);
                    Console.WriteLine("Added Successfully");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
