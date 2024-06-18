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

        public void AddTeacher(Teacher teacher)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Docentes (NombreCompleto, Identificacion, Direccion, TelefonoContacto, CorreoElectronico, Especialidad) 
                         VALUES (@NombreCompleto, @Identificacion, @Direccion, @TelefonoContacto, @CorreoElectronico, @Especialidad)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreCompleto", teacher.NombreCompleto);
                command.Parameters.AddWithValue("@Identificacion", teacher.Identificacion);
                command.Parameters.AddWithValue("@Direccion", teacher.Direccion);
                command.Parameters.AddWithValue("@TelefonoContacto", teacher.TelefonoContacto);
                command.Parameters.AddWithValue("@CorreoElectronico", teacher.CorreoElectronico);
                command.Parameters.AddWithValue("@Especialidad", teacher.Especialidad);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateTeacher(Teacher teacher)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Docentes SET NombreCompleto = @NombreCompleto, " +
                               "Direccion = @Direccion, TelefonoContacto = @TelefonoContacto, CorreoElectronico = @CorreoElectronico, Especialidad = @Especialidad " +
                               "WHERE Identificacion = @Identificacion";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreCompleto", teacher.NombreCompleto);
                command.Parameters.AddWithValue("@Direccion", teacher.Direccion);
                command.Parameters.AddWithValue("@TelefonoContacto", teacher.TelefonoContacto);
                command.Parameters.AddWithValue("@CorreoElectronico", teacher.CorreoElectronico);
                command.Parameters.AddWithValue("@Especialidad", teacher.Especialidad);
                command.Parameters.AddWithValue("@Identificacion", teacher.Identificacion);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteTeacher(string identificacion)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Docentes WHERE Identificacion = @Identificacion";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Identificacion", identificacion);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Teacher GetTeacherById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Docentes WHERE ID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Teacher
                            {
                                ID = (int)reader["ID"],
                                NombreCompleto = (string)reader["NombreCompleto"],
                                Especialidad = (string)reader["Especialidad"],
                                Identificacion = (string)reader["Identificacion"]
                            };
                        }
                    }
                }
            }
            return null;
        }

        public Teacher GetTeacherByName(string nombreCompleto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT ID, NombreCompleto, Identificacion, Direccion, TelefonoContacto, CorreoElectronico, Especialidad FROM Docentes WHERE NombreCompleto = @NombreCompleto", conn))
                {
                    cmd.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Teacher
                        {
                            ID = reader.GetInt32(0),
                            NombreCompleto = reader.GetString(1),
                            Identificacion = reader.GetString(2),
                            Direccion = reader.GetString(3),
                            TelefonoContacto = reader.GetString(4),
                            CorreoElectronico = reader.GetString(5),
                            Especialidad = reader.GetString(6)
                        };
                    }
                }
            }

            return null;
        }

        public List<Teacher> GetAllTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, NombreCompleto, Identificacion, Direccion, TelefonoContacto, CorreoElectronico, Especialidad FROM Docentes";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Teacher teacher = new Teacher
                    {
                        ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        NombreCompleto = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        Identificacion = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Direccion = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        TelefonoContacto = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        CorreoElectronico = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        Especialidad = reader.IsDBNull(6) ? string.Empty : reader.GetString(6)
                    };

                    teachers.Add(teacher);
                }
            }

            return teachers;
        }

        public List<Teacher> GetBasicInfoTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, NombreCompleto, Identificacion, Especialidad FROM Docentes";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Teacher teacher = new Teacher
                    {
                        ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        NombreCompleto = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        Identificacion = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        Especialidad = reader.IsDBNull(3) ? string.Empty : reader.GetString(3)
                    };

                    teachers.Add(teacher);
                }
            }

            return teachers;
        }

        public List<Teacher> GetTeachersBySpecialty(string specialty)
        {
            List<Teacher> teachers = new List<Teacher>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query ="SELECT ID, NombreCompleto, Identificacion, Especialidad FROM Docentes WHERE Especialidad = @Specialty";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Specialty", specialty);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            teachers.Add(new Teacher
                            {
                                ID = (int)reader["ID"],
                                NombreCompleto = (string)reader["NombreCompleto"],
                                Especialidad = (string)reader["Especialidad"],
                                Identificacion = (string)reader["Identificacion"]
                            });
                        }
                    }
                }
            }
            return teachers;
        }

        public bool IsIdentificationDuplicate(string identification)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Docentes WHERE Identificacion = @Identificacion";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Identificacion", identification);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                // Si el conteo es mayor que 0, significa que hay al menos un docente con la misma identificación
                return count > 0;
            }
        }
    }
}