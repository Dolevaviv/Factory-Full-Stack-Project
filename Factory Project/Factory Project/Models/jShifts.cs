using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory_Project.Models
{
    public class jShifts
    {
        FactoryDBEntities1 db = new FactoryDBEntities1();

        public List<shift1> GetAllShifts()
        {
            var lst = db.shift1.OrderBy(x => x.Date).ToList();
            return lst;
        }

        public int AddJustShift(shift1 sh)
        {
            db.shift1.Add(sh);
            db.SaveChanges();
            return sh.ID;
        }
    }

}