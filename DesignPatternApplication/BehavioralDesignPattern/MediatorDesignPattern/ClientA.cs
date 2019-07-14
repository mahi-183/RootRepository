// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClientA.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Aurad mahesh "/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatternApplication.BehavioralDesignPattern.MediatorDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class ClientA : ClientAbstract
    {
        public ClientA(MediatorManager Mediator) : base(Mediator)
        {
        }
    }

    public class ClientB : ClientAbstract
    {
        public ClientB(MediatorManager Mediator) : base(Mediator)
        {

        }
    }
}
