// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EgerInitializationSinglton.cs" company="Bridgelabz">
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
    //EgerInitializationSinglton class must be instantiated one and only once in the application; it is to ensure that the
    //application makes use of that same EgerInitializationSinglton instance
    /// </summary>
    public class EgerInitializationSinglton
    {
        private static EgerInitializationSinglton Instance = new EgerInitializationSinglton();

        //private constructor to avoid client applications to use constructor
        private EgerInitializationSinglton()
        {
            Console.WriteLine("Inside EgerInitialization Constructur");
        }

        //the static method to be used by clients to get the instance of the Logger class
        public static EgerInitializationSinglton getIntance()
        {
            //this is the first time this method is called,
            //and that's why Instance is null
            return Instance;
        }
    }
}
