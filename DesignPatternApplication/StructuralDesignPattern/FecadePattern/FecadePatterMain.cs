using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternApplication.StructuralDesignPattern.FecadePattern
{
    class FecadePatterMain
    {
        public static void FecadePattern()
        {
            /// facade pattern implementation
            Facade facade = new Facade();
            Console.WriteLine("Enter your choice\n 1.Add Details to Address Book\n2.View Address Book");
            int book = Convert.ToInt32(Console.ReadLine());
            /// operations over address book
            switch (book)
            {
                case 1:
                    facade.AddDetails();
                    break;
                case 2:
                    facade.ViewAddressBook();
                    break;
            }
        }
    }
}
