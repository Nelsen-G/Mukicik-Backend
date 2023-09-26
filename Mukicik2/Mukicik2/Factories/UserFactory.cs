using Mukicik2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mukicik2.Factories
{
    public class UserFactory
    {
        public static User addUser(String name, String email, String password, String gender, DateTime dob, String profile)
        {
            User newUser = new User();
            newUser.Username = name;
            newUser.UserEmail = email;
            newUser.UserPassword = password;
            newUser.UserGender = gender;
            newUser.UserDOB = dob;
            if (profile.Length == 0) newUser.UserProfilePicture = null;
            else newUser.UserProfilePicture = profile;
            return newUser;
        }
    }
}