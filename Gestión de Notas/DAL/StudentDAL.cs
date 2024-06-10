using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace DAL
{
    public class StudentDAL
    {
        private readonly string connectionString;

        public StudentDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void AddStudent(Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Estudiantes (NombreCompleto, Identificacion, FechaNacimiento, Direccion, TelefonoContacto, CorreoElectronico) 
                         VALUES (@NombreCompleto, @Identificacion, @FechaNacimiento, @Direccion, @TelefonoContacto, @CorreoElectronico)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreCompleto", student.NombreCompleto);
                command.Parameters.AddWithValue("@Identificacion", student.Identificacion);
                command.Parameters.AddWithValue("@FechaNacimiento", student.FechaNacimiento);
                command.Parameters.AddWithValue("@Direccion", student.Direccion);
                command.Parameters.AddWithValue("@TelefonoContacto", student.TelefonoContacto);
                command.Parameters.AddWithValue("@CorreoElectronico", student.CorreoElectronico);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateStudent(Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Estudiantes SET NombreCompleto = @NombreCompleto, FechaNacimiento = @FechaNacimiento, " +
                               "Direccion = @Direccion, TelefonoContacto = @TelefonoContacto, CorreoElectronico = @CorreoElectronico " +
                               "WHERE Identificacion = @Identificacion";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreCompleto", student.NombreCompleto);
                command.Parameters.AddWithValue("@FechaNacimiento", student.FechaNacimiento);
                command.Parameters.AddWithValue("@Direccion", student.Direccion);
                command.Parameters.AddWithValue("@TelefonoContacto", student.TelefonoContacto);
                command.Parameters.AddWithValue("@CorreoElectronico", student.CorreoElectronico);
                command.Parameters.AddWithValue("@Identificacion", student.Identificacion);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteStudent(int identificacion)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Estudiantes WHERE Identificacion = @Identificacion";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Identificacion", identificacion);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Student GetStudentById(int studentId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Estudiantes WHERE EstudianteID = @EstudianteID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EstudianteID", studentId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new Student
                    {
                        ID = (int)reader["EstudianteID"],
                        NombreCompleto = (string)reader["NombreCompleto"],
                        Identificacion = (int)reader["Identificacion"],
                        FechaNacimiento = (DateTime)reader["FechaNacimiento"],
                        Direccion = (string)reader["Direccion"],
                        TelefonoContacto = (string)reader["TelefonoContacto"],
                        CorreoElectronico = (string)reader["CorreoElectronico"]
                    };
                }

                return null;
            }
        }
        public Student GetStudentByName(string nombreCompleto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT ID, NombreCompleto, Identificacion, Edad FROM Estudiantes WHERE NombreCompleto = @NombreCompleto", conn))
                {
                    cmd.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Student
                        {
                            ID = reader.GetInt32(0),
                            NombreCompleto = reader.GetString(1),
                            Identificacion = reader.GetInt32(2),
                            Edad = reader.GetInt32(3)
                        };
                    }
                }
            }

            return null;
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Estudiantes";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Student student = new Student
                    {
                        ID = (int)reader["ID"],
                        NombreCompleto = (string)reader["NombreCompleto"],
                        Identificacion = (int)reader["Identificacion"],
                        FechaNacimiento = (DateTime)reader["FechaNacimiento"],
                        Direccion = (string)reader["Direccion"],
                        TelefonoContacto = (string)reader["TelefonoContacto"],
                        CorreoElectronico = (string)reader["CorreoElectronico"]
                    };

                    students.Add(student);
                }
            }

            return students;
        }

        public List<Student> GetBasicStudentInfo()
        {
            List<Student> students = new List<Student>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT ID, NombreCompleto, Identificacion, Edad FROM Estudiantes", conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            ID = reader.GetInt32(0),
                            NombreCompleto = reader.GetString(1),
                            Identificacion = reader.GetInt32(2),
                            Edad = reader.GetInt32(3)
                        });
                    }
                }
            }

            return students;
        }

        public bool IsIdentificationDuplicate(int identification)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Estudiantes WHERE Identificacion = @Identificacion";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Identificacion", identification);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                // Si el conteo es mayor que 0, significa que hay al menos un estudiante con la misma identificación
                return count > 0;
            }
        }
    }
}