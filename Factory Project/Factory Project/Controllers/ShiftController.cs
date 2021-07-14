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

    public class ShiftController : ApiController
    {
        private static ExtendedShift1BL bl = new ExtendedShift1BL();
        // GET: api/Shift
        public IEnumerable<ExtendedShift> Get()
        {
            return bl.GetAllShifts();
        }

        // GET: api/Shift/5
        public IEnumerable<ExtendedShift> Get(int id)
        {
            return bl.GetShift(id);
        }

        //POST: api/Shift
        public int Post(shift1 shift)
        {
            return bl.addShift(shift);
        }

        //PUT: api/Shift/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Shift/5
        public void Delete(int id)
        {
        }
    }
}
