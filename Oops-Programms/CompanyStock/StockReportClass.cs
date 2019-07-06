using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace Oops_Programms.CompanyStock
{
    class StockReportClass
    {
        public void StockReport()
        {
            try
            {
                string path = @"E:\ProgrammeFile\C#programmes\Oops-Programms\Oops-Programms\CompanyStock\CompanyStock.json";

                using (StreamReader reader = File.OpenText(path))
                {
                    string jsonstock = reader.ReadToEnd();

                    IList<StockPortfolio> data = JsonConvert.DeserializeObject<IList<StockPortfolio>>(jsonstock);
                    
                    foreach (var item in data)
                    {
                        Console.WriteLine("\nStoke Name::" + item.CompanyName + "\n" + "No. of shares::" + item.NoOfShares + "\n " + "Share Price::" + item.SharePrice);
                        double shareTotal = Calculate(item.SharePrice, item.NoOfShares);
                        Console.WriteLine("Total Share Price = " + shareTotal);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public double Calculate(double price, int number)
        {
            double shareTotal = 0;
            shareTotal = shareTotal + (price * number);
            return shareTotal;
        }
    }
}
