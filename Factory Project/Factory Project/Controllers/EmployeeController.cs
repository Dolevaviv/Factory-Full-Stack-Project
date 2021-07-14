using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http; 
using System.Web.Http.Cors;
using Factory_Project.Models;
namespace Factory_Project.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class EmployeeController : ApiController
    {
        private static ExtendedEmpBL bl = new ExtendedEmpBL();
        // GET: api/Employee
        public IEnumerable<ExtendedEmp> Get()
        {
            return bl.GetAllEmployees();
        }

        // GET: api/Employee/5
        public IEnumerable<ExtendedEmp> Get(int id)
        {
            return bl.GetEmployee(id);
        }

        //// POST: api/Employee
        public int Post(Employee emp)
        {
            return bl.AddEmployee(emp);

        }

        //// PUT: api/Employee/5
        public string Put(int id, Employee emp)
        {
            bl.UpdateEmployee(id, emp);
            return "Updated";
        }

        //// DELETE: api/Employee/5
        public string Delete(int id)
        {
            bl.DeleteEmployee(id);
            return "Deleted";
        }
    }
}
