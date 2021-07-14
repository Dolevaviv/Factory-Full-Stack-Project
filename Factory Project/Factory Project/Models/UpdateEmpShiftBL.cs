using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory_Project.Models
{
    public class UpdateEmpShiftBL
    {
        FactoryDBEntities1 db = new FactoryDBEntities1();

        public List<UpdatingEmpShift> GetEmpAndShifts()
        {
            List<UpdatingEmpShift> list2 = new List<UpdatingEmpShift>();
            foreach (var empSh in db.EmployeeShifts)
            {
                UpdatingEmpShift updatingEmpShift = new UpdatingEmpShift();
                updatingEmpShift.EmployeeID = empSh.EmployeeID;
                updatingEmpShift.ShiftID = empSh.ShiftID;

                foreach (var emp in db.Employees.Where(X => X.ID == updatingEmpShift.EmployeeID))
                {
                    updatingEmpShift.First_Name = emp.First_Name;
                    updatingEmpShift.Last_Name = emp.Last_Name;

                }
                list2.Add(updatingEmpShift);
            }

            return list2;
        }



        public void AddEmployeeToNewShift(EmployeeShift empS)
        {
            db.EmployeeShifts.Add(empS);
            db.SaveChanges();


        }
    }
}