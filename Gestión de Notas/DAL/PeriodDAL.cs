using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PeriodDAL
    {
        private readonly string connectionString;

        public PeriodDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public List<Period> GetAllPeriodosEscolares()
        {
            List<Period> periods = new List<Period>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT m.ID, m.NombrePeriodo, m.FechaInicio, m.FechaFin, d.Ano AS AnoEscolar, m.AnoEscolarID
                FROM Periodos m
                INNER JOIN AnoEscolar d ON m.AnoEscolarID = d.ID";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    periods.Add(new Period
                    {
                        ID = (int)reader["ID"],
                        AnoEscolarID = (int)reader["AnoEscolarID"],
                        Ano = (string)reader["AnoEscolar"],
                        NombrePeriodo = (string)reader["NombrePeriodo"],
                        FechaInicio = (DateTime)reader["FechaInicio"],
                        FechaFin = (DateTime)reader["FechaFin"]
                    });
                }
            }
            return periods;
        }

        public void AddPeriodoEscolar(Period period)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Periodos (AnoEscolarID, NombrePeriodo, FechaInicio, FechaFin) VALUES (@AnoEscolarID, @NombrePeriodo, @FechaInicio, @FechaFin)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AnoEscolarID", period.AnoEscolarID);
                command.Parameters.AddWithValue("@NombrePeriodo", period.NombrePeriodo);
                command.Parameters.AddWithValue("@FechaInicio", period.FechaInicio);
                command.Parameters.AddWithValue("@FechaFin", period.FechaFin);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdatePeriodoEscolar(Period period)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Periodos SET AnoEscolarID = @AnoEscolarID, NombrePeriodo = @NombrePeriodo, FechaInicio = @FechaInicio, FechaFin = @FechaFin WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", period.ID);
                command.Parameters.AddWithValue("@AnoEscolarID", period.AnoEscolarID);
                command.Parameters.AddWithValue("@NombrePeriodo", period.NombrePeriodo);
                command.Parameters.AddWithValue("@FechaInicio", period.FechaInicio);
                command.Parameters.AddWithValue("@FechaFin", period.FechaFin);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeletePeriodoEscolar(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Periodos WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Period GetPeriodoEscolarById(int id)
        {
            Period period = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Periodos WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    period = new Period
                    {
                        ID = (int)reader["ID"],
                        AnoEscolarID = (int)reader["AnoEscolarID"],
                        NombrePeriodo = (string)reader["NombrePeriodo"],
                        FechaInicio = (DateTime)reader["FechaInicio"],
                        FechaFin = (DateTime)reader["FechaFin"]
                    };
                }
            }
            return period;
        }
    }
}