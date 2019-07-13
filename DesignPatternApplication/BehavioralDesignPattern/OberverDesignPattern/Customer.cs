using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternApplication.BehavioralDesignPattern.OberverDesignPattern
{
    using System;

    /// <summary>
    /// observer pattern implementation
    /// </summary>
    public interface ICustomerInterface
    {
        void Update(Product product);
    }

    public class Customer : ICustomerInterface
    {
        private readonly string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Customer(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Updates the specified product.
        /// </summary>
        /// <param name="product">The product.</param>
        public void Update(Product product)
        {
            Console.WriteLine("{0} : {1}  is now available at {2} ;\nDiscount : {3}%", this.name, product.Name, product.CurrentPrice, product.Discount);
        }
    }
}
