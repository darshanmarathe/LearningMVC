using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using MVCDemos.Models;

namespace MVCDemos.Repositories
{
    interface IUserRepository
    {
        List<User> Get_All_Users();

        User Get_User(string username);

        bool Save_User(User u);

        bool Update_user(User u);

        bool Delete_user(string username);

        bool Resend_Email(string username);

        bool ChangePassword(string username, string oldpassword, string newpassword);
       
    }

   
}
