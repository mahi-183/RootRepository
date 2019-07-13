using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternApplication.BehavioralDesignPattern.VisitorPattern
{
    class VisitorPatternMain
    {
        public void VisitorPattern()
        {
            /// list of store class items
            List<IStoreInterface> storeList = new List<IStoreInterface>
                            {
                                new Car() { CarName = "Audi A5000", CarType = "High", Price = 1000, Color = "Blue", Weight = "50kg" },
                                new Car() { CarName = "Alto ", CarType = "Normal", Price = 100, Color = "yellow", Weight = "20kg" },
                                new Bike() { BikeName = "Bullet", BikeType = "High", Price = 1000, Color = "Black", Weight = "30kg" },
                                new Bike() { BikeName = "Activa", BikeType = "Normal", Price = 600, Color = "Red", Weight = "20kg" }
                            };

            //// show price of store item
            PriceVisitor priceVisitor = new PriceVisitor();
            Console.WriteLine("\t\t\t Price Visitor");
            foreach (var element in storeList)
            {
                element.Visit(priceVisitor);
            }

            /// show features of store item
            FeaturesVisitor featuresVisitor = new FeaturesVisitor();
            Console.WriteLine("\t\t\t Features Visitor");
            foreach (var item in storeList)
            {
                item.Visit(featuresVisitor);
            }
        }
    }
}
