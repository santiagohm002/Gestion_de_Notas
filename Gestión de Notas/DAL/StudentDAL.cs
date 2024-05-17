using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class StudentDAL
    {
        private readonly string connectionString;

        public StudentDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<Student> ObtenerTodosLosEstudiantes()
        {
            List<Student> estudiantes = new List<Student>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Estudiantes";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Student estudiante = new Student();
                    estudiante.Identificacion = reader["Identificacion"].ToString();
                    estudiante.Nombre = reader["Nombre"].ToString();
                    estudiante.Apellido = reader["Apellido"].ToString();
                    estudiante.Grado = Convert.ToInt32(reader["Grado"]);
                    estudiantes.Add(estudiante);
                }
            }

            return estudiantes;
        }
        public List<Student> ObtenerEstudiantesPorGrado(int grado)
        {
            List<Student> estudiantes = new List<Student>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Estudiantes WHERE Grado = @Grado";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Grado", grado);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Student estudiante = new Student();
                    estudiante.Identificacion = reader["Identificacion"].ToString();
                    estudiante.Nombre = reader["Nombre"].ToString();
                    estudiante.Apellido = reader["Apellido"].ToString();
                    estudiante.Grado = Convert.ToInt32(reader["Grado"]);
                    estudiantes.Add(estudiante);
                }
            }

            return estudiantes;
        }

        public void CrearEstudiante(Student estudiante)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Estudiantes (Identificacion, Nombre, Apellido, Grado) " +
                               "VALUES (@Identificacion, @Nombre, @Apellido, @Grado); " +
                               "DECLARE @Usuario NVARCHAR(100); " +
                               "SET @Usuario = CONCAT(@Nombre, '.', @Apellido); " +
                               "INSERT INTO Usuarios (NombreUsuario, Contraseña, TipoUsuario) " +
                               "VALUES (@Usuario, @Identificacion, 'Estudiante')";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Identificacion", estudiante.Identificacion);
                command.Parameters.AddWithValue("@Nombre", estudiante.Nombre);
                command.Parameters.AddWithValue("@Apellido", estudiante.Apellido);
                command.Parameters.AddWithValue("@Grado", estudiante.Grado);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void EditarEstudiante(Student estudiante)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Estudiantes SET Nombre = @Nombre," +
                               "Apellido = @Apellido, Grado = @Grado " +
                               "WHERE Identificacion = @Identificacion";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Identificacion", estudiante.Identificacion);
                command.Parameters.AddWithValue("@Nombre", estudiante.Nombre);
                command.Parameters.AddWithValue("@Apellido", estudiante.Apellido);
                command.Parameters.AddWithValue("@Grado", estudiante.Grado);

                connection.Open();
                command.ExecuteNonQuery();

                string updateUsuarioQuery = "UPDATE Usuarios SET NombreUsuario = @NombreUsuario WHERE TipoUsuario = 'Estudiante' AND NombreUsuario = (SELECT Nombre + '.' + Apellido FROM Estudiantes WHERE Identificacion = @Identificacion)";
                SqlCommand updateUsuarioCommand = new SqlCommand(updateUsuarioQuery, connection);
                updateUsuarioCommand.Parameters.AddWithValue("@NombreUsuario", estudiante.Nombre + "." + estudiante.Apellido);
                updateUsuarioCommand.Parameters.AddWithValue("@Identificacion", estudiante.Identificacion);
                updateUsuarioCommand.ExecuteNonQuery();
            }
        }
        public void EliminarEstudiante(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string deleteEstudianteQuery = "DELETE FROM Estudiantes WHERE Identificacion = @Identificacion";
                    SqlCommand deleteEstudianteCommand = new SqlCommand(deleteEstudianteQuery, connection, transaction);
                    deleteEstudianteCommand.Parameters.AddWithValue("@Identificacion", id);
                    deleteEstudianteCommand.ExecuteNonQuery();

                    string deleteUsuarioQuery = "DELETE FROM Usuarios WHERE TipoUsuario = 'Estudiante' AND NombreUsuario = (SELECT Nombre + '.' + Apellido FROM Estudiantes WHERE Identificacion = @Identificacion)";
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