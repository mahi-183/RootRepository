using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternApplication.BehavioralDesignPattern.MediatorDesignPattern
{
    public class MediatorManager
    {
        public ClientAbstract Client { get; set; }
        public DevelopmentTeamAbstract DevTeam { get; set; }

        public void RecieveRequirementFromClient()
        {
            //Mediator forword requirement to development team
            DevTeam.RecieveRequirementFromMediator(Client);
        }

        public void ReceiveQueryFromDevTeam(string query)
        {
            //Mediator forword the query to the client
            Client.RecieveQueryFormMediator(query);
        }
    }
}
