using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SchoolYearDAL
    {
        private readonly string connectionString;

        public SchoolYearDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<SchoolYear> GetAllSchoolYears()
        {
            var schoolYears = new List<SchoolYear>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM AnoEscolar";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    schoolYears.Add(new SchoolYear
                    {
                        ID = (int)reader["ID"],
                        Ano = (string)reader["Ano"],
                        FechadeInicio = (DateTime)reader["FechadeInicio"],
                        FechadeFin = (DateTime)reader["FechadeFin"],
                    });
                }
            }
            return schoolYears;
        }

        public void AddSchoolYear(SchoolYear schoolYear)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO AnoEscolar (Ano) VALUES (@Ano)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AnoEscolar", schoolYear.Ano);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateSchoolYear(SchoolYear schoolYear)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE AnoEscolar SET Ano = @Ano WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", schoolYear.ID);
                command.Parameters.AddWithValue("@AnoEscolar", schoolYear.Ano);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteSchoolYear(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM AnoEscolar WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public SchoolYear GetSchoolYearByName(string ano)
        {
            SchoolYear schoolYear = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM AnoEscolar WHERE Ano = @Ano";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Ano", ano);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    schoolYear = new SchoolYear
                    {
                        ID = (int)reader["ID"],
                        Ano = (string)reader["Ano"],
                        FechadeInicio = (DateTime)reader["FechadeInicio"],
                        FechadeFin = (DateTime)reader["FechadeFin"],
                    };
                }
            }
            return schoolYear;
        }
    }
}