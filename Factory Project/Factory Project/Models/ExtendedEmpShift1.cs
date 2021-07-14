using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory_Project.Models
{
    public class ExtendedEmpShift1
    {

        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public int ShiftID { get; set; }

        public System.DateTime Date { get; set; }
        public int Start_Time { get; set; }
        public int End_Time { get; set; }

        public string First_Name { get; set; }
        public string Last_Name { get; set; }

        public int Start_Work_Year { get; set; }
        public int DepartmentID { get; set; }
    }
}