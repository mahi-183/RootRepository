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
    /// 
    /// </summary>
    class BehavioralDesignPattern
    {
        public void BehavioralDesignPatternOperations()
        {
            try
            {
                int SelectOption = 0;

                do
                {
                    Console.WriteLine("Select the Option for following Pattern:");
                    Console.WriteLine("1. Observer Pattern " +
                                      "\n2. Visitor Pattern " +
                                      "\n3. Mediator Design Pattern "
                                      );

                    SelectOption = Convert.ToInt32(Console.ReadLine());

                    switch (SelectOption)
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
                            //PrototypePattern.ProtoTypeTest protoTypeTest = new PrototypePattern.ProtoTypeTest();
                           // protoTypeTest.Prototype();
                            break;

                        default:
                            Console.WriteLine(" SelectOption Invalid ...!");

                            Console.WriteLine(" Please ReEnter the SelectOption :");
                            break;
                    }
                } while (SelectOption <= 0 && SelectOption > 3);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


    }
}
