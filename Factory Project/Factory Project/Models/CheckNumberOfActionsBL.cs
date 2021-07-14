using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory_Project.Models
{
    public class CheckNumberOfActionsBL
    {
        FactoryDBEntities1 db = new FactoryDBEntities1();

        public bool CheckNumberOfActions(int userID)
        {
            var currentUserLog = db.user_actions.Where(x => x.user_id == userID).First();
            var currentUser = db.users.Where(x => x.ID == userID).First();
            if (currentUserLog.actions >= currentUser.Num_Of_Actions)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}