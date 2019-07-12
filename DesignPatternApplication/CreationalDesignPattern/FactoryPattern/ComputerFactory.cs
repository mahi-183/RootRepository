// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ComputerFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------


namespace DesignPatternApplication.CreationalDesignPattern.FactoryPattern
{
    using System;

    class ComputerFactory
    {
        public static AbstractComputer CreateComputer(string type, string ram, string hdd, string cpu)
        {
            if ("PC".Equals(type))
            {
                return new PC(cpu, hdd, ram);
            }
            else if ("server".Equals(type))
            {
                return new Server(cpu, hdd, ram);
            }
            else if ("Laptop".Equals(type))
            {
                return new Laptop(cpu, hdd, ram);
            }
            return null;
        }
    }
}
