using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_Programms.CompanyStock
{
    using System;
    using System.Collections.Generic;
    /// <summary>
    /// Company share details from json file
    /// </summary>

    class StockPortfolio
    {
        private string name;
        private double noOfShares;
        private double price;

        public string Name { get; set; }
        public double Shares { get; set; }
        public double Price { get; set; }
    }
    public class StockList
    {
        public List<StockPortfolio> stocks { get; set; }
    }
}
