using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace SampleRESTApi.Models
{

    /// <summary>
    /// Individual employee
    /// </summary>
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }

    static class Company
    {
        private static List<Employee> employees;

        /// <summary>
        /// List of employees
        /// </summary>
        public static List<Employee> Employees
        {
            get { return Company.employees; }
        }

        static Company()
        {
            employees = new List<Employee>()
            {
                new Employee() {Id = Guid.NewGuid(), Name = "Pritam Karmakar", Role = "QA"},
                new Employee() {Id = Guid.NewGuid(), Name = "Pinak Karmakar", Role = "Dev"},
                new Employee() {Id = Guid.NewGuid(), Name = "Indrani Karmakar", Role = "Designer"}
            };
        }
    }
}