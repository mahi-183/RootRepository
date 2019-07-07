// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryManagerUtility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------


namespace Oops_Programms.InventoryManager
{

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.IO;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class InventoryManagerUtility
    {
        //json file path
        static Constant JosonFilePath = new Constant();
        static StreamReader StreamReader = File.OpenText(JosonFilePath.InventoryJsonfilePath);
        static string JsonString = StreamReader.ReadToEnd();
        //json String object
         static InventoryManagement.InventoryList JsonObject = JsonConvert.DeserializeObject<InventoryManagement.InventoryList>(JsonString);

        static IList<InventoryManagement.InventoryData> RiceArrayList = JsonObject.Rice;

        /// creats list of inventory data from json object
        static IList<InventoryManagement.InventoryData> wheat = JsonObject.Wheat;


        /// creats list of inventory data from json object
        static IList<InventoryManagement.InventoryData> pulses = JsonObject.Pulses;

        public static void DisplayInventory()
        {
            try
            {

                    //IList<InventoryManagement.InventoryData> RiceArrayList = JsonObject.Rice;
                    Console.WriteLine("\n------------------------------------TYPES OF RICE AND ITS PRICES PER/KG------------------------------------------");
                    Console.WriteLine("\n" + "Name" + "\t\t " + "Weight" + " \t" + "Price");
                    double TotalRicePrice = 0;

                    ///iterates list to display rice details
                    foreach (var item in RiceArrayList)
                    {
                        Console.WriteLine(item.Name + "\t\t" + item.Weight + "\t" + item.Price + " ");
                        TotalRicePrice = TotalRicePrice + (item.Price * item.Weight);
                    }
                    Console.WriteLine("\n------------------------------------------------------------------------------------------");

                    Console.WriteLine("\n\t\t\tTotal price of Rice:::" + TotalRicePrice);
                    Console.WriteLine("\n-------------------------------------------------------------------------------------------");
                    /// creats list of inventory data from json object
                    IList<InventoryManagement.InventoryData> WheatArrayList = JsonObject.Wheat;
                    Console.WriteLine("\n------------------------------------TYPES OF Wheat AND ITS PRICES PER/KG------------------------------------------");
                    Console.WriteLine("\n" + "Name" + "\t\t " + "Weight" + " \t" + "Price");
                    double TotalWheatPrice = 0;

                    ///iterates list to display rice details
                    foreach (var item in WheatArrayList)
                    {
                        Console.WriteLine(item.Name + "\t\t" + item.Weight + "\t" + item.Price + " ");
                        TotalWheatPrice = TotalWheatPrice + (item.Price * item.Weight);
                    }
                    Console.WriteLine("\n------------------------------------------------------------------------------------------");

                    Console.WriteLine("\n\t\t\tTotal price of Rice:::" + TotalWheatPrice);
                    Console.WriteLine("\n-------------------------------------------------------------------------------------------");

                    /// creats list of inventory data from json object
                    IList<InventoryManagement.InventoryData> PulsesArrayList = JsonObject.Pulses;
                    Console.WriteLine("\n------------------------------------TYPES OF Wheat AND ITS PRICES PER/KG------------------------------------------");
                    Console.WriteLine("\n" + "Name" + "\t\t " + "Weight" + " \t" + "Price");
                    double TotalPulsesPrice = 0;

                    ///iterates list to display rice details
                    foreach (var item in PulsesArrayList)
                    {
                        Console.WriteLine(item.Name + "\t\t" + item.Weight + "\t" + item.Price + " ");
                        TotalPulsesPrice = TotalPulsesPrice + (item.Price * item.Weight);
                    }
                    Console.WriteLine("\n------------------------------------------------------------------------------------------");

                    Console.WriteLine("\n\t\t\tTotal price of Rice:::" + TotalPulsesPrice);
                    Console.WriteLine("\n-------------------------------------------------------------------------------------------");

                //}
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// Adds the inventory.
        /// </summary>
        public static void AddInventory()
        {
            try
            {
                int SelectInventory = 0;
                do
                {
                    Console.WriteLine("1.Rice\n 2.wheat\n3.Pulses\n");
                    Console.WriteLine("Select Inventory:");
                    SelectInventory = Convert.ToInt32(Console.ReadLine());
                   
                    switch(SelectInventory)
                    {
                        case 1:
                            AddRiceInventoryData();
                            break;

                        case 2:
                            AddWheatInventoryData();
                            break;

                        case 3:
                            AddPulsesInventoryData();
                            
                            break;
                        default:
                            Console.WriteLine("Invalid Selection..Please Enter valid Option..!");
                            break;
                    }

                } while (SelectInventory<=0 && SelectInventory>3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message)
            }

        }
        //Add Data into Rice Inventory Data
        public static void AddRiceInventoryData()
        {
            Console.WriteLine("Enter inventory name;");
            string riceType = Console.ReadLine();
            Console.WriteLine("Enter the weight");
            int riceWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price");
            double ricePrice = Convert.ToDouble(Console.ReadLine());
            if (Regex.IsMatch(riceType, @"^[a-zA-Z]+$"))
            {
                InventoryManagement.InventoryData inventory = new InventoryManagement.InventoryData()
                {
                    Name = riceType,
                    Weight = riceWeight,
                    Price = ricePrice,
                };
                RiceArrayList.Add(inventory);

                var convertedJson = JsonConvert.SerializeObject(JsonObject);
                StreamReader.Close();
                File.WriteAllText(JosonFilePath.InventoryJsonfilePath, convertedJson);
                Console.WriteLine("New Inventory Added to the file");
                DisplayInventory();
            }
        }

        //Add Data into Wheat Inventory Data
        public static void AddWheatInventoryData()
        {

            /// creats list of inventory data from json object
            //IList<InventoryManagement.InventoryData> wheat = JsonObject.Wheat;

            Console.WriteLine("Enter inventory name;");
            string wheatType = Console.ReadLine();
            Console.WriteLine("Enter the weight");
            int wheatWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price");
            double wheatPrice = Convert.ToDouble(Console.ReadLine());
            if (Regex.IsMatch(wheatType, @"^[a-zA-Z]+$"))
            {
                InventoryManagement.InventoryData inventory = new InventoryManagement.InventoryData()
                {
                    Name = wheatType,
                    Weight = wheatWeight,
                    Price = wheatPrice,
                };
                wheat.Add(inventory);

                var convertedJson = JsonConvert.SerializeObject(JsonObject);
                StreamReader.Close();
                File.WriteAllText(JosonFilePath.InventoryJsonfilePath, convertedJson);
                Console.WriteLine("New Inventory Added to the file");
                DisplayInventory();

            }
        }

        //Add Data into Pulses Inventory Data
        public static void AddPulsesInventoryData()
        {

            Console.WriteLine("Enter inventory name;");
            string pulsesType = Console.ReadLine();
            Console.WriteLine("Enter the weight");
            int pulsesWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price");
            double pulsesPrice = Convert.ToDouble(Console.ReadLine());

            if (Regex.IsMatch(pulsesType, @"^[a-zA-Z]+$"))
            {
                InventoryManagement.InventoryData inventory = new InventoryManagement.InventoryData()
                {
                    Name = pulsesType,
                    Weight = pulsesWeight,
                    Price = pulsesPrice,
                };
                pulses.Add(inventory);

                var convertedJson = JsonConvert.SerializeObject(JsonObject);
                StreamReader.Close();
                File.WriteAllText(JosonFilePath.InventoryJsonfilePath, convertedJson);
                Console.WriteLine("New Inventory Added to the file");
                DisplayInventory();

            }
        }
        /// <summary>
        /// Updates the inventory.
        /// </summary>
        public static void UpdateInventory()
        {
            try
            {
                int selectInventory = 0;
                do
                {
                    Console.WriteLine("1.Rice\n 2.wheat\n3.Pulses\n");
                    Console.WriteLine("Select the inventory:");
                    selectInventory = Convert.ToInt32(Console.ReadLine());
                    //reads data from json file
                    Constant path = new Constant();

                    StreamReader reader = File.OpenText(path.InventoryJsonfilePath);

                    string jsonString = reader.ReadToEnd();

                    ///stores json file data 
                    InventoryManagement.InventoryList Jsoninventory = JsonConvert.DeserializeObject<InventoryManagement.InventoryList>(jsonString);

                    switch (selectInventory)
                    {
                        case 1:
                            UpdateRiceInventory();
                            break;

                        case 2:
                            
                            UpdateWheatInventory();
                            break;

                        case 3:
                            
                            UpdatePulsesInventory();
                        break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }

                } while (selectInventory != 3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        //Update Pulses Inventory
        public static void UpdatePulsesInventory()
        {
            Console.WriteLine("Enter the Pulses type to update");
            string updatePulsesType = Console.ReadLine();
            bool isUpdated = false;

            for (int i = 0; i < RiceArrayList.Count; i++)
            {
                var pulsesName = JsonObject.Pulses[i].Name;
                if (pulsesName.Equals(updatePulsesType))
                {
                    Console.WriteLine("Enter the field to update.\n 1.Update wheat type\n2.Update Weight\n3.Update Price\n ");
                    int fieldUpdate = Convert.ToInt32(Console.ReadLine());
                    switch (fieldUpdate)
                    {
                        case 1:
                            Console.WriteLine("Enter the new Pulses type");
                            string newPulsesType = Console.ReadLine();

                            while (Regex.IsMatch(newPulsesType, @"^[a-zA-Z]+$") && string.IsNullOrEmpty(newPulsesType))
                            {
                                newPulsesType = Console.ReadLine();
                            }
                            SaveInventoryName(JosonFilePath.InventoryJsonfilePath, newPulsesType);
                            break;

                        case 2:
                            Console.WriteLine("Enter the new field weight of rice");
                            double newPulsesWeight = Convert.ToDouble(Console.ReadLine());
                            //  bool regex =  Regex.IsMatch (newRiceWeight, @"^[0-9]*(?:\.[0-9]*)?$");

                            SaveInventoryWeight(JosonFilePath.InventoryJsonfilePath, newPulsesWeight);
                            break;

                        case 3:
                            Console.WriteLine("Enter the new field Price of rice");
                            double newPulsesPrice = Convert.ToInt32(Console.ReadLine());

                            SaveInventoryWeight(JosonFilePath.InventoryJsonfilePath, newPulsesPrice);
                            break;

                    } while (fieldUpdate != 3) ;
                }
                if (isUpdated == true)
                {
                    DisplayInventory();
                    break;
                }
            }
        }
        //Update Rice Inventory
        public static void UpdateWheatInventory()
        {
            Console.WriteLine("Enter the Wheat type to update");
            string updateWheatType = Console.ReadLine();
            bool isUpdated = false;
            int SelectOption;

            /// creats list of inventory data from json object
            IList<InventoryManagement.InventoryData> wheat = JsonObject.Rice;

            // if(rice.Single(obj => obj["inventoryName"].Value<string>().Equals(updateRiceType)))
            for (int i = 0; i < RiceArrayList.Count; i++)
            {
                var Wheatname = JsonObject.Wheat[i].Name;

                if (Wheatname.Equals(updateWheatType))
                {
                    Console.WriteLine("Enter the field to update.\n 1.Update wheat type\n2.Update Weight\n3.Update Price\n ");
                    SelectOption = Convert.ToInt32(Console.ReadLine());
                    switch (SelectOption)
                    {
                        case 1:
                            Console.WriteLine("Enter the new wheat type");
                            string newWheatType = Console.ReadLine();

                            while (Regex.IsMatch(newWheatType, @"^[a-zA-Z]+$") && string.IsNullOrEmpty(newWheatType))
                            {
                                newWheatType = Console.ReadLine();
                            }
                            SaveInventoryName(JosonFilePath.InventoryJsonfilePath, newWheatType);
                            break;

                        case 2:
                            Console.WriteLine("Enter the new field weight of rice");
                            double newWheatWeight = Convert.ToDouble(Console.ReadLine());
                            //  bool regex =  Regex.IsMatch (newRiceWeight, @"^[0-9]*(?:\.[0-9]*)?$");

                            SaveInventoryWeight(JosonFilePath.InventoryJsonfilePath, newWheatWeight);
                            break;

                        case 3:
                            Console.WriteLine("Enter the new field Price of rice");
                            double newWheatPrice = Convert.ToInt32(Console.ReadLine());

                            SaveInventoryWeight(JosonFilePath.InventoryJsonfilePath, newWheatPrice);
                            break;

                    } while (SelectOption <= 0 && SelectOption > 3) ;
                }
                if (isUpdated == true)
                {
                    DisplayInventory();
                    break;
                }
            }
        }

        //Update Rice Inventory
        public static void UpdateRiceInventory()
        {
            Console.WriteLine("Enter the rice type to update");
            string updateRiceType = Console.ReadLine();
            bool isUpdated = false;

            for (int i = 0; i < RiceArrayList.Count; i++)
            {
                var name = JsonObject.Rice[i].Name;


                if (name.Equals(updateRiceType))
                {
                    Console.WriteLine("Enter the field to update.\n 1.Update Rice type\n2.Update Weight\n3.Update Price\n ");
                    int SelectOption = Convert.ToInt32(Console.ReadLine());
                    switch (SelectOption)
                    {
                        case 1:
                            Console.WriteLine("Enter the new rice type");
                            string newRiceType = Console.ReadLine();
                            while (Regex.IsMatch(newRiceType, @"^[a-zA-Z]+$") && string.IsNullOrEmpty(newRiceType))
                            {
                                newRiceType = Console.ReadLine();
                            }
                            SaveInventoryName(JosonFilePath.InventoryJsonfilePath, updateRiceType);
                            isUpdated = true;
                            break;

                        case 2:
                            Console.WriteLine("Enter the new field weight of rice");
                            double newRiceWeight = Convert.ToDouble(Console.ReadLine());
                            //  bool regex =  Regex.IsMatch (newRiceWeight, @"^[0-9]*(?:\.[0-9]*)?$");
                            while (newRiceWeight.Equals(null))
                            {
                                Console.WriteLine("Cannot be null");
                                newRiceWeight = Convert.ToDouble(Console.ReadLine());
                            }
                            SaveInventoryWeight(JosonFilePath.InventoryJsonfilePath, newRiceWeight);
                            isUpdated = true;
                            break;

                        case 3:
                            Console.WriteLine("Enter the new field Price of rice");
                            double newRicePrice = Convert.ToInt32(Console.ReadLine());
                            while (newRicePrice.Equals(null))
                            {
                                Console.WriteLine("Cannot be null");
                                newRicePrice = Convert.ToDouble(Console.ReadLine());
                            }
                            SaveInventoryWeight(JosonFilePath.InventoryJsonfilePath, newRicePrice);
                            isUpdated = true;
                            break;

                    } while (SelectOption <= 0 && SelectOption > 3) ;
                }
                if (isUpdated == true)
                {
                    DisplayInventory();
                    break;
                }
            }
        }
        /// <summary>
        /// Saves the name of the inventory.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="data">The data.</param>
        public static void SaveInventoryName(string path, string data)
        {
            try
            {
                StreamReader reader = File.OpenText(path);
                string json = reader.ReadToEnd();
                ///stores json file data 
                InventoryManagement.InventoryList JsonInventory = JsonConvert.DeserializeObject<InventoryManagement.InventoryList>(json);
                if (JsonInventory.Rice.Equals(data))
                {
                    /// creats list of inventory data from json object
                    IList<InventoryManagement.InventoryData> rice = JsonInventory.Rice;
                    InventoryManagement.InventoryData inventory = new InventoryManagement.InventoryData()
                    {
                        Name = data
                    };
                    rice.Add(inventory);
                    var convertedJson = JsonConvert.SerializeObject(JsonInventory);
                    reader.Close();
                    File.WriteAllText(path, convertedJson);
                    Console.WriteLine("New Inventory rice type Added to the file");
                    DisplayInventory();
                }
                else if (JsonInventory.Wheat.Equals(data))
                {
                    /// creats list of inventory data from json object
                    IList<InventoryManagement.InventoryData> wheat = JsonInventory.Wheat;
                    InventoryManagement.InventoryData inventory = new InventoryManagement.InventoryData()
                    {
                        Name = data
                    };
                    wheat.Add(inventory);
                    var convertedJson = JsonConvert.SerializeObject(JsonInventory);
                    reader.Close();
                    File.WriteAllText(path, convertedJson);
                    Console.WriteLine("New Inventory wheat type Added to the file");
                    DisplayInventory();
                }
                else if (JsonInventory.Pulses.Equals(data))
                {
                    /// creats list of inventory data from json object
                    IList<InventoryManagement.InventoryData> pulses = JsonInventory.Pulses;
                    InventoryManagement.InventoryData inventory = new InventoryManagement.InventoryData()
                    {
                        Name = data
                    };
                    pulses.Add(inventory);
                    var convertedJson = JsonConvert.SerializeObject(JsonInventory);
                    reader.Close();
                    File.WriteAllText(path, convertedJson);
                    Console.WriteLine("New Inventory pulses type Added to the file");
                    DisplayInventory();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        /// <summary>
        /// Saves the inventory weight.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="data">The data.</param>
        public static void SaveInventoryWeight(string path, double data)
        {
            //ConstantClass path = new ConstantClass();
            using (StreamReader reader = File.OpenText(path))
            {
                string json = reader.ReadToEnd();
                ///stores json file data 
                InventoryManagement.InventoryList JsonInventory = JsonConvert.DeserializeObject<InventoryManagement.InventoryList>(json);

                /// creats list of inventory data from json object
                IList<InventoryManagement.InventoryData> rice = JsonInventory.Rice;
                for (int i = 0; i < rice.Count; i++)
                {
                    var weight = JsonInventory.Rice[i].Name;
                    if (weight.Equals(data))
                    {
                        InventoryManagement.InventoryData inventory = new InventoryManagement.InventoryData()
                        {
                            Weight = data
                        };
                        rice.Add(inventory);
                        var convertedJson = JsonConvert.SerializeObject(JsonInventory);
                        reader.Close();
                        File.WriteAllText(path, convertedJson);
                        Console.WriteLine("New Inventory  weight of  rice type Added to the file");
                        DisplayInventory();
                    }
                }
                     if (JsonInventory.Wheat.Equals(data))
                    {
                        /// creats list of inventory data from json object
                        IList<InventoryManagement.InventoryData> wheat = JsonInventory.Wheat;
                        InventoryManagement.InventoryData inventory = new InventoryManagement.InventoryData()
                        {
                            Weight = data
                        };
                        wheat.Add(inventory);
                        var convertedJson = JsonConvert.SerializeObject(JsonInventory);
                        reader.Close();
                        File.WriteAllText(path, convertedJson);
                        Console.WriteLine("New Inventory weight of wheat Added to the file");
                        DisplayInventory();
                    }
                    else if (JsonInventory.Pulses.Equals(data))
                    {
                        /// creats list of inventory data from json object
                        IList<InventoryManagement.InventoryData> pulses = JsonInventory.Pulses;
                        InventoryManagement.InventoryData inventory = new InventoryManagement.InventoryData()
                        {
                            Weight = data
                        };
                        pulses.Add(inventory);
                        var convertedJson = JsonConvert.SerializeObject(JsonInventory);
                        reader.Close();
                        File.WriteAllText(path, convertedJson);
                        Console.WriteLine("New Inventory  weight of pulses type Added to the file");
                        DisplayInventory();
                    }
            }
        }
        /// <summary>
        /// Deletes the specified inventory.
        /// </summary>
        public static void DeleteInventory()
        {
            try
            {
                Console.WriteLine("1.Rice\n 2.wheat\n3.Pulses\n");
                int deleteInventory = Convert.ToInt32(Console.ReadLine());

                Constant path = new Constant();

                switch (deleteInventory)
                {
                    case 1:
                        Console.WriteLine("Enter the rice type to delete");
                        string deleteRiceType = Console.ReadLine();

                        Delete(path.InventoryJsonfilePath, deleteRiceType);
                        break;

                    case 2:
                        Console.WriteLine("Enter the wheat type to delete");
                        string deleteWheatType = Console.ReadLine();

                        Delete(path.InventoryJsonfilePath, deleteWheatType);
                        break;

                    case 3:
                        Console.WriteLine("Enter the pulses type to delete");
                        string deletePulsesType = Console.ReadLine();

                        Delete(path.InventoryJsonfilePath, deletePulsesType);
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;

                } while (deleteInventory > 3) ;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Delete function of the specified inventory.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="deleteType">Type of the delete.</param>
        public static void Delete(string path, string deleteType)
        {
            //// Used to read all data from the file
            Constant path1 = new Constant();
            
            Utility utility = new Utility();
            var json = Utility.FileReader(path1.InventoryJsonfilePath);
            
            try
            {
                if (!deleteType.Equals(null))
                {
                    //// Parsing the object
                    var jObject = JObject.Parse(json);
                    //// Storing the object in jarray
                    JArray riceArray = (JArray)jObject["Rice"];
                    JArray wheatArray = (JArray)jObject["Wheat"];
                    JArray pulsesArray = (JArray)jObject["Pulses"];


                    if (riceArray.Contains(deleteType))
                    {
                        Console.WriteLine(riceArray);

                        //// checks if ricename is not null

                        var riceType = string.Empty;

                        //// Rice to be deleted
                        var riceToDelete = riceArray.FirstOrDefault(obj => obj["inventoryName"].Value<string>().Equals(deleteType));

                        riceArray.Remove(riceToDelete);

                        //// Serializing 
                        string output = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                        //reader.close();
                        File.WriteAllText(path, output);
                        Console.WriteLine(riceArray);
                    }
                    else if (wheatArray.Contains(deleteType))
                    {
                        Console.WriteLine(wheatArray);

                        //// checks if ricename is not null

                        var wheatType = string.Empty;

                        //// wheat to be deleted
                        var wheatToDelete = wheatArray.FirstOrDefault(obj => obj["inventoryName"].Value<string>().Equals(deleteType));

                        riceArray.Remove(wheatToDelete);

                        //// Serializing 
                        string output = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                        File.WriteAllText(path, output);
                        Console.WriteLine(wheatArray);
                    }
                    else if (pulsesArray.Contains(deleteType))
                    {
                        Console.WriteLine(pulsesArray);

                        //// checks if ricename is not null

                        var pulsesType = string.Empty;

                        //// Rice to be deleted
                        var pulsesToDelete = pulsesArray.FirstOrDefault(obj => obj["inventoryName"].Value<string>().Equals(deleteType));

                        riceArray.Remove(pulsesToDelete);

                        //// Serializing 
                        string output = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                        File.WriteAllText(path, output);
                        Console.WriteLine(pulsesArray);
                    }
                    else
                    {
                        Console.WriteLine("Inventory not found");
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
