// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MediatorDesignPatternMain.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Aurad mahesh "/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatternApplication.BehavioralDesignPattern.MediatorDesignPattern
{

    using System;
    using System.Collections.Generic;
    using System.Text;
    

    class MediatiorDesignPatternMain
    {
        public void MediatorPattern()
        {
            MediatorManager mediator = new MediatorManager();

            DevelopmentTeamAbstract devTeam = new DevTeamA(mediator);
            devTeam.DevTeamType = "Dev Team A";
            mediator.DevTeam = devTeam;//set DevTeam reference for mediator

            ClientAbstract client = new ClientA(mediator);
            client.CientName = "Client A";
            mediator.Client = client;

            client.SendRequirementsToMediator();//send the requirements to the mediator

            devTeam.SendQueryToMediator(); // send the query to the mediator

            DevelopmentTeamAbstract devTeam1 = new DevTeamA(mediator);
            devTeam1.DevTeamType = "Dev Team B";
            mediator.DevTeam = devTeam1;//set DevTeam reference for mediator

           
            ClientAbstract client1 = new ClientA(mediator);
            client1.CientName = "Client B";
            mediator.Client = client1;

            client1.SendRequirementsToMediator();//send the requirements to the mediator

            devTeam1.SendQueryToMediator(); // send the query to the mediator

            //Thread.Sleep(9000);
        }
    }
}
