// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LazyInitializationSinglton.cs" company="Bridgelabz">
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
    /// LazyInitiazationsinglton for performing to check already instace created or not if created then that will refer to previous instance 
    /// </summary>
    public class LazyInitializationSinglton
    {
        private static LazyInitializationSinglton Instance = null;

        //private constructor to avoid client applications to use constructor
        private LazyInitializationSinglton()
        {
            Console.WriteLine("Inside Lazy Contructor");
        }

        //creates objects only once 
        public static LazyInitializationSinglton geInstance()
        {
            if (Instance == null)
            {
                Instance = new LazyInitializationSinglton();
            }
            return Instance;
        }
    }
}
