using System.Collections.Generic;
using System.Data.SqlClient;
using Entity;

namespace DAL
{
    public class GradeDAL
    {
        private readonly string connectionString;

        public GradeDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddGrade(Grade grade)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Grados (NombreGrado, NivelEducacional) VALUES (@NombreGrado, @NivelEducacional)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreGrado", grade.Nombre);
                cmd.Parameters.AddWithValue("@NivelEducacional", grade.NivelEducativo);
                cmd.ExecuteNonQuery();
            }
        }

        public bool IsGradeNameDuplicate(string gradeName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Grados WHERE NombreGrado = @NombreGrado";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreGrado", gradeName);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public List<Grade> GetAllGrades()
        {
            List<Grade> grades = new List<Grade>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ID, NombreGrado, NivelEducacional FROM Grados";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Grade grade = new Grade
                    {
                        ID = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        NivelEducativo = reader.GetString(2)
                    };
                    grades.Add(grade);
                }
            }

            return grades;
        }

        public void DeleteGradeByName(string gradeName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Grados WHERE NombreGrado = @NombreGrado";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NombreGrado", gradeName);
                cmd.ExecuteNonQuery();
            }
        }
    }
}