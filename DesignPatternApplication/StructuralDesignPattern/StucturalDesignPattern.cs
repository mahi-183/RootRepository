// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StructuralDesignPattern.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatternApplication.StructuralDesignPattern
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    class StucturalDesignPattern
    {
        public void StructuralDesignPatternOperations()
        {
            try
            {
                int SelectOption = 0;

                do
                {
                    Console.WriteLine("Select the Option for following Pattern:");
                    Console.WriteLine("1. Adapter Design Pattern " +
                                      "\n2. Facade Design Pattern " +
                                      "\n3. Proxy Design Pattern "
                                      );

                    SelectOption = Convert.ToInt32(Console.ReadLine());

                    switch (SelectOption)
                    {
                        case 1:
                            // SingltonPatternApproches.SingltonPtternOperations();
                            AdafterPattern.AdafterPattern classAdapter = new AdafterPattern.AdafterPattern();
                            classAdapter.Adapter();
                            break;

                        case 2:
                            FecadePattern.FecadePatterMain.FecadePattern();
                            break;

                        case 3:
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
