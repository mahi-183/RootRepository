// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Socket.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatternApplication.StructuralDesignPattern.AdafterPattern
{
    using System;

    /// <summary>
    /// socket class with details
    /// </summary>

    class Socket
    {
        /// <summary>
        /// Gets the volts.
        /// </summary>
        /// <returns> volt </returns>
        public Volt GetVolts()
        {
            return new Volt(120);
        }
    }
}
