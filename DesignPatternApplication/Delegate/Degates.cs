// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Delegates.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad "/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatternApplication.Delegate
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public delegate void Mydelegate(string message);
    public class Delegates
    {
        public static void MainDelegate()
        {
            try
            {
                test t1 = new test();
                t1.Message("Think Positive");
                Mydelegate mydelegate = new Mydelegate(t1.Message);
                mydelegate("Failure is the first step of success......");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }

    public class test
    {
        public void Message(string message)
        {
            try
            {
                Console.WriteLine("My Message = " + message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
