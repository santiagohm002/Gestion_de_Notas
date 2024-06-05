using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDAL
    {
        private readonly string connectionString;

        public UserDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int ValidateUserLogin(string username, string password)
        {
            int userId = -1;
            string query = "SELECT UsuarioID FROM Usuarios WHERE NombreUsuario = @Username AND Contraseña = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        userId = Convert.ToInt32(result);
                    }
                }
            }

            return userId;
        }

        public string GetUserType(string username)
        {
            string userType = null;
            string query = "SELECT TipoUsuario FROM Usuarios WHERE NombreUsuario = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        userType = result.ToString();
                    }
                }
            }

            return userType;
        }

        public bool ValidatePassword(string username, string password)
        {
            string storedPassword = null;
            string query = "SELECT Contraseña FROM Usuarios WHERE NombreUsuario = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();
                    storedPassword = (string)command.ExecuteScalar();
                }
            }

            return storedPassword != null && storedPassword == password;
        }
    }
}