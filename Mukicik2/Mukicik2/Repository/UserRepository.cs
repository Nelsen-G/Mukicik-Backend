using Mukicik2.Factories;
using Mukicik2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mukicik2.Repository
{
    public class UserRepository
    {
        Database1Entities db = SingletonDB.GetInstance();
        
        public void registerUser(String name, String email, String password, String gender, DateTime dob, String profile)
        {
            User x = UserFactory.addUser(name, email, password, gender, dob, profile);
            db.Users.Add(x);
            db.SaveChanges();
        }

        public User checkUser(String email, String password)
        {
            return (from u in db.Users where email == u.UserEmail && password == u.UserPassword select u).FirstOrDefault();
        }
    }
}