// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockAccount.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------


namespace Oops_Programms.DataProceesing
{

    using System;
    using System.IO;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    /// <summary>
    /// 
    /// </summary>

    class StockAccount
    {
        public void DisplayDetails()

        {
            try
            {
                    ConstantClass constantClass = new ConstantClass();
                    //json file path

                     StreamReader reader = File.OpenText(constantClass.StockAccountData);
                    
                    string json = reader.ReadToEnd();
                    //convert string to object

                    StockAccountList jObject = JsonConvert.DeserializeObject<StockAccountList>(json);



                    /// creats list of StockAccount data from json object
                    IList<StockAccountData> list = jObject.CompanyDetails;
                    Console.WriteLine("\n------------------------------------Company Details------------------------------------------");
                    Console.WriteLine("\n" + "\tName" + "  \t\t\t" + "Weight" + " \t" + "Price");
                    double TotalsharePrice = 0;

                    ///iterates list to display CompanyDetails details
                    foreach (var item in list)
                    {
                        Console.WriteLine("\t"+item.CompanyName + "  \t\t\t" + item.NoOfShares + "\t" + item.SharePrice + " ");
                        TotalsharePrice = TotalsharePrice + (item.SharePrice * item.NoOfShares);
                    }
                    Console.WriteLine("\n------------------------------------------------------------------------------------------");

                    Console.WriteLine("\n\t\t\tTotal price of Rice:::" + TotalsharePrice);
                    Console.WriteLine("\n-------------------------------------------------------------------------------------------");

                StreamReader reader1 = File.OpenText(constantClass.UserData);

                string json1 = reader1.ReadToEnd();
                //convert string to object

                UserList jObject1 = JsonConvert.DeserializeObject<UserList>(json1);

                /// creats list of StockAccount data from json object
                IList<UserAccontData> list1 = jObject1.User;
                    Console.WriteLine("\n------------------------------------User Details------------------------------------------");
                    Console.WriteLine("\n" + "\tName" + "  \t\t\t" + "Weight" );
                    double Availbalance = 0;

                    ///iterates list to display CompanyDetails details
                    foreach (var item in list1)
                    {
                        Console.WriteLine("\t" + item.Name + "  \t\t\t" + item.Balance);
                        //TotalsharePrice = TotalsharePrice + (item.SharePrice * item.NoOfShares);
                    }
                    Console.WriteLine("\n------------------------------------------------------------------------------------------");
                
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
