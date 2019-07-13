// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Server.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatternApplication.StructuralDesignPattern.ProxyPattern
{
    using System;

    /// <summary>
    /// Server interface
    /// </summary>
    public interface InterfaceServer
    {
        void TakeOrder(string order);
        string DeliverOrder();
        void ProcessPayment(string payment);
    }

    public class Server : InterfaceServer
    {
        private string order;
        public string DeliverOrder()
        {
            return this.order;
        }

        public void ProcessPayment(string payment)
        {
            Console.WriteLine("Payment for the order is " + payment);
        }

        public void TakeOrder(string order)
        {
            Console.WriteLine("your order would be " + order);
            this.order = order;
        }
    }
}
