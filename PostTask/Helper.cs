using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostTask
{
    class Helper
    {
        public static bool CkeckedUser(UserNamespace.User[] users,string email,string password)
        {
            foreach (var user in users)
            {
                if (email == user.Email && password == user.Password)
                {
                    return true;
                }
            }
            throw new Exception("Email or password incorrect!Please try again.");
        }
        public static bool CheckedAdmin(Admin.Admin[]admins,string username,string password)
        {
            foreach (var admin in admins)
            {
                if (username == admin.Username && password == admin.Password)
                {
                    return true;
                }
            }
            throw new Exception("Username or password incorrect!Please try again.");
        }
    }
}
