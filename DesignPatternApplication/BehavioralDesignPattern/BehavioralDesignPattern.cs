// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BehavioralDesignPattern.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Aurad mahesh "/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatternApplication.BehavioralDesignPattern
{
    using System;

    /// <summary>
    /// BehavioralDesignPattern Operations
    /// </summary>
    public class BehavioralDesignPattern
    {
        /// The opration of the Behavioral Design Pattern 
        public void BehavioralDesignPatternOperations()
        {
            try
            {
                int selectOption = 0;
                do
                {
                    Console.WriteLine("Select the Option for following Pattern:");
                    Console.WriteLine("1. Observer Pattern \n2. Visitor Pattern \n3. Mediator Design Pattern ");

                    selectOption = Convert.ToInt32(Console.ReadLine());

                    switch (selectOption)
                    {
                        case 1:
                            OberverDesignPattern.ObesrverDesignPatternMain obesrverDesignPatternMain = new OberverDesignPattern.ObesrverDesignPatternMain();
                            obesrverDesignPatternMain.ObserverPattern();
                            break;

                        case 2:
                            VisitorPattern.VisitorPatternMain visitorDesignPatternMain = new VisitorPattern.VisitorPatternMain();
                            visitorDesignPatternMain.VisitorPattern();
                            break;

                        case 3:
                            MediatorDesignPattern.MediatiorDesignPatternMain mediatorPattern = new MediatorDesignPattern.MediatiorDesignPatternMain();
                            mediatorPattern.MediatorPattern();
                            break;

                        default:
                            Console.WriteLine(" SelectOption Invalid ...!");

                            Console.WriteLine(" Please ReEnter the SelectOption :");
                            break;
                    }
                } while (selectOption <= 0 && selectOption > 3);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
