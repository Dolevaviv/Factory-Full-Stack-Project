 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory_Project.Models
{
    public class DepAndEmps
    {
        FactoryDBEntities1 db = new FactoryDBEntities1();
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Manager { get; set; }
        public string managerfName { get; set; }
        public string managerlName { get; set; }
    }
}