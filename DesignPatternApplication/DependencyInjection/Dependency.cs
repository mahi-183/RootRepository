// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Dependency.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad "/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatternApplication.DependencyInjection
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Dependency
    {
        /// <summary>
        /// DependencyFunction as function
        /// </summary>
        public static void DependencyFunction()
        {
            try
            {
                //// Create Instance of ConstructorInjectionClass class.
                ConstructorInjection constructorInjection = new ConstructorInjection(new Format());

                //// GetData functio called
                constructorInjection.GetData();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
