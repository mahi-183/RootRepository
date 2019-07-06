// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------


namespace Oops_Programms.InventoryManager
{
    using Newtonsoft.Json;
    using System;
    using System.IO;
    using System.Collections.Generic;
    /// <summary>
    /// 
    /// </summary>
    class InventoryManager
    {
        public void Manage()
        {
            try
            {
                Utility utility = new Utility();
                //// choose an option to perform
                Console.WriteLine("select the following::\n  1. Add new Inventory \n 2. Delete an Inventory\n 3. Update an Inventory\n4. Display Inventory details");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        /// calling a method from address utility class
                        InventoryManagerUtility.AddInventory();
                        break;

                    case "2":
                        InventoryManagerUtility.DeleteInventory();
                        break;
                    case "3":
                        InventoryManagerUtility.UpdateInventory();
                        break;
                    case "4":
                        InventoryManagerUtility.DisplayInventory();
                        break;
                }

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}
