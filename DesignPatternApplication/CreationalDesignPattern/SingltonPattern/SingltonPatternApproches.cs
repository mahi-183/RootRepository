// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Singlton.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Aurad mahesh "/>
// --------------------------------------------------------------------------------------------------------------------


namespace DesignPatternApplication.CreationalDesignPattern
{
    using System;

    /// <summary>
    /// All various singlton approches that are possible.
    /// </summary>
    class SingltonPatternApproches
    {
        /// Switch case for all opssible approches for singlton.
        public static void SingltonPtternOperations()
        {
            try
            {
                int SelectOption = 0;

                do
                {
                    Console.WriteLine("Select the Option for following Operation:");
                    Console.WriteLine("1. EgerInitializationSinglton " +
                                      "\n2. StaticBlockInitializationSinglton" +
                                      "\n3. LazzyInitializationSinglton " +
                                      "\n4. TreadSafeSinglton " +
                                      "\n5. BillpughSinglton " +
                                      "\n6. Using Refection to distroy Singlton pattern Operation" +
                                      "\n7. EnumSinglton " +
                                      "\n8. Serialization and Singlton Operation"
                                      );

                    SelectOption = Convert.ToInt32(Console.ReadLine());

                    switch (SelectOption)
                    {
                        case 1:
                            DisplayUtility.EgerInitializationDisplay();
                            break;

                        case 2:
                            
                            break;

                        case 3:
                            DisplayUtility.LazyInitializationDisplay();
                            break;

                        case 4:
                            DisplayUtility.ThreadSafeInitializationDisplay();
                             break;

                        case 5:
                            break;

                        case 6:
                            // EgerInitializationSinglton Instance = EgerInitializationSinglton.getIntance();
                            break;

                        case 7:
                            // EgerInitializationSinglton Instance = EgerInitializationSinglton.getIntance();
                            break;
                        case 8:
                            //EgerInitializationSinglton Instance = EgerInitializationSinglton.getIntance();
                            break;

                        default:
                            Console.WriteLine(" SelectOption Invalid ...!");

                            Console.WriteLine(" Please ReEnter the SelectOption :");
                            break;
                    }
                } while (SelectOption <= 0 && SelectOption > 8);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
