using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory_Project.Models
{
    public class LogInBL
    {
        FactoryDBEntities1 db = new FactoryDBEntities1();

        public List<user> GetAllUsers()
        {
            return db.users.ToList();
        }

        public user GetUserByUserName(string username)
        {
            return db.users.Where(n=>n.User_Name==username).First();
        }
        public user VerifyUser(user u)
        {
            var res = db.users.Where(x => x.User_Name == u.User_Name && x.Password == u.Password);
            if (res.Count() == 1)
            {
                DateTime LDate = DateTime.Now;
                var userlog = db.user_actions.Where(x => x.user_id == res.FirstOrDefault().ID);
                if (userlog.Count() == 1)
                {
                    if (userlog.FirstOrDefault().enterDate.ToShortDateString() != LDate.ToShortDateString())
                    {
                        userlog.FirstOrDefault().enterDate = LDate;
                        userlog.FirstOrDefault().actions = 0;
                        db.SaveChanges();
                    }
                }
                else
                {
                    user_actions newuserlog = new user_actions();
                    newuserlog.user_id = res.FirstOrDefault().ID;
                    newuserlog.enterDate = LDate;
                    db.user_actions.Add(newuserlog);
                    db.SaveChanges();
                }
                return res.First();
            }
            else
            {
                return null;
            }
        }

        public void AddAction(int userID, user_actions user)
        {
            var currentUserLog = db.user_actions.Where(x => x.user_id == userID).First();
            var currentUser = db.users.Where(x => x.ID == userID).First();
            currentUserLog.actions++;
            db.SaveChanges();

        }

        public bool checkALogs(int userID)
        {
            var currentUserLog = db.user_actions.Where(x => x.user_id == userID).First();
            var currentUser = db.users.Where(y => y.ID == userID).First();
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