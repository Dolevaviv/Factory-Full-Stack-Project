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

    public class UserController : ApiController
    {
        private static UserBL bL = new UserBL();

        // GET: api/User
        public IEnumerable<user> Get()
        {
            return bL.getAllUsers();
        }

        // GET: api/User/5
        public user Get(int id)
        {
            return bL.GetUserById(id);
        }

        // POST: api/User
        public int Post(user us)
        {
            return bL.AddUser(us);
        }

        // PUT: api/User/5
        public string Put(int id, user us)
        {
            bL.UpdateUser(id, us);
            return "Updated";
        }

        // DELETE: api/User/5
        public string Delete(int id)
        {
            bL.DeleteUser(id);
            return "Deleted";
        }
    }
}
