using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;
using Newtonsoft.Json;
using SampleRESTApi.Models;

namespace SampleRESTApi.Controllers
{
    public class EmployeeController : ApiController
    {
        // this is in memory content, which we will play
        private static List<Employee> _employeeList = new List<Employee>()
        {
            new Employee() {Id = Guid.NewGuid(), Name = "Pritam Karmakar", Role = "QA"},
            new Employee() {Id = Guid.NewGuid(), Name = "Pinak Karmakar", Role = "Dev"},
            new Employee() {Id = Guid.NewGuid(), Name = "Indrani Karmakar", Role = "Designer"}
        };

        
        /// <summary>
        /// API to get all the employees. api/employee
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> Get()
        {
            //SetEmployee();
            return _employeeList;
        }

        // GET api/employee/5
        /// <summary>
        /// API to get details of a specific employee. api/employee/c6003094-0beb-4b71-b2f4-c1394330b37c
        /// </summary>
        /// <param name="id">employee id (GUID)</param>
        /// <returns></returns>
        public Employee Get(Guid id)
        {
            if (_employeeList.Count > 0)
            {
                return _employeeList.First(e => e.Id == id);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// API to add a new employee. api/employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public HttpResponseMessage Post(Employee employee)
        {
            _employeeList.Add(employee);
            var response = Request.CreateResponse<Employee>(HttpStatusCode.Created, employee);

            string uri = Url.Link("DefaultApi", new {id = employee.Id});
            response.Headers.Location = new Uri(uri);
            return response;
        }


        /// <summary>
        /// API to delete an existing employee by id. api/Employee/c6003094-0beb-4b71-b2f4-c1394330b37c
        /// </summary>
        /// <param name="id">employee id (GUID)</param>
        public void Delete(Guid id)
        {
            _employeeList.RemoveAll(i => i.Id == id);
        }
    }
}
