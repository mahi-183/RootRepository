// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------


namespace Oops_Programms
{
    using System;
    using System.Text.RegularExpressions;

    class RegularExpression
    {
        public void Expression()
        {
            //Take the statement in string 
            string stringExpression = " Hello <<name>>, We have your full name as <<full name>> in our system. your contact number is 91-xxxxxxxxxx." +
                " Please,let us know in case of any clarification Thank" +
                " you BridgeLabz 01/01/2016.";
            Console.WriteLine(stringExpression);

            ///regex exp for validating string name
            Regex validatename = new Regex(@"^[a-zA-Z]+$");

            ///input for first name
            Console.WriteLine("Enter your first name");
            string firstName = Console.ReadLine();

            bool ifname = Regex.IsMatch(firstName, @"^[a-zA-Z]+$");
            ///checks if input is empty and alphabets only
            while (string.IsNullOrEmpty(firstName) || !ifname)
            {
                Console.WriteLine("Firstname cannot be empty and should be only alphabets,Please enter valid the first name");
                firstName = Console.ReadLine();
                ifname = Regex.IsMatch(firstName, @"^[a-zA-Z]+$");
            }
            ///input for last name
            Console.WriteLine("Enter your last name");
            string lastName = Console.ReadLine();

            bool iflastname = validatename.IsMatch(lastName);
            ///checks if input is empty and alphabets only
            while (string.IsNullOrEmpty(lastName) || !iflastname)
            {
                Console.WriteLine("Lastname cannot be empty and should be only alphabets,Please enter valid the last name");
                lastName = Console.ReadLine();
                iflastname = validatename.IsMatch(lastName);
            }
            ///input for mobile number
            Console.WriteLine("Enter the mobile number");
            string mobileNo = Console.ReadLine();

            ///regex exp for validating mobile number
            Regex validaatenumber = new Regex("^[0-9]{10}$");

            bool ifno = validaatenumber.IsMatch(mobileNo);
            ///checks if input is empty and 10 number digits only
            while (string.IsNullOrEmpty(mobileNo) || !ifno)
            {
                Console.WriteLine("Mobile number cannot be empty or less than 10 digits ,Please enter the valid number");
                mobileNo = Console.ReadLine();
                ifno = validaatenumber.IsMatch(mobileNo);
            }

            string Fullname = firstName + " " + lastName;
            ///replaces <<<name>>> to username and fullname
            if (validatename.IsMatch(firstName))
            {
                stringExpression = stringExpression.Replace("<<name>>", firstName);
                stringExpression = stringExpression.Replace("<<full name>>", Fullname);
            }

            ///replaces phone number
            if (validaatenumber.IsMatch(mobileNo))
            {
                stringExpression = stringExpression.Replace("91-xxxxxxxxxx", mobileNo);
            }

            ///replaces date to current date
            string currentdate = DateTime.Now.ToShortDateString();
            Console.WriteLine(currentdate);

            Regex regexdatetime = new Regex(@"^\d{1,2}[- /.]\d{1,2}[- /.]\d{4}$");
            string date = "01/01/2016";
            if (regexdatetime.IsMatch(currentdate))
            {
                stringExpression = stringExpression.Replace(date, currentdate);
            }

            Console.WriteLine(stringExpression);

        }
    }
}
