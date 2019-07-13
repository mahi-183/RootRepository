using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternApplication.BehavioralDesignPattern.VisitorPattern
{
    /// <summary>
    /// visitor pattern implementation
    /// </summary>
    public interface IStoreInterface
    {
        void Visit(IVisitor vistor);
    }

    public class Car : IStoreInterface
    {
        public string CarName { get; set; }

        public string CarType { get; set; }

        public float Price { get; set; }

        public string Color { get; set; }

        public string Weight { get; set; }

        /// <summary>
        /// Visits the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public void Visit(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }

    public class Bike : IStoreInterface
    {
        public string BikeName { get; set; }

        public string BikeType { get; set; }

        public float Price { get; set; }

        public string Color { get; set; }

        public string Weight { get; set; }

        /// <summary>
        /// Visits the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public void Visit(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }
}
