// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEmployeeBusinessManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace BusinessManager.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using CommonLayer.Model;
    /// <summary>
    /// IEmployeeBusinessManager is 
    /// </summary>
    public interface IEmployeeBusinessManager
    {
        /// <summary>
        /// AddEmployee method is for adding the new Employee in the list 
        /// </summary>
        /// <param name="employeeModel"></param>
        /// <returns></returns>
        int AddEmployee(EmployeeModel employeeModel);
        
        bool DeleteEmployee(EmployeeModel employeeModel);

        void DisplayEmployee(EmployeeModel employeeModel);

        int UpdateEmployee(EmployeeModel employeeModel);

    }
}
