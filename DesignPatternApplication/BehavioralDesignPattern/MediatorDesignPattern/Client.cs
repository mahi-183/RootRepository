﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Client.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatternApplication.BehavioralDesignPattern.MediatorDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// abstract class for client 
    /// </summary>
    public abstract class ClientAbstract
    {
        /// ClientName is the name of the Client and mediator is the reference of the MediatorManager 
        public string CientName;
        protected MediatorManager mediator;

        /// <summary>
        // initialize the abstract class properties 
        /// </summary>
        /// <param name="Mediator">Mediator</param>
        public ClientAbstract(MediatorManager Mediator)
        {
            mediator = Mediator;
        }
        /// <summary>
        // send client requirement to the mediator
        /// </summary>
        public void SendRequirementsToMediator()
        {
            //send requirements to mediator
             mediator.RecieveRequirementFromClient();
        }

        /// <summary>
        // Recieve query from mediator which send the development team
        /// </summary>
        /// <param name="query"></param>
        public void RecieveQueryFormMediator(string query)
        {
            Console.WriteLine(query);
        }
    }
}