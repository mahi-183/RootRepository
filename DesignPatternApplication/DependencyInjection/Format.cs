// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Format.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad "/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatternApplication.DependencyInjection
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// FormatClass as class
    /// </summary>
    class Format : ITextInterface
    {
        /// <summary>
        /// Display as function
        /// </summary>
        public void Display()
        {
            try
            {
                Console.WriteLine("In format class implement interface method");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
