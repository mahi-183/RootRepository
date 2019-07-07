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
    /// To Perform CRUD Operations 
    /// </summary>
    class InventoryManager
    {
        public void ManageInventory()
        {
            try
            {
                Utility utility = new Utility();
                int SelectOption = 0;
                //// choose an option to perform
                do
                {
                    Console.WriteLine("select the following::\n  1. Add new Inventory \n 2. Delete an Inventory\n 3. Update an Inventory\n4. Display Inventory details");
                    SelectOption = Convert.ToInt32(Console.ReadLine());
                    /// calling a method from InventoryManagerUtility
                    switch (SelectOption)
                    {
                        case 1:
                            InventoryManagerUtility.AddInventory();
                            break;

                        case 2:
                            InventoryManagerUtility.DeleteInventory();
                            break;
                        case 3:
                            InventoryManagerUtility.UpdateInventory();
                            break;
                        case 4:
                            InventoryManagerUtility.DisplayInventory();
                            break;
                        default:
                            Console.WriteLine("Invalid Choice ...Please Enter the valid choice..!");
                            break;
                    }
                    
                } while (SelectOption<=0 && SelectOption >4);
                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}
