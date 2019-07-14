// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SocketAdafterImpl.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatternApplication.StructuralDesignPattern.AdafterPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// socket adapter class
    /// </summary>
    /// <seealso cref="DesignPattern.AdapterPattern.Socket" />
    /// <seealso cref="DesignPattern.AdapterPattern.ISocketAdapter" />
    class SocketClassAdapterImpl : Socket, ISocketAdapter
    {
        /// Get120Volt method is for getting the 120v
        public Volt Get120Volt()
        {
            return this.GetVolts();
        }

        public Volt Get12Volt()
        {
            Volt v = GetVolts();
            return this.ConvertVolts(v, 10);
        }

        public Volt Get3Volt()
        {
            Volt v = GetVolts();
            return this.ConvertVolts(v, 40);
        }

        private Volt ConvertVolts(Volt v, int i)
        {
            return new Volt(v.GetVolts() / i);
        }
    }
}
