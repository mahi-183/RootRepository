// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConstructorInjection.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad "/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatternApplication.DependencyInjection
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class ConstructorInjection
    {
        /// <summary>
        /// ITextInterface as interface
        /// </summary>
        private ITextInterface textInterface;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstructorInjectionClass"/> class.
        /// </summary>
        /// <param name="text">text as parameter</param>
        public ConstructorInjection(ITextInterface text)
        {
            this.textInterface = text;
        }

        /// <summary>
        /// GetData as function
        /// </summary>
        public void GetData()
        {
            this.textInterface.Display();
        }
    }
}
