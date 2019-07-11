// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StaticBlockInitialization.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatternApplication.CreationalDesignPattern.SingltonPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// StaticBlockInitialization class provides the option for exception handling
    /// </summary>
    public class StaticBockInitialization
    {
        private static StaticBockInitialization instance;

        //private constructor to avoid client applications to use constructor
        private StaticBockInitialization()
        {

        }
    }
}
