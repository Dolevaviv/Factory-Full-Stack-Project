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
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class ExtendedEmpShift1Controller : ApiController
    {
        private static ExtendedEmpShift1BL bl = new ExtendedEmpShift1BL();
        // GET: api/ExtendedEmpShift1
        public IEnumerable<ExtendedEmpShift1> Get()
        {
            return bl.GetAllEmployeeAndShifts();
        }

        // GET: api/ExtendedEmpShift1/5
        public IEnumerable<ExtendedEmpShift1> Get(int id)
        {
            return bl.GetOneEmpShift(id);
        }

        // POST: api/ExtendedEmpShift1
        public string Post(ExtendedEmpShift1 empshift)
        {
            bl.AddEmpShift(empshift);
            return "Created";
        }

        // PUT: api/ExtendedEmpShift1/5
        public string Put(int id, EmployeeShift emp)
        {
            bl.UpdateEmpShift(id, emp);
            return "Updated";
        }

        // DELETE: api/ExtendedEmpShift1/5
        public void Delete(int id)
        {
        }
    }
}
