using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternApplication.BehavioralDesignPattern.VisitorPattern
{
    using System;

    /// <summary>
    /// visitor pattern implementation
    /// </summary>
    public interface IVisitor
    {
        void Accept(Car car);
        void Accept(Bike bike);
    }

    public class PriceVisitor : IVisitor
    {
        private int carDiscount = 5;
        private int bikeDiscount = 15;

        /// <summary>
        /// Accepts the specified car.
        /// </summary>
        /// <param name="car">The car.</param>
        public void Accept(Car car)
        {
            float discountPrice = car.Price - (car.Price * this.carDiscount / 100);
            Console.WriteLine("\n" + car.CarName + " is priced " + car.Price + "\n Dicounted Price : " + discountPrice);
        }

        /// <summary>
        /// Accepts the specified bike.
        /// </summary>
        /// <param name="bike">The bike.</param>
        public void Accept(Bike bike)
        {
            float discountPrice = bike.Price - (bike.Price * this.bikeDiscount / 100);
            Console.WriteLine("\n" + bike.BikeName + " is priced " + bike.Price + " \nDicounted Price : " + discountPrice);
        }
    }

    /// <summary>
    /// features of car and bike
    /// </summary>
    /// <seealso cref="DesignPattern.VisitorPattern.IVisitor" />
    public class FeaturesVisitor : IVisitor
    {
        /// <summary>
        /// Accepts the specified car.
        /// </summary>
        /// <param name="car">The car.</param>
        public void Accept(Car car)
        {
            switch (car.CarType)
            {
                case "High":
                    Console.WriteLine(" \n\t\t\t\tCar Features are::\n Car Type: {0} \nName:{1} \nColour: {2}\nWeight: {3}", car.CarType, car.CarName, car.Weight, car.Color);
                    break;
                case "Normal":
                    Console.WriteLine("\n \t\t\t\tCar Features are::\n Car Type: {0} \nName:{1} \nColour: {2}\nWeight: {3}", car.CarType, car.CarName, car.Weight, car.Color);
                    break;
            }
        }

        /// <summary>
        /// Accepts the specified bike.
        /// </summary>
        /// <param name="bike">The bike.</param>
        public void Accept(Bike bike)
        {
            switch (bike.BikeType)
            {
                case "High":
                    Console.WriteLine(" \n\t\t\t\tBike Features are::\n Bike Type: {0} \nName:{1} \nColour: {2}\nWeight: {3}", bike.BikeType, bike.BikeName, bike.Color, bike.Weight);
                    break;
                case "Normal":
                    Console.WriteLine(" \n\t\t\t\tBike Features are::\n Car Type: {0} \nName:{1}\n Colour: {2}\nWeight: {3}", bike.BikeType, bike.BikeName, bike.Color, bike.Weight);
                    break;
            }
        }
    }
}
