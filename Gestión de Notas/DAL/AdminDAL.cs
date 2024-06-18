using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdminDAL
    {
        private readonly string connectionString;

        public AdminDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool IsIdentificationDuplicate(string identification)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Administradores WHERE Identificacion = @Identificacion";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Identificacion", identification);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                // Si el conteo es mayor que 0, significa que hay al menos un docente con la misma identificación
                return count > 0;
            }
        }

        public void AddAdmin(Admin admin)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Administradores (NombreCompleto, Identificacion, Direccion, TelefonoContacto, CorreoElectronico, Cargo) 
                         VALUES (@NombreCompleto, @Identificacion, @Direccion, @TelefonoContacto, @CorreoElectronico, @Cargo)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreCompleto", admin.NombreCompleto);
                command.Parameters.AddWithValue("@Identificacion", admin.Identificacion);
                command.Parameters.AddWithValue("@Direccion", admin.Direccion);
                command.Parameters.AddWithValue("@TelefonoContacto", admin.TelefonoContacto);
                command.Parameters.AddWithValue("@CorreoElectronico", admin.CorreoElectronico);
                command.Parameters.AddWithValue("@Cargo", admin.Cargo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void UpdateAdmin(Admin admin)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Administradores SET NombreCompleto = @NombreCompleto, " +
                               "Direccion = @Direccion, TelefonoContacto = @TelefonoContacto, CorreoElectronico = @CorreoElectronico, Cargo = @Cargo " +
                               "WHERE Identificacion = @Identificacion";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreCompleto", admin.NombreCompleto);
                command.Parameters.AddWithValue("@Identificacion", admin.Identificacion);
                command.Parameters.AddWithValue("@Direccion", admin.Direccion);
                command.Parameters.AddWithValue("@TelefonoContacto", admin.TelefonoContacto);
                command.Parameters.AddWithValue("@CorreoElectronico", admin.CorreoElectronico);
                command.Parameters.AddWithValue("@Cargo", admin.Cargo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteAdmin(string identificacion)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Administradores WHERE Identificacion = @Identificacion";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Identificacion", identificacion);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Admin> GetAllAdmins()
        {
            List<Admin> admins = new List<Admin>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, NombreCompleto, Identificacion, Direccion, TelefonoContacto, CorreoElectronico, Cargo FROM Administradores";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Admin admin = new Admin
                    {
                        ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        NombreCompleto = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        Identificacion = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Direccion = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        TelefonoContacto = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        CorreoElectronico = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        Cargo = reader.IsDBNull(6) ? string.Empty : reader.GetString(6)
                    };

                    admins.Add(admin);
                }
            }

            return admins;
        }
    }
}
