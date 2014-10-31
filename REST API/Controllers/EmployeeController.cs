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
            new Employee() {Id = 1, Name = "Pritam Karmakar", Role = "QA"},
            new Employee() {Id = 2, Name = "Pinak Karmakar", Role = "Dev"},
            new Employee() {Id = 3, Name = "Indrani Karmakar", Role = "Designer"}
        };

        
        // GET api/employee
        // GET request to get all the employees
        public IEnumerable<Employee> Get()
        {
            //SetEmployee();
            return _employeeList;
        }

        // GET api/employee/5
        // Get request to get details on a specific employee
        public IEnumerable<Employee> Get(int id)
        {
            if (_employeeList.Count > 0)
            {
                return _employeeList.Where(e => e.Id == id);
            }
            else
            {
                return null;
            }
        }

        // POST api/employee
        // POST request to add a new employee
        public HttpResponseMessage Post(Employee employee)
        {
            _employeeList.Add(employee);
            var response = Request.CreateResponse<Employee>(HttpStatusCode.Created, employee);

            string uri = Url.Link("DefaultApi", new {id = employee.Id});
            response.Headers.Location = new Uri(uri);
            return response;
        }

        // DELETE api/employee/5
        // DELETE operation to delete an existing employee by ID
        public void Delete(int id)
        {
            _employeeList.RemoveAll(i => i.Id == id);
        }
    }
}
