using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory_Project.Models
{
    public class ExtendedEmpBL
    {
        FactoryDBEntities1 db = new FactoryDBEntities1();

        public List<ExtendedEmp> GetAllEmployees()
        {


            List<ExtendedEmp> list2 = new List<ExtendedEmp>();

            foreach (var emp in db.Employees.OrderBy(x => x.Last_Name))
            {
                ExtendedEmp extendedEmp = new ExtendedEmp();
                extendedEmp.ID = emp.ID;
                extendedEmp.First_Name = emp.First_Name;
                extendedEmp.Last_Name = emp.Last_Name;
                extendedEmp.Start_Work_Year = emp.Start_Work_Year;
                extendedEmp.DepartmentID = emp.DepartmentID;
                extendedEmp.shifts = new List<shift1>();

                foreach (var eshift in db.EmployeeShifts.Where(x => x.EmployeeID == emp.ID))
                {
                    foreach (var sh1 in db.shift1.Where(x => x.ID == eshift.ShiftID))
                    {
                        extendedEmp.shifts.Add(sh1);
                    }
                }
                list2.Add(extendedEmp);



            }
            return list2;
        }

        public List<ExtendedEmp> GetEmployee(int id)
        {

            List<ExtendedEmp> lst = new List<ExtendedEmp>();

            foreach (var emp in db.Employees.Where(x => x.ID == id))
            {
                ExtendedEmp extendedEmp = new ExtendedEmp();
                extendedEmp.ID = emp.ID;
                extendedEmp.First_Name = emp.First_Name;
                extendedEmp.Last_Name = emp.Last_Name;
                extendedEmp.Start_Work_Year = emp.Start_Work_Year;
                extendedEmp.DepartmentID = emp.DepartmentID;
                extendedEmp.shifts = new List<shift1>();

                foreach (var eshift in db.EmployeeShifts.Where(x => x.EmployeeID == emp.ID))
                {
                    foreach (var sh1 in db.shift1.Where(x => x.ID == eshift.ShiftID))
                    {
                        extendedEmp.shifts.Add(sh1);
                    }
                }
                lst.Add(extendedEmp);

            }
            return lst;

        }

        public int AddEmployee(Employee emp)
        {
            db.Employees.Add(emp);
            db.SaveChanges();
            return emp.ID;
        }




        public void UpdateEmployee(int id, Employee emp)
        {
            var currentEmployee = db.Employees.Where(x => x.ID == id).First();
            currentEmployee.First_Name = emp.First_Name;
            currentEmployee.Last_Name = emp.Last_Name;
            currentEmployee.Start_Work_Year = emp.Start_Work_Year;
            currentEmployee.DepartmentID = emp.DepartmentID;
            db.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var currentEmployee = db.Employees.Where(x => x.ID == id).First();
            db.Employees.Remove(currentEmployee);
            db.SaveChanges();
        }



    }
}