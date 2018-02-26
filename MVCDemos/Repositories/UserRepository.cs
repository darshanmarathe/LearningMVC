using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCDemos.Models;

namespace MVCDemos.Repositories
{
    public class UserRepository : IUserRepository
    {

        private static  List<User> users = new List<User>();

        public UserRepository()
        {
            users.Add(new User { UserName = "darshan", FirstName = "darshan", LastName = "marathe", IsActive = true });
            users.Add(new User { UserName = "yogesh", FirstName = "yogesh", LastName = "marathe", IsActive = true });
            users.Add(new User { UserName = "avadhoot", FirstName = "avadhoot", LastName = "marathe", IsActive = true });
            users.Add(new User { UserName = "namrata", FirstName = "namrata", LastName = "marathe", IsActive = true });

        }
        public bool ChangePassword(string username, string oldpassword, string newpassword)
        {
            throw new NotImplementedException();
        }

        public bool Delete_user(string username)
        {
            throw new NotImplementedException();
        }

        public List<User> Get_All_Users()
        {
            return users;
        }

        public User Get_User(string username)
        {
            return users.Where(x => x.UserName == username).FirstOrDefault();
        }

        public bool Resend_Email(string username)
        {
            throw new NotImplementedException();
        }

        public bool Save_User(User u)
        {
            users.Add(u);
            return true;
        }

        public bool Update_user(User u)
        {
            var ou = this.Get_User(u.UserName);
            ou.FirstName = u.FirstName;
            ou.LastName = u.LastName;
            return true;
        }
    }
}