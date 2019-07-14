// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SocketAdafter.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Aurad mahesh "/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatternApplication.StructuralDesignPattern.AdafterPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// interface socket adapter
    /// </summary>
    internal interface ISocketAdapter
    {
        /// <summary>
        /// Get120s the volt.
        /// </summary>
        /// <returns>volt</returns>
        Volt Get120Volt();

        /// <summary>
        /// Get12s the volt.
        /// </summary>
        /// <returns>volt</returns>
        Volt Get12Volt();

        /// <summary>
        /// Get3s the volt.
        /// </summary>
        /// <returns>volt</returns>
        Volt Get3Volt();
    }
}
