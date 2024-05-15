using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class UserBLL
    {
        private string connectionString;

        public UserBLL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int ValidateUserLogin(string username, string password)
        {
            UserDAL userDAL = new UserDAL(connectionString);
            return userDAL.ValidateUserLogin(username, password);
        }
    }
}
