using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory_Project.Models
{
    public class ExtendedEmpShift1BL
    {
        FactoryDBEntities1 db = new FactoryDBEntities1();
        public List<ExtendedEmpShift1> GetAllEmployeeAndShifts()
        {

            List<ExtendedEmpShift1> lst = new List<ExtendedEmpShift1>();

            foreach (var shift in db.EmployeeShifts)
            {
                ExtendedEmpShift1 extendedEmpShift1 = new ExtendedEmpShift1();
                extendedEmpShift1.ID = shift.ID;
                extendedEmpShift1.ShiftID = shift.ShiftID;
                extendedEmpShift1.EmployeeID = shift.EmployeeID;


                foreach (var emp in db.Employees.Where(x => x.ID == extendedEmpShift1.EmployeeID))
                {

                    extendedEmpShift1.First_Name = emp.First_Name;
                    extendedEmpShift1.Last_Name = emp.Last_Name;



                }
                lst.Add(extendedEmpShift1);
            }

            return lst;

        }


        public List<ExtendedEmpShift1> GetOneEmpShift(int id)
        {

            List<ExtendedEmpShift1> lst = new List<ExtendedEmpShift1>();

            foreach (var shift in db.EmployeeShifts.Where(x => x.ID == id))
            {
                ExtendedEmpShift1 extendedEmpShift1 = new ExtendedEmpShift1();
                extendedEmpShift1.ID = shift.ID;
                extendedEmpShift1.ShiftID = shift.ShiftID;
                extendedEmpShift1.EmployeeID = shift.EmployeeID;


                foreach (var emp in db.Employees.Where(x => x.ID == extendedEmpShift1.EmployeeID))
                {

                    extendedEmpShift1.First_Name = emp.First_Name;
                    extendedEmpShift1.Last_Name = emp.Last_Name;



                }
                lst.Add(extendedEmpShift1);
            }

            return lst;

        }

        public void AddEmpShift(ExtendedEmpShift1 empshift)
        {
            Employee emp = new Employee();
            emp.First_Name = empshift.First_Name;
            emp.Last_Name = empshift.Last_Name;
            emp.Start_Work_Year = empshift.Start_Work_Year;
            emp.DepartmentID = empshift.DepartmentID;
            db.Employees.Add(emp);
            db.SaveChanges();

            shift1 shift = new shift1();
            shift.Date = empshift.Date;
            shift.Start_Time = empshift.Start_Time;
            shift.End_Time = empshift.End_Time;
            db.shift1.Add(shift);
            db.SaveChanges();

        }

        public void UpdateEmpShift(int id, EmployeeShift emp)
        {
            var currentEshift = db.EmployeeShifts.Where(x => x.ID == id).First();
            currentEshift.ShiftID = emp.ShiftID;
            currentEshift.EmployeeID = emp.EmployeeID;
            db.SaveChanges();

        }




    }
}