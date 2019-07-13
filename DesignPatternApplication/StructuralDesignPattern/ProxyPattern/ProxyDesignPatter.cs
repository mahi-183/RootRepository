// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProxyDesignPattern.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatternApplication.StructuralDesignPattern.ProxyPattern
{
    using System;

    /// <summary>
    /// Proxy pattern
    /// </summary>
    /// <seealso cref="DesignPattern.ProxyPattern.InterfaceServer" />
    public class Proxy : InterfaceServer
    {
        private string order;
        Server server = new Server();
        public string DeliverOrder()
        {
            return this.order;
        }

        /// <summary>
        /// Processes the payment.
        /// </summary>
        /// <param name="payment">The payment.</param>
        public void ProcessPayment(string payment)
        {
            Console.WriteLine("New Employee cannot process the payment");
            this.server.ProcessPayment(payment);
        }

        /// <summary>
        /// Takes the order.
        /// </summary>
        /// <param name="order">The order.</param>
        public void TakeOrder(string order)
        {
            Console.WriteLine("your order would be " + order);
            this.order = order;
        }
    }
}
