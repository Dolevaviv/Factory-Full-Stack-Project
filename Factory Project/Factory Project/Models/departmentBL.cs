using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory_Project.Models
{
    public class departmentBL
    {
        FactoryDBEntities1 db = new FactoryDBEntities1();

        public List<DepAndEmps> GetAllDepartments()
        {
            List<DepAndEmps> list2 = new List<DepAndEmps>();
            foreach (var dep in db.Departments)
            {
                DepAndEmps DepAndEmps = new DepAndEmps();
                DepAndEmps.ID = dep.ID;
                DepAndEmps.Name = dep.Name;
                DepAndEmps.Manager = dep.Manager;
                if (DepAndEmps.Manager.HasValue)
                {

                    foreach (var emp in db.Employees.Where(x => x.ID == DepAndEmps.Manager))
                    {
                        DepAndEmps.managerfName = emp.First_Name;
                        DepAndEmps.managerlName = emp.Last_Name;

                    }
                }
                list2.Add(DepAndEmps);
            }

            return list2;
        }

        public DepAndEmps GetDepartment(int depID)
        {
            Department dep = db.Departments.Where(x => x.ID == depID).First();

            DepAndEmps DepAndEmps = new DepAndEmps();
            DepAndEmps.ID = dep.ID;
            DepAndEmps.Name = dep.Name;
            DepAndEmps.Manager = dep.Manager;
            if (DepAndEmps.Manager.HasValue)
            {

                foreach (var emp in db.Employees.Where(x => x.ID == DepAndEmps.Manager))
                {
                    DepAndEmps.managerfName = emp.First_Name;
                    DepAndEmps.managerlName = emp.Last_Name;

                }
            }
            return DepAndEmps;

        }


        public int AddDepartment(Department dep)
        {
            db.Departments.Add(dep);
            db.SaveChanges();
            return dep.ID;

        }

        public void UpdateDepartment(int id, Department dep)
        {
            var currentDep = db.Departments.Where(x => x.ID == id).First();
            currentDep.Name = dep.Name;
            currentDep.Manager = dep.Manager;
            db.SaveChanges();
        }


        public string DeleteDepartment(int id)
        {
            var currentDep = db.Departments.Where(x => x.ID == id).First();
            //if (currentDep.Manager.HasValue = false)
            //{
                db.Departments.Remove(currentDep);
                db.SaveChanges();
                return "Deleted";
            //}
            //else
            //{
            //    return "Can't delete this department";
            //}

        }



    }
}