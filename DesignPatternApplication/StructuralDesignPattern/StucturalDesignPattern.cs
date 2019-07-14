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
                int selectOption = 0;

                do
                {
                    Console.WriteLine("Select the Option for following Pattern:");
                    Console.WriteLine("1. Adapter Design Pattern \n2. Facade Design Pattern \n3. Proxy Design Pattern ");

                    selectOption = Convert.ToInt32(Console.ReadLine());

                    switch (selectOption)
                    {
                        case 1:
                            AdafterPattern.AdafterPatternTest classAdapter = new AdafterPattern.AdafterPatternTest();
                            classAdapter.AdapterPatternTest();
                            break;

                        case 2:
                            FecadePattern.FecadePatterMain.FecadePattern();
                            break;

                        case 3:
                            ProxyPattern.ProxyPatterMain proxyPattern = new ProxyPattern.ProxyPatterMain();
                            proxyPattern.ProxyPatternInput();
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
