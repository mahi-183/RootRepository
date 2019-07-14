// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AdafterPatternTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad "/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatternApplication.StructuralDesignPattern.AdafterPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// adapter class calls GetVolts through socket adapter
    /// </summary>
    public class AdafterPatternTest
    {
        /// <summary>
        /// The AdapterPatternTest method is calling the TestClassAdapter method and TestObjectAdapter 
        /// </summary>
        public void AdapterPatternTest()
        {
            this.TestClassAdapter();
            this.TestObjectAdapter();
        }

        /// <summary>
        /// Adapters this instance.
        /// </summary>
        private void TestClassAdapter()
        {
            ISocketAdapter socketAdapter = new SocketClassAdapterImpl();
            Volt v3 = this.GetVolt(socketAdapter, 3);
            Volt v12 = this.GetVolt(socketAdapter, 12);
            Volt v120 = this.GetVolt(socketAdapter, 120);
            Volt volt = this.GetVolt(socketAdapter, 0);
            Console.WriteLine("V3 Volts using Class Adapter::" + v3.GetVolts());
            Console.WriteLine("V12 Volts using Class Adapter::" + v12.GetVolts());
            Console.WriteLine("V120 Volts using Class Adapter::" + v120.GetVolts());
            Console.WriteLine("Default Volts using Class Adapter::" + volt.GetVolts());
        }

        /// <summary>
        /// Adapters this instance.
        /// </summary>
        private void TestObjectAdapter()
        {
            ISocketAdapter socketAdapter = new SocketClassAdapterImpl();
            Volt v3 = this.GetVolt(socketAdapter, 3);
            Volt v12 = this.GetVolt(socketAdapter, 12);
            Volt v120 = this.GetVolt(socketAdapter, 120);
            Volt volt = this.GetVolt(socketAdapter, 0);
            Console.WriteLine("V3 Volts using Object Adapter::" + v3.GetVolts());
            Console.WriteLine("V12 Volts using Object Adapter::" + v12.GetVolts());
            Console.WriteLine("V120 Volts using Object Adapter::" + v120.GetVolts());
            Console.WriteLine("Default Volts using Object Adapter::" + volt.GetVolts());
        }

        /// <summary>
        /// Gets the volt.
        /// </summary>
        /// <param name="socketAdapter">The socket adapter.</param>
        /// <param name="i">The i.</param>
        /// <returns>Volts.</returns>
        private Volt GetVolt(ISocketAdapter socketAdapter, int i)
        {
            switch (i)
            {
                case 3: return socketAdapter.Get3Volt();
                case 12: return socketAdapter.Get12Volt();
                case 120: return socketAdapter.Get120Volt();
                default: return socketAdapter.Get120Volt();
            }
        }
    }
}
