// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockAccountData.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------


namespace Oops_Programms.DataProceesing
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// 
    /// </summary>
   public  class StockAccountData
    {
        
        private string cnmae  { get; set; }
        private int Shares { get; set; }
        private double price { get; set; }


        public string CompanyName
        {
            get { return this.cnmae; }
            set { this.cnmae = value; }
        }
        public int NoOfShares
        {
            get { return this.Shares; }
            set { this.Shares = value; }
        }
        public double SharePrice
        {
            get { return this.price; }
            set { this.price = value; }
        }
    }
    class StockAccountList
    {
        public List<StockAccountData> CompanyDetails { get; set; }
     }

}
