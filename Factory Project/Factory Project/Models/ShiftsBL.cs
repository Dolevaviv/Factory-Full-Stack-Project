using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory_Project.Models
{
    public class ExtendedShift1BL
    {
        FactoryDBEntities1 db = new FactoryDBEntities1();

        public List<ExtendedShift> GetAllShifts()
        {
            List<ExtendedShift> lst = new List<ExtendedShift>();

            foreach (var esh1 in db.EmployeeShifts)
            {
                ExtendedShift extendedShift = new ExtendedShift();
                extendedShift.ID = esh1.ID;

                extendedShift.shifts = new List<shift1>();

                extendedShift.employees = new List<Employee>();
                foreach (var sh1 in db.shift1.Where(x => x.ID == esh1.ShiftID))
                {
                    extendedShift.Date = sh1.Date;
                    extendedShift.Start_Time = sh1.Start_Time;
                    extendedShift.End_Time = sh1.End_Time;
                    foreach (var emp in db.Employees.Where(x => x.ID == esh1.EmployeeID))
                    {
                        extendedShift.shifts.Add(sh1);
                        extendedShift.employees.Add(emp);
                    }

                }
                lst.Add(extendedShift);
            }

            return lst;
        }

        public List<ExtendedShift> GetShift(int id)
        {
            List<ExtendedShift> lst = new List<ExtendedShift>();

            foreach (var esh1 in db.EmployeeShifts.Where(x => x.ShiftID == id))
            {
                ExtendedShift extendedShift = new ExtendedShift();
                extendedShift.ID = esh1.ID;
                extendedShift.shifts = new List<shift1>();
                extendedShift.employees = new List<Employee>();
                foreach (var sh1 in db.shift1.Where(x => x.ID == esh1.ShiftID))
                {
                    foreach (var emp in db.Employees.Where(x => x.ID == esh1.EmployeeID))
                    {
                        extendedShift.shifts.Add(sh1);
                        extendedShift.employees.Add(emp);
                    }

                }
                lst.Add(extendedShift);
            }

            return lst;
        }

        public int addShift(shift1 shift)
        {
            db.shift1.Add(shift);
            db.SaveChanges();
            return shift.ID;
        }
    }
}