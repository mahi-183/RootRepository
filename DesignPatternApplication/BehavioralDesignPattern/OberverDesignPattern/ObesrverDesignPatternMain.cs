using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternApplication.BehavioralDesignPattern.OberverDesignPattern
{
    class ObesrverDesignPatternMain
    {
        public void ObserverPattern()
        {
            Console.WriteLine("Enter the product Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the product price");

            float price = (float)Convert.ToDouble(Console.ReadLine());
            Product product = new Product(name, price);
            Console.WriteLine("Customer 1 and 2 gets subscribed to the product " + name);
            ////subscribe customers
            Customer customerOne = new Customer("Clara");
            product.Subscribe(customerOne);
            Customer customerTwo = new Customer("Jack");
            product.Subscribe(customerTwo);

            //// publish notification to subcribers
            product.Price = 500;

            Console.WriteLine("Customer 2 gets unsubscribed and customer 3 gets subscribed to the product " + name);
            //// customer two is unsubscribed and customer three is subscribed 
            product.Unsubscribe(customerTwo);
            //// customer gets subscribed
            Customer customerThree = new Customer("Jennie");
            product.Subscribe(customerThree);

            product.Price = 700;

        }
    }
}
