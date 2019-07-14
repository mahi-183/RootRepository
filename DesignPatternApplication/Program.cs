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
    public class Program
    {
        /// <summary>
        /// Start point of application
        /// </summary>
        /// <param name="args">Command line Argument.</param>
        public static void Main(string[] args)
        {
            try
            {
                int selectOption = 0;
                char ch = '\0';

                do
                {
                    Console.WriteLine("Select the Option for following Pattern:");
                    Console.WriteLine("1. Creational Desin Pattern \n2. Structural Design Pattern \n3. Behavioral Design Pattern \n4. Delegate \n5. Rflection \n6.Dependency Injection \n7. Annotation \n8. Decorator");

                    selectOption = Convert.ToInt32(Console.ReadLine());
                    switch (selectOption)
                    {
                        case 1:
                            CreationalDesignPattern.CreationalDesingPattern creationalDesing = new CreationalDesignPattern.CreationalDesingPattern();
                            creationalDesing.CreationalDesignPatternOperations();
                            break;
                        case 2:
                            StructuralDesignPattern.StucturalDesignPattern structuralDesing = new StructuralDesignPattern.StucturalDesignPattern();
                            structuralDesing.StructuralDesignPatternOperations();
                            break;
                        case 3:
                            BehavioralDesignPattern.BehavioralDesignPattern behavioralDesignPattern = new BehavioralDesignPattern.BehavioralDesignPattern();
                            behavioralDesignPattern.BehavioralDesignPatternOperations();
                            break;
                        case 4:
                            Delegate.Delegates.MainDelegate();
                            break;
                        case 5:
                            Reflection.ReflectionMain.ReflectionFunction();
                            break;
                        case 6:
                            DependencyInjection.Dependency.DependencyFunction();
                            break;
                        case 7:
                            Annotation.Annotation.AnnotationFunction();
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