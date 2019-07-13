using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternApplication.StructuralDesignPattern.ProxyPattern
{
    class ProxyPatterMain
    {
        public void ProxyPatternInput()
        {
            Proxy proxy = new Proxy();
            Console.WriteLine("Would you like to order");
            string order = Console.ReadLine();
            proxy.TakeOrder(order);
            Console.WriteLine("your order is " + proxy.DeliverOrder());
            Console.WriteLine("Would you like to make payment");
            string payment = Console.ReadLine();
            proxy.ProcessPayment(payment);

        }
    }
}
