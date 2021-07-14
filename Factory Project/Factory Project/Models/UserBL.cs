using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory_Project.Models
{
    public class UserBL
    {
        FactoryDBEntities1 db = new FactoryDBEntities1();
        public List<user> getAllUsers()
        {
            List<user> lst = new List<user>();
            foreach (var us in db.users)
            {
                user newUser = new user();
                newUser.ID = us.ID;
                newUser.Full_Name = us.Full_Name;
                newUser.User_Name = us.User_Name;
                newUser.Password = us.Password;
                newUser.Num_Of_Actions = us.Num_Of_Actions;
                lst.Add(newUser);

            }
            return lst;
        }

        public user GetUserById(int userID)
        {
            user us = db.users.Where(x => x.ID == userID).First();
            user newUser = new user();
            newUser.ID = us.ID;
            newUser.Full_Name = us.Full_Name;
            newUser.User_Name = us.User_Name;
            newUser.Password = us.Password;
            newUser.Num_Of_Actions = us.Num_Of_Actions;

            return newUser;

        }

        public int AddUser(user us)
        {
            db.users.Add(us);
            db.SaveChanges();
            return us.ID;
        }

        public void UpdateUser(int id, user us)
        {
            var currentUser = db.users.Where(x => x.ID == id).First();
            currentUser.Full_Name = us.Full_Name;
            currentUser.User_Name = us.User_Name;
            currentUser.Password = us.Password;
            currentUser.Num_Of_Actions = us.Num_Of_Actions;
            db.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var currentUser = db.users.Where(x => x.ID == id).First();
            db.users.Remove(currentUser);
            db.SaveChanges();
        }
    }
}
    
