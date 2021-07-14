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

    public class UserNameController : ApiController
    {
        private static UserNameBL bl = new UserNameBL();
        // GET: api/UserName
        public IEnumerable<user> Get()
        {
            return bl.GetAllData();
        }

        // GET: api/UserName/5
        public user Get(int id)
        {
            return bl.GetByID(id);
        }

        // POST: api/UserName
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/UserName/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UserName/5
        public void Delete(int id)
        {
        }
    }
}
