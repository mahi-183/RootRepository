// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreationalDesignPattern.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------


namespace DesignPatternApplication.CreationalDesignPattern
{
    using System;
    
    /// <summary>
    /// CreationalDesingPattern all operation 
    /// </summary>
    public class CreationalDesingPattern
    {
        public void CreationalDesignPatternOperations()
        {
            try
            {
                int SelectOption = 0;

                do
                {
                    Console.WriteLine("Select the Option for following Pattern:");
                    Console.WriteLine("1. Singlton Pattern " +
                                      "\n2. Factory Pattern " +
                                      "\n3. Prototype Design Pattern "
                                      );

                    SelectOption = Convert.ToInt32(Console.ReadLine());

                    switch (SelectOption)
                    {
                        case 1:
                            SingltonPatternApproches.SingltonPtternOperations();
                            break;

                        case 2:
                            FactoryPattern.FactoryPatternInput.factoryPatternInput();
                            break;

                        case 3:
                            PrototypePattern.ProtoTypeTest protoTypeTest = new PrototypePattern.ProtoTypeTest();
                            protoTypeTest.Prototype();
                            break;
                            
                        default:
                            Console.WriteLine(" SelectOption Invalid ...!");

                            Console.WriteLine(" Please ReEnter the SelectOption :");
                            break;
                    }
                } while (SelectOption<=0 && SelectOption>3);

                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
