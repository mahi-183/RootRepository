// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClientAbstract.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatternApplication.BehavioralDesignPattern.MediatorDesignPattern
{
    using System;
    /// <summary>
    /// Absract class for development team
    /// </summary>
    public abstract class DevelopmentTeamAbstract
    {
        public string DevTeamType;
        protected MediatorManager mediator;

        /// <summary>
        /// initialize the MediatorManager refrence 
        /// </summary>
        /// <param name="Mediator"></param>
        public DevelopmentTeamAbstract(MediatorManager Mediator)
        {
            mediator = Mediator;
        }

        /// <summary>
        /// recive requirement from mediator
        /// </summary>
        /// <param name="Client"></param>
        public void RecieveRequirementFromMediator(ClientAbstract Client)
        {
            Console.WriteLine(this.DevTeamType + " has recieve requirement from " + Client.CientName);
        }

        /// <summary>
        /// send the query to the to client throgh the mediator
        /// </summary>
        public void SendQueryToMediator()
        {
            //send query to the mediator
            mediator.ReceiveQueryFromDevTeam("recieved query from"+this.DevTeamType);
        }
    }

    /// DevTeamA Development Team A
    public class DevTeamA : DevelopmentTeamAbstract
    {
        /// <summary>
        /// DevTeam constructor is initialize the base class constructor
        /// </summary>
        /// <param name="Mediator"></param>
        public DevTeamA(MediatorManager Mediator) : base(Mediator)
        {
        }
    }

    // DevTeamB is Development team B
    public class DevTeamB : DevelopmentTeamAbstract
    {
        public DevTeamB(MediatorManager Mediator) : base(Mediator)
        {
        }
    }
}
