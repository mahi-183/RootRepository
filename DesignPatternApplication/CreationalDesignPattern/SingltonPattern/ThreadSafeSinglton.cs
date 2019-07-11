// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ThreadSafeSinglton.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Aurad mahesh "/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatternApplication.CreationalDesignPattern.SingltonPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    /// <summary>
    /// This implementation is Thread-safe
    /// </summary>
    public sealed   class ThreadSafeSinglton
    {
        private static ThreadSafeSinglton instance = null;

        private static readonly object padlock = new object();

        ThreadSafeSinglton()
        {
            Console.WriteLine("Threadsafe Constructer");
        }
        ///The thread takes out a lock on a shared object, 
        ///and then checks whether or not the instance has been created before creating the instance.
        public static ThreadSafeSinglton getInstance()
        {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSinglton();
                    }
                    return instance;
                }
         
        }
    }
}
