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

    public class DepartmentController : ApiController
    {
        static departmentBL bl = new departmentBL();
        // GET: api/Department
        public IEnumerable<DepAndEmps>get()
        {
            return bl.GetAllDepartments();
        }
        // GET: api/Department/5
        public DepAndEmps Get(int id)
        {
            return bl.GetDepartment(id);
        }


        public int Post(Department dep)
        {
            return bl.AddDepartment(dep);
        }

        // PUT: api/Department/5
        public string Put(int id, Department dep)
        {

            bl.UpdateDepartment(id, dep);
            return "Updated";
        }

        //DELETE: api/Department/5
        public string Delete(int id)
        {
            return bl.DeleteDepartment(id);

        }
    }
}
