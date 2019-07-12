// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FactoryPatternInput.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------


namespace DesignPatternApplication.CreationalDesignPattern.FactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    class FactoryPatternInput
    {
        public static void factoryPatternInput()
        {
            try
            {
                /// factory pattern implementation 
                AbstractComputer pc = ComputerFactory.CreateComputer("PC", "2 GB", "500 GB", "2.4 Hz");
                AbstractComputer server = ComputerFactory.CreateComputer("server", "19 GB", "500 GB", "2.1 Hz");
                AbstractComputer laptop = ComputerFactory.CreateComputer("Laptop", "29 GB", "500 GB", "2.7 Hz");

                Console.WriteLine("Factory PC config:" + pc.toString());
                Console.WriteLine("Factory server config:" + server.toString());
                Console.WriteLine("Factory laptop config:" + laptop.toString());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
