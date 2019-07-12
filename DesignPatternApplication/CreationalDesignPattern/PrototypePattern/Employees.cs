// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Employees.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatternApplication.CreationalDesignPattern.PrototypePattern
{
    using System;
    using System.Collections.Generic;
    /// <summary>
    /// Employee class implents the IClonable Interface 
    /// </summary>
    class Employees : ICloneable
    {
        private List<string> employeeList;

        public Employees()
        {
            this.employeeList = new ArrayList<string>();
        }

        public Employees(List<string> list)
        {
            this.employeeList = list;
        }

        public void AddData()
        {
            this.employeeList.Add("John");
            this.employeeList.Add("Bob");
            this.employeeList.Add("Clark");
            this.employeeList.Add("Lisa");
        }

        public List<string> GetEmployeeList()
        {
            return this.employeeList;
        }

        public object Clone()
        {
            List<string> tempList = new ArrayList<string>();
            foreach (string s in this.GetEmployeeList())
            {
                tempList.Add(s);
            }
            return new Employees(tempList);
        }
    }
}
