// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatternApplication
{
    using System;

    /// <summary>
    ///  main class of our application
    /// </summary>
    class Program
    {
        /// <summary>
        /// Start point of application
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            try
            {
                int SelectOption = 0;
                char ch = '\0';

                do
                {
                    Console.WriteLine("Select the Option for following Pattern:");
                    Console.WriteLine("1. Creational Desin Pattern " +
                                      "\n2. Structural Design Pattern " +
                                      "\n3. Behavioral Design Pattern "
                                      );

                    SelectOption = Convert.ToInt32(Console.ReadLine());

                    switch (SelectOption)
                    {
                        case 1:
                            CreationalDesignPattern.CreationalDesingPattern creationalDesing = new CreationalDesignPattern.CreationalDesingPattern();
                            creationalDesing.CreationalDesignPatternOperations();
                            break;

                        case 2:
                            StructuralDesignPattern.StucturalDesignPattern StructuralDesing = new StructuralDesignPattern.StucturalDesignPattern();
                            StructuralDesing.StructuralDesignPatternOperations();
                            break;

                        case 3:
                            BehavioralDesignPattern.BehavioralDesignPattern behavioralDesignPattern = new BehavioralDesignPattern.BehavioralDesignPattern();
                            behavioralDesignPattern.BehavioralDesignPatternOperations();
                            break;

                        default:
                            Console.WriteLine(" SelectOption Invalid ...!");
                            break;
                    }
                    Console.WriteLine("Enter Y / N For continue:");
                    ch = Convert.ToChar(Console.ReadLine());

                } while (ch !='N');


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        
        }
    }
}
