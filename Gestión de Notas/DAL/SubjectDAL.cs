using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SubjectDAL
    {
        private readonly string connectionString;

        public SubjectDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Subject> GetAllSubjectsWithDetails()
        {
            List<Subject> subjects = new List<Subject>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT m.ID, m.NombreMateria, d.NombreCompleto AS DocenteEncargado, s.NombreSalon AS SalonAsignado
                    FROM Materias m
                    INNER JOIN Docentes d ON m.DocenteEncargadoID = d.ID
                    INNER JOIN Salones s ON m.SalonAsignadoID = s.ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    subjects.Add(new Subject
                    {
                        ID = (int)reader["ID"],
                        NombreMateria = (string)reader["NombreMateria"],
                        DocenteEncargado = (string)reader["DocenteEncargado"],
                        SalonAsignado = (string)reader["SalonAsignado"]
                    });
                }
            }

            return subjects;
        }

        public void AddSubject(Subject subject)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Materias (NombreMateria, DocenteEncargadoID, SalonAsignadoID) VALUES (@NombreMateria, @DocenteEncargadoID, @SalonAsignadoID)", conn);
                cmd.Parameters.AddWithValue("@NombreMateria", subject.NombreMateria);
                cmd.Parameters.AddWithValue("@DocenteEncargadoID", subject.DocenteEncargadoID);
                cmd.Parameters.AddWithValue("@SalonAsignadoID", subject.SalonAsignadoID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateSubject(Subject subject)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Materias SET NombreMateria = @NombreMateria, DocenteEncargadoID = @DocenteEncargadoID, SalonAsignadoID = @SalonAsignadoID WHERE ID = @ID", conn);
                cmd.Parameters.AddWithValue("@NombreMateria", subject.NombreMateria);
                cmd.Parameters.AddWithValue("@DocenteEncargadoID", subject.DocenteEncargadoID);
                cmd.Parameters.AddWithValue("@SalonAsignadoID", subject.SalonAsignadoID);
                cmd.Parameters.AddWithValue("@ID", subject.ID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteSubject(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Materias WHERE ID = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Subject GetSubjectByName(string subjectName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Materias WHERE NombreMateria = @NombreMateria", conn);
                cmd.Parameters.AddWithValue("@NombreMateria", subjectName);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Subject
                    {
                        ID = (int)reader["ID"],
                        NombreMateria = (string)reader["NombreMateria"],
                        DocenteEncargadoID = (int)reader["DocenteEncargadoID"],
                        SalonAsignadoID = (int)reader["SalonAsignadoID"]
                    };
                }
            }
            return null;
        }

        public bool IsDuplicateAssignment(string nombreMateria, int docenteEncargadoID, int salonAsignadoID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT COUNT(*)
                    FROM Materias
                    WHERE NombreMateria = @NombreMateria
                    AND DocenteEncargadoID = @DocenteEncargadoID
                    AND SalonAsignadoID = @SalonAsignadoID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NombreMateria", nombreMateria);
                    command.Parameters.AddWithValue("@DocenteEncargadoID", docenteEncargadoID);
                    command.Parameters.AddWithValue("@SalonAsignadoID", salonAsignadoID);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}