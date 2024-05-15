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
        private string connectionString;

        public UserBLL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool ValidateUserLogin(string username, string password)
        {
            UserDAL userDAL = new UserDAL(connectionString);
            int userId = userDAL.ValidateUserLogin(username, password);

            return userId != -1;
        }

        public string GetUserType(string username)
        {
            UserDAL userDAL = new UserDAL(connectionString);
            return userDAL.GetUserType(username);
        }

        public bool ValidatePassword(string username, string password)
        {
            UserDAL userDAL = new UserDAL(connectionString);
            return userDAL.ValidatePassword(username, password);
        }
    }
}

