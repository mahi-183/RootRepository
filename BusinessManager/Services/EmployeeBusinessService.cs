﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeBusinessService.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Mahesh Aurad"/>
// --------------------------------------------------------------------------------------------------------------------

namespace BusinessManager.Services
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BusinessManager.Interface;
    using CommonLayer.Model;
    using RepositoryManager.Interface;

    /// <summary>
    /// 
    /// </summary>
    public class EmployeeBusinessService : IEmployeeBusinessManager
    {
        public IEmployeeRepository repository;
        public EmployeeBusinessService(IEmployeeRepository repository)
        {
            this.repository = repository;
        }
        /// <summary>
        /// AddEmployee method is for adding the new Employee in the list 
        /// </summary>
        /// <param name="employeeModel"></param>
        /// <returns></returns>
        int AddEmployee(EmployeeModel employeeModel)
        {
            return 0;
        }

        bool DeleteEmployee(EmployeeModel employeeModel)
        {
            return true;
        }
        void DisplayEmployee(EmployeeModel employeeModel)
        {
        }

        int UpdateEmployee(EmployeeModel employeeModel)
        {
            return 0;
        }
}
