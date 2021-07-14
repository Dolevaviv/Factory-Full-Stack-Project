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

    public class jShiftsController : ApiController
    {
        private static jShifts bl = new jShifts();
        // GET: api/JShift
        public IEnumerable<shift1> Get()
        {
            return bl.GetAllShifts();
        }

        // GET: api/JShift/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/JShift
        public int Post(shift1 sh)
        {
            return bl.AddJustShift(sh);
        }

        // PUT: api/JShift/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/JShift/5
        public void Delete(int id)
        {
        }
    }
}
