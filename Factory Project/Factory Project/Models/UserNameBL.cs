using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory_Project.Models
{
    public class UserNameBL
    {
        FactoryDBEntities1 db = new FactoryDBEntities1();
        public List<user> GetAllData()
        {
            List<user> li = new List<user>();
            foreach (var u in db.users)
            {
                user us = new user();
                us.ID = u.ID;
                us.Full_Name = u.Full_Name;
                us.User_Name = u.User_Name;
                us.Password = u.Password;
                us.Num_Of_Actions = u.Num_Of_Actions;
                li.Add(us);
            }
            return li;
        }

        public user GetByUserName(string username)
        {
            user user = new user();
            foreach (var item in db.users)
            {
                if (item.User_Name == username)
                {
                    user = item;
                }

            }
            return user;
        }

        public user GetByID(int id)
        {
            user usr = new user();
            foreach (var item in db.users)
            {
                if (item.ID == id)
                {
                    usr = item;
                }

            }
            return usr;
        }
    }
}