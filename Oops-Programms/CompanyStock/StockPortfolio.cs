// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockPortfolio.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Oops_Programms.CompanyStock
{
    using System;
    using System.Collections.Generic;
    /// <summary>
    /// Company share details from json file
    /// </summary>

    class StockPortfolio
    {
        private string companyName;
        private int Shares;
        private double Price;

        //public string getCompanyName { get; set; }
        //public int getNoOfShares { get; set; }
        //public double getSharePrice { get; set; }

        public string CompanyName
        {
            get { return this.companyName; }
            set { this.companyName = value; }
        }
        public int NoOfShares
        {
            get { return this.Shares; }
            set { this.Shares = value; }
        }
        public double SharePrice
        {
            get { return this.Price; }
            set { this.Price = value; }
        }
    }
 
}
