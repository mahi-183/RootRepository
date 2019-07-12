// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PC.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatternApplication.CreationalDesignPattern.FactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class PC : AbstractComputer
    {
        private string cpu;
        private string hdd;
        private string ram;

        public PC()
        {
        }

        public PC(string cpu, string hdd, string ram)
        {
            this.cpu = cpu;
            this.hdd = hdd;
            this.ram = ram;
        }

        public override string GetCPU()
        {
            return this.cpu;
        }

        public override string GetHDD()
        {
            return this.hdd;
        }

        public override string GetRAM()
        {
            return this.ram;
        }
    }
}
