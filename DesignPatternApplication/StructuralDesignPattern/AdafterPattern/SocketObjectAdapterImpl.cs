// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SocketObjectAdapterImpl.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatternApplication.StructuralDesignPattern.AdafterPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class SocketObjectAdapterImpl : ISocketAdapter
    {
        //using composition for adapter pattern
        Socket socket = new Socket();

        //@Overrride of interface method
        public Volt Get120Volt()
        {
            return socket.GetVolts();
        }

        //@Overrride of interface method
        public Volt Get12Volt()
        {
            return socket.GetVolts();
        }
        //@Overrride of interface method  
        public Volt Get3Volt()
        {
            return socket.GetVolts();
        }
    }
}
