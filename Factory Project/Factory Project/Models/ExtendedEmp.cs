using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory_Project.Models
{
    public class ExtendedEmp
    {
        public int ID { get; set; }

        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Start_Work_Year { get; set; }
        public int DepartmentID { get; set; }
        public List<shift1> shifts { get; set; }

    }
}