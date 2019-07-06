// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryData.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Oops_Programms.InventoryManagement
{
    using System;
    using System.Collections.Generic;
    /// <summary>
    /// Inventory details from json file
    /// </summary>
    public class InventoryData
    {
        private string name;
        private double weight;
        private double price;


        /// <summary>
        /// Gets or sets the inventoryname, weight,price.
        /// </summary>
        /// <value>
        /// The inventoryname.
        /// </value>
        //public string Name { get; set; }
       // private double Weight { get; set; }
        //private double Price { get; set; }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
    } 

    public class InventoryList
    {
        public List<InventoryData> Rice { get; set; }

        public List<InventoryData> Wheat { get; set; }

        public List<InventoryData> Pulses { get; set; }
    }
}
