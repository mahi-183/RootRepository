using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternApplication.BehavioralDesignPattern.OberverDesignPattern
{
    using System.Collections.Generic;

    /// <summary>
    /// product details
    /// </summary>
    public interface IProduct
    {
        void Subscribe(Customer customer);
        void Unsubscribe(Customer customer);
        void Notify();
    }

    public class Product : IProduct
    {
        private readonly float basePrice;
        private readonly string name;
        private float currentPrice;

        List<Customer> customers = new List<Customer>();

        /// <summary>
        /// Initializes a new instance of the product
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="basePrice"></param>
        public Product(string productName, float basePrice)
        {
            this.name = productName;
            this.basePrice = basePrice;
            this.currentPrice = basePrice;
        }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public float Price
        {
            get
            {
                return this.basePrice;
            }

            set
            {   ////if the price will be less than the baseprice then notification will be sent to all subscribers 
                this.currentPrice = value;
                if (this.currentPrice <= this.basePrice)
                {
                    this.Notify();
                }
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        /// <summary>
        /// Gets the discount.
        /// </summary>
        /// <value>
        /// The discount.
        /// </value>
        public float Discount
        {
            get
            {
                return (this.basePrice + this.currentPrice) * 100 / this.basePrice;
            }
        }

        /// <summary>
        /// Gets the current price.
        /// </summary>
        /// <value>
        /// The current price.
        /// </value>
        public float CurrentPrice
        {
            get
            {
                return this.currentPrice;
            }
        }

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        public void Notify()
        {
            foreach (Customer observer in this.customers)
            {
                observer.Update(this);
            }
        }

        /// <summary>
        /// Subscribes the specified customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        public void Subscribe(Customer customer)
        {
            this.customers.Add(customer);
        }

        /// <summary>
        /// Unsubscribes the specified customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        public void Unsubscribe(Customer customer)
        {
            this.customers.Remove(customer);
        }
    }
}
