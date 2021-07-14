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

    public class CheckNumberOfActionsController : ApiController
    {
        private static CheckNumberOfActionsBL bl = new CheckNumberOfActionsBL();

        // GET: api/CheckNumberOfActions
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CheckNumberOfActions/5
        public bool Get(int id)
        {
            return bl.CheckNumberOfActions(id);
        }

        // POST: api/CheckNumberOfActions
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/CheckNumberOfActions/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/CheckNumberOfActions/5
        public void Delete(int id)
        {
        }
    }
}
