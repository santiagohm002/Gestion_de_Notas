using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AssignmentDAL
    {
        private readonly string connectionString;

        public AssignmentDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Teacher> GetAllTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Docentes";
                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Teacher teacher = new Teacher
                            {
                                DocenteID = reader["DocenteID"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                            };
                            teachers.Add(teacher);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener todos los profesores: " + ex.Message);
                }
            }

            return teachers;
        }

        public List<Subject> GetAllSubjects()
        {
            List<Subject> subjects = new List<Subject>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Materia";
                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Subject subject = new Subject
                            {
                                MateriaID = Convert.ToInt32(reader["MateriaID"]),
                                Nombre = reader["Nombre"].ToString(),
                            };
                            subjects.Add(subject);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener todas las materias: " + ex.Message);
                }
            }

            return subjects;
        }

        public List<Grade> GetAllGrades()
        {
            List<Grade> grades = new List<Grade>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Grado";
                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Grade grade = new Grade
                            {
                                GradoID = Convert.ToInt32(reader["GradoID"]),
                                Numero = Convert.ToInt32(reader["Numero"]),
                            };
                            grades.Add(grade);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener todos los grados: " + ex.Message);
                }
            }

            return grades;
        }

        public Assignment GetAssignmentById(int assignmentId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Asignaciones WHERE AsigID = @AsigID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@AsigID", assignmentId);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        Assignment assignment = new Assignment
                        {
                            AsigID = Convert.ToInt32(reader["AsigID"]),
                            MateriaID = Convert.ToInt32(reader["MateriaID"]),
                            ProfesorID = Convert.ToInt32(reader["ProfesorID"]),
                            GradoID = Convert.ToInt32(reader["GradoID"]),
                        };

                        return assignment;
                    }
                    else
                    {
                        throw new Exception("No se encontró ninguna asignación con el ID proporcionado.");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener la asignación por ID: " + ex.Message);
                }
            }
        }
        public List<Assignment> GetAllAssignments()
        {
            List<Assignment> assignments = new List<Assignment>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Asignaciones";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Assignment assignment = new Assignment
                        {
                            AsigID = Convert.ToInt32(reader["AsigID"]),
                            MateriaID = Convert.ToInt32(reader["MateriaID"]),
                            ProfesorID = Convert.ToInt32(reader["ProfesorID"]),
                            GradoID = Convert.ToInt32(reader["GradoID"]),
                        };

                        assignments.Add(assignment);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener todas las asignaciones: " + ex.Message);
                }
            }

            return assignments;
        }

        public string GetTeacherNameById(int teacherId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Nombre FROM Docentes WHERE DocenteID = @TeacherId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TeacherId", teacherId);

                    return (string)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el nombre del docente por ID: " + ex.Message);
                }
            }
        }

        public int GetGradeValueById(int gradeId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Numero FROM Grado WHERE GradoID = @GradeId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@GradeId", gradeId);

                    return (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el nombre del docente por ID: " + ex.Message);
                }
            }
        }

        public string GetSubjectNameById(int subjectId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Nombre FROM Materia WHERE MateriaID = @SubjectId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SubjectId", subjectId);

                    return (string)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el nombre del docente por ID: " + ex.Message);
                }
            }
        }

        public void AssignSubjectToTeacher(int subjectId, int teacherId, int gradeId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string queryCheck = "SELECT COUNT(*) FROM Asignaciones WHERE ProfesorID = @TeacherID AND MateriaID = @SubjectID AND GradoID = @GradeID";
                    SqlCommand commandCheck = new SqlCommand(queryCheck, connection);
                    commandCheck.Parameters.AddWithValue("@TeacherID", teacherId);
                    commandCheck.Parameters.AddWithValue("@SubjectID", subjectId);
                    commandCheck.Parameters.AddWithValue("@GradeID", gradeId);

                    int existingAssignments = (int)commandCheck.ExecuteScalar();
                    if (existingAssignments > 0)
                    {
                        throw new Exception("Ya existe una asignación para este docente, materia y grado.");
                    }

                    string query = "INSERT INTO Asignaciones (ProfesorID, MateriaID, GradoID) VALUES (@ProfesorID, @MateriaID, @GradoID)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MateriaID", subjectId);
                    command.Parameters.AddWithValue("@ProfesorID", teacherId);
                    command.Parameters.AddWithValue("@GradoID", gradeId);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al asignar materia a docente: " + ex.Message);
                }
            }
        }

        public DataTable GetAssignmentsByGrade(int gradeId)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Asignaciones WHERE GradoID = @GradoID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@GradoID", gradeId);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener las asignaciones por grado: " + ex.Message);
                }
            }

            return dt;
        }

        public void DeleteAssignment(int assignmentId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM Asignaciones WHERE AsigID = @AsigID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@AsigID", assignmentId);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar la asignación: " + ex.Message);
                }
            }
        }
    }
}