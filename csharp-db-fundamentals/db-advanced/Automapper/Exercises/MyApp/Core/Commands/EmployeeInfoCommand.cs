﻿using AutoMapper;
using MyApp.Core.Contracts;
using MyApp.Core.ViewModels;
using MyApp.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Core.Commands
{
    public class EmployeeInfoCommand : ICommand
    {
        private readonly MyAppContext context;
        private readonly Mapper mapper;

        public EmployeeInfoCommand(MyAppContext context, Mapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public string Execute(string[] inputArgs)
        {
            if (inputArgs.Length != 1)
            {
                throw new ArgumentOutOfRangeException(null, "Provided arguments are incorrect!");
            }

            int employeeId = int.Parse(inputArgs[0]);

            var employee = context.Employees
                .Find(employeeId);

            if (employee == null)
            {
                throw new ArgumentNullException(null, $"Employee with ID: {employeeId} cannot be found!");
            }

            var employeeDto = this.mapper.CreateMappedObject<EmployeeDto>(employee);

            var result = $"ID: {employeeId} - {employeeDto.FirstName} {employeeDto.LastName} -  ${employeeDto.Salary:f2}";
            return result;
        }
    }
}
