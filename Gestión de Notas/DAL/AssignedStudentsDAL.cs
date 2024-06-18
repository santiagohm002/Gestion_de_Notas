using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class AssignedStudentDAL
    {
        private readonly string connectionString;

        public AssignedStudentDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<AssignedStudent> GetAllAssignedStudents()
        {
            List<AssignedStudent> assignedStudents = new List<AssignedStudent>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT es.ID, e.NombreCompleto as NombreEstudiante, s.NombreSalon as SalonAsignado " +
                                                       "FROM EstudiantesSalon es " +
                                                       "JOIN Estudiantes e ON es.EstudianteID = e.ID " +
                                                       "JOIN Salones s ON es.SalonID = s.ID", conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        assignedStudents.Add(new AssignedStudent
                        {
                            ID = reader.GetInt32(0),
                            NombreEstudiante = reader.GetString(1),
                            SalonAsignado = reader.GetString(2)
                        });
                    }
                }
            }

            return assignedStudents;
        }

        public AssignedStudent GetAssignedStudentByStudentID(int estudianteID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT es.ID, e.NombreCompleto as NombreEstudiante, s.NombreSalon as SalonAsignado " +
                                                       "FROM EstudiantesSalon es " +
                                                       "JOIN Estudiantes e ON es.EstudianteID = e.ID " +
                                                       "JOIN Salones s ON es.SalonID = s.ID " +
                                                       "WHERE es.EstudianteID = @EstudianteID", conn))
                {
                    cmd.Parameters.AddWithValue("@EstudianteID", estudianteID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new AssignedStudent
                        {
                            ID = reader.GetInt32(0),
                            NombreEstudiante = reader.GetString(1),
                            SalonAsignado = reader.GetString(2)
                        };
                    }
                }
            }

            return null;
        }

        public List<AssignedStudent> GetAssignedStudentsByRoomID(int salonID)
        {
            List<AssignedStudent> assignedStudents = new List<AssignedStudent>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT es.ID, e.NombreCompleto as NombreEstudiante, s.NombreSalon as SalonAsignado " +
                                                       "FROM EstudiantesSalon es " +
                                                       "JOIN Estudiantes e ON es.EstudianteID = e.ID " +
                                                       "JOIN Salones s ON es.SalonID = s.ID " +
                                                       "WHERE es.SalonID = @SalonID", conn))
                {
                    cmd.Parameters.AddWithValue("@SalonID", salonID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        assignedStudents.Add(new AssignedStudent
                        {
                            ID = reader.GetInt32(0),
                            NombreEstudiante = reader.GetString(1),
                            SalonAsignado = reader.GetString(2)
                        });
                    }
                }
            }

            return assignedStudents;
        }

        public void AddAssignedStudent(int estudianteID, int salonID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO EstudiantesSalon (EstudianteID, SalonID) VALUES (@EstudianteID, @SalonID)", conn))
                {
                    cmd.Parameters.AddWithValue("@EstudianteID", estudianteID);
                    cmd.Parameters.AddWithValue("@SalonID", salonID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteAssignedStudent(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM EstudiantesSalon WHERE ID = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateAssignedStudent(int id, int newSalonID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE EstudiantesSalon SET SalonID = @SalonID WHERE ID = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@SalonID", newSalonID);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}