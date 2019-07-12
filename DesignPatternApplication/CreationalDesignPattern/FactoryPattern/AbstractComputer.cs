// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Computer.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatternApplication.CreationalDesignPattern.FactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class AbstractComputer
    {
        public abstract string GetRAM();
        public abstract string GetHDD();
        public abstract string GetCPU();

        /// overidern
        /// we have abstract super class with overridden toString() method for testing purpose
        public string toString()
        {
            return "(Ram= " + this.GetRAM() + ",HDD= " + this.GetHDD() + ",CPU=" + this.GetCPU() + ")";
        }
    }
}
