// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Server.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------



namespace DesignPatternApplication.CreationalDesignPattern.FactoryPattern
{
    using System;

    class Server : AbstractComputer
    {

        private string cpu;
        private string hdd;
        private string ram;

        public Server(string cpu, string hdd, string ram)
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
