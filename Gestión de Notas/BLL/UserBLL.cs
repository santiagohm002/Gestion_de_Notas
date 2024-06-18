using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBLL
    {
        private readonly UserDAL userDAL;

        public UserBLL(string connectionString)
        {
            userDAL = new UserDAL(connectionString);
        }

        public bool ValidateUserLogin(string username, string password)
        {
            return userDAL.ValidateUserLogin(username, password) != -1;
        }

        public string GetUserType(string username)
        {
            return userDAL.GetUserType(username);
        }

        public bool ValidatePassword(string username, string password)
        {
            return userDAL.ValidatePassword(username, password);
        }
    }
}