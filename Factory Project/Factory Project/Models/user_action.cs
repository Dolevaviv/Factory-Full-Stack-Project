using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory_Project.Models
{
    public partial class user_action
    {
        public int ID { get; set; }
        public int user_id { get; set; }
        public int actions { get; set; }
        public System.DateTime enterDate { get; set; }
    }
}
