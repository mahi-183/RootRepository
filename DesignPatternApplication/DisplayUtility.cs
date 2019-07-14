// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DisplayUtility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Aurad mahesh "/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatternApplication.CreationalDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// DisplayUtility which contains all patterns diplay methods
    /// </summary>
    public class DisplayUtility
    {
        ///LazyInitialization Display method
        public static void EgerInitializationDisplay()
        {
            try
            {

                SingltonPattern.EgerInitializationSinglton Instance = SingltonPattern.EgerInitializationSinglton.getIntance();
                SingltonPattern.EgerInitializationSinglton Instance1 = SingltonPattern.EgerInitializationSinglton.getIntance();
                SingltonPattern.EgerInitializationSinglton Instance2 = SingltonPattern.EgerInitializationSinglton.getIntance();
                if (Instance == Instance2)
                {
                    Console.WriteLine("All Instances are refering same objects");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            //Console.WriteLine("FirstInstance {0} \n SecondInstance {1} \n ThirdInstance {2}", Instance.GetHashCode(), Instance1.GetHashCode(), Instance2.GetHashCode());

        }

        ///LazyInitialization Display method
        public static void LazyInitializationDisplay()
        {
            try
            {

                SingltonPattern.LazyInitializationSinglton LazyInstance = SingltonPattern.LazyInitializationSinglton.geInstance();
                SingltonPattern.LazyInitializationSinglton LazyInstance1 = SingltonPattern.LazyInitializationSinglton.geInstance();
                SingltonPattern.LazyInitializationSinglton LazyInstance2 = SingltonPattern.LazyInitializationSinglton.geInstance();
                // Console.WriteLine("FirstInstance {0} \n SecondInstance {1} \n ThirdInstance {3}", LazyInstance.GetHashCode(), LazyInstance1.GetHashCode(), LazyInstance2.GetHashCode());
                if (LazyInstance == LazyInstance2)
                {
                    Console.WriteLine("All Instances are refering same objects");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }

        ///ThreadSafeInitialization Display method
        public static void ThreadSafeInitializationDisplay()
        {
            SingltonPattern.ThreadSafeSinglton threadInstance = SingltonPattern.ThreadSafeSinglton.getInstance();
            SingltonPattern.ThreadSafeSinglton threadInstance1 = SingltonPattern.ThreadSafeSinglton.getInstance();
            SingltonPattern.ThreadSafeSinglton threadInstance2 = SingltonPattern.ThreadSafeSinglton.getInstance();
            if (threadInstance == threadInstance1)
            {
                Console.WriteLine("All Instances are refering same objects");
            }

        }
    }
}