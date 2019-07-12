using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternApplication.StructuralDesignPattern.AdafterPattern
{
    /// <summary>
    /// interface socket adapter
    /// </summary>
    internal interface ISocketAdapter
    {
        /// <summary>
        /// Get120s the volt.
        /// </summary>
        /// <returns></returns>
        Volt Get120Volt();

        /// <summary>
        /// Get12s the volt.
        /// </summary>
        /// <returns></returns>
        Volt Get12Volt();

        /// <summary>
        /// Get3s the volt.
        /// </summary>
        /// <returns></returns>
        Volt Get3Volt();
    }
}
