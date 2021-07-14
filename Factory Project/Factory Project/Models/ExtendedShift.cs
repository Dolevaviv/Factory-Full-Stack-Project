using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory_Project.Models
{
    public class ExtendedShift
    {
        public int ID { get; set; }

        public System.DateTime Date { get; set; }
        public int Start_Time { get; set; }
        public int End_Time { get; set; }

        public List<shift1> shifts { get; set; }

        public List<Employee> employees { get; set; }
    }
}