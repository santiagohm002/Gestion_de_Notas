using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TeacherDAL
    {
        private readonly string connectionString;
        public TeacherDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<Teacher> ObtenerTodosLosDocentes()
        {
            List<Teacher> docentes = new List<Teacher>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Docentes";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Teacher docente = new Teacher();
                    docente.Identificacion = reader["Identificacion"].ToString();
                    docente.Nombre = reader["Nombre"].ToString();
                    docente.Apellido = reader["Apellido"].ToString();
                    docente.Especialidad = reader["Especialidad"].ToString();
                    docentes.Add(docente);
                }
            }

            return docentes;
        }
        public List<Teacher> ObtenerDocentesPorEspecialidad(string Especialidad)
        {
            List<Teacher> docentes = new List<Teacher>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Docentes WHERE Especialidad = @Especialidad";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Especialidad", Especialidad);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Teacher docente = new Teacher();
                    docente.Identificacion = reader["Identificacion"].ToString();
                    docente.Nombre = reader["Nombre"].ToString();
                    docente.Apellido = reader["Apellido"].ToString();
                    docente.Especialidad = reader["Especialidad"].ToString();
                    docentes.Add(docente);
                }
            }

            return docentes;
        }

        public void CrearDocente(Teacher docente)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Docentes (Identificacion, Nombre, Apellido, Especialidad) " +
                               "VALUES (@Identificacion, @Nombre, @Apellido, @Especialidad); " +
                               "DECLARE @Usuario NVARCHAR(100); " +
                               "SET @Usuario = CONCAT(@Nombre, '.', @Apellido); " +
                               "INSERT INTO Usuarios (NombreUsuario, Contraseña, TipoUsuario) " +
                               "VALUES (@Usuario, @Identificacion, 'Docente')";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Identificacion", docente.Identificacion);
                command.Parameters.AddWithValue("@Nombre", docente.Nombre);
                command.Parameters.AddWithValue("@Apellido", docente.Apellido);
                command.Parameters.AddWithValue("@Especialidad", docente.Especialidad);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void EditarDocente(Teacher docente)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Estudiantes SET Nombre = @Nombre," +
                               "Apellido = @Apellido, Especialidad = @Especialidad " +
                               "WHERE Identificacion = @Identificacion";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Identificacion", docente.Identificacion);
                command.Parameters.AddWithValue("@Nombre", docente.Nombre);
                command.Parameters.AddWithValue("@Apellido", docente.Apellido);
                command.Parameters.AddWithValue("@Especialidad", docente.Especialidad);

                connection.Open();
                command.ExecuteNonQuery();

                string updateUsuarioQuery = "UPDATE Usuarios SET NombreUsuario = @NombreUsuario WHERE TipoUsuario = 'Docente' AND NombreUsuario = (SELECT Nombre + '.' + Apellido FROM Estudiantes WHERE Identificacion = @Identificacion)";
                SqlCommand updateUsuarioCommand = new SqlCommand(updateUsuarioQuery, connection);
                updateUsuarioCommand.Parameters.AddWithValue("@NombreUsuario", docente.Nombre + "." + docente.Apellido);
                updateUsuarioCommand.Parameters.AddWithValue("@Identificacion", docente.Identificacion);
                updateUsuarioCommand.ExecuteNonQuery();
            }
        }
        public void EliminarDocente(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string deleteDocenteQuery = "DELETE FROM Docentes WHERE Identificacion = @Identificacion";
                    SqlCommand deleteDocenteCommand = new SqlCommand(deleteDocenteQuery, connection, transaction);
                    deleteDocenteCommand.Parameters.AddWithValue("@Identificacion", id);
                    deleteDocenteCommand.ExecuteNonQuery();

                    string deleteUsuarioQuery = "DELETE FROM Usuarios WHERE TipoUsuario = 'Docente' AND NombreUsuario = (SELECT Nombre + '.' + Apellido FROM Estudiantes WHERE Identificacion = @Identificacion)";
                    SqlCommand deleteUsuarioCommand = new SqlCommand(deleteUsuarioQuery, connection, transaction);
                    deleteUsuarioCommand.Parameters.AddWithValue("@Identificacion", id);
                    deleteUsuarioCommand.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al eliminar el estudiante y su usuario asociado", ex);
                }
            }
        }
    }
}
