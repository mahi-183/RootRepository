// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DisplayInventory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Oops_Programms.InventoryManagement
{
    using Newtonsoft.Json;
    using System;
    using System.IO;
    using System.Collections.Generic;
    /// <summary>
    /// 
    /// </summary>

    class DisplayInventory
    {
        public void Display()
        {

            try
            {
                //json file path
                ConstantClass path = new ConstantClass();
                
                using (StreamReader reader = File.OpenText(path.InventoryJsonfilePath))
                {
                    ///json object
                    string json = reader.ReadToEnd();

                    ///stores json file data in jsoninventory 
                    InventoryList Jsoninventory = JsonConvert.DeserializeObject<InventoryList>(json);

                    /// creats list of inventory data from json object
                    IList<InventoryData> rice = Jsoninventory.Rice;
                    Console.WriteLine("\n------------------------------------TYPES OF RICE AND ITS PRICES PER/KG------------------------------------------");
                    Console.WriteLine("\n" + "Name" + "\t\t " + "Weight" + " \t" + "Price");
                    double riceprice = 0;

                    ///iterates list to display rice details
                    foreach (var item in rice)
                    {
                        Console.WriteLine(item.Name + "\t\t" + item.Weight + "\t" + item.Price + " ");
                        riceprice = riceprice + (item.Price * item.Weight);
                    }
                    Console.WriteLine("\n------------------------------------------------------------------------------------------");

                    Console.WriteLine("\n\t\t\tTotal price of Rice:::" + riceprice);
                    Console.WriteLine("\n-------------------------------------------------------------------------------------------");

                    /// creats list of inventory data from json object
                    IList<InventoryData> wheat = Jsoninventory.Wheat;
                    Console.WriteLine("\n------------------------------------TYPES OF Wheat AND ITS PRICES PER/KG------------------------------------------");
                    Console.WriteLine("\n" + "Name" + "\t\t " + "Weight" + " \t" + "Price");
                    double wheatprice = 0;

                    ///iterates list to display rice details
                    foreach (var item in wheat)
                    {
                        Console.WriteLine(item.Name + "\t\t" + item.Weight + "\t" + item.Price + " ");
                        wheatprice = wheatprice + (item.Price * item.Weight);
                    }
                    Console.WriteLine("\n------------------------------------------------------------------------------------------");

                    Console.WriteLine("\n\t\t\tTotal price of Rice:::" + wheatprice);
                    Console.WriteLine("\n-------------------------------------------------------------------------------------------");

                    /// creats list of inventory data from json object
                    IList<InventoryData> pulses = Jsoninventory.Pulses;
                    Console.WriteLine("\n------------------------------------TYPES OF Wheat AND ITS PRICES PER/KG------------------------------------------");
                    Console.WriteLine("\n" + "Name" + "\t\t " + "Weight" + " \t" + "Price");
                    double pulsesprice = 0;

                    ///iterates list to display rice details
                    foreach (var item in pulses)
                    {
                        Console.WriteLine(item.Name + "\t\t" + item.Weight + "\t" + item.Price + " ");
                        pulsesprice = pulsesprice + (item.Price * item.Weight);
                    }
                    Console.WriteLine("\n------------------------------------------------------------------------------------------");

                    Console.WriteLine("\n\t\t\tTotal price of Rice:::" + pulsesprice);
                    Console.WriteLine("\n-------------------------------------------------------------------------------------------");
               }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

}
}
