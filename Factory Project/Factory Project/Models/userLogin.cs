using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory_Project.Models
{
    public class userLogin
    {
        public int user_id { get; set; }
        public string fullName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public int num_of_actions { get; set; }
        public System.DateTime enterDate { get; set; }
    }
}