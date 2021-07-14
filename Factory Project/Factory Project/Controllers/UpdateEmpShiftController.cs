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
    [EnableCors(origins: "*", methods: "*", headers: "*")]

    public class UpdateEmpShiftController : ApiController
    {
        private static UpdateEmpShiftBL bl = new UpdateEmpShiftBL();

        // GET: api/UpdateEmpShift
        public IEnumerable<UpdatingEmpShift> Get()
        {
            return bl.GetEmpAndShifts();
        }
        // GET: api/UpdateEmpShift/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UpdateEmpShift
        public string Post(EmployeeShift empS)
        {
            bl.AddEmployeeToNewShift(empS);
            return "Created";
        }

        // PUT: api/UpdateEmpShift/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UpdateEmpShift/5
        public void Delete(int id)
        {
        }
    }
}
