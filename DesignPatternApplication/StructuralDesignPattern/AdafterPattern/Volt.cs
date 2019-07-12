// --------------------------------------------------------------------------------------------------------------------
// <copyright file="volt.cs" company="Bridgelabz">
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
    /// volt class with details
    /// </summary>
    class Volt
    {
        private int volts;

        public Volt(int v)
        {
            this.volts = v;
        }

        /// <summary>
        /// Gets the volts.
        /// </summary>
        /// <returns></returns>
        public int GetVolts()
        {
            return this.volts;
        }

        /// <summary>
        /// Set volts the specified v.
        /// </summary>
        /// <param name="v">The v.</param>
        public void Setvolts(int v)
        {
            this.volts = v;
        }
    }
}
