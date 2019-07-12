// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrototypeTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------


namespace DesignPatternApplication.CreationalDesignPattern.PrototypePattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class ProtoTypeTest
    {
        public void Prototype()
        {
            Employees employee = new Employees();
            employee.AddData();

            Employees newList = (Employees)employee.Clone();
            Employees newList1 = (Employees)employee.Clone();
            
            List<string> employeeList = employee.GetEmployeeList();
            //employeeList.Add("Clara");
            List<string> list = newList.GetEmployeeList();
            list.Add("Clara");
            List<string> list1 = newList1.GetEmployeeList();
            list1.Remove("Bob");
            Console.Write("Employee List:: (");
            foreach (string items in employee.GetEmployeeList())
            {
                Console.Write(items + " ");
            }
            Console.Write(")");
            Console.Write("\nEmployee New List:: (");
            foreach (string s in list)
            {
                Console.Write(s + " ");
            }
            Console.Write(")");
            Console.Write("\nEmployee New 2nd List:: (");
            foreach (string s in list1)
            {
                Console.Write(s + " ");
            }

            Console.Write(")");
            Console.Write("\nEmployee List Object:: (");
            foreach (string items in employeeList)
            {
                Console.Write(items + " ");
            }
            Console.Write(")");
            Console.WriteLine("Asci value of all objects : employee{0} ,list {1} and list1 {2}",employee.GetHashCode() ,newList.GetHashCode(), newList1.GetHashCode());
            
            Console.Write(")");
        }
    }
}
