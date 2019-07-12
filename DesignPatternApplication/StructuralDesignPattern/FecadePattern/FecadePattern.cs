// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddAdress.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatternApplication.StructuralDesignPattern.FecadePattern
{
    public class Facade
    {
        private ReadAdressBook addressBook;
        private AddAdress addAdress;

        public Facade()
        {
            this.addressBook = new ReadAdressBook();
            this.addAdress = new AddAdress();
        }

        public void ViewAddressBook()
        {
            this.addressBook.DisplayAddress();
        }

        public void AddDetails()
        {
            this.addAdress.AddDetails();
        }
    }
}
