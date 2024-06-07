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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Grados (NombreGrado, NivelEducacional) VALUES (@NombreGrado, @NivelEducacional)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NombreGrado", grade.NombreGrado);
                    command.Parameters.AddWithValue("@NivelEducacional", grade.NivelEducacional);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteGradeByName(string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Grados WHERE NombreGrado = @NombreGrado";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NombreGrado", name);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateGrade(Grade grade)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Grados SET NivelEducacional = @NivelEducacional WHERE NombreGrado = @NombreGrado";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NombreGrado", grade.NombreGrado);
                    command.Parameters.AddWithValue("@NivelEducacional", grade.NivelEducacional);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Grade> GetAllGrades()
        {
            List<Grade> grades = new List<Grade>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Grados";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Grade grade = new Grade
                            {
                                ID = (int)reader["ID"],
                                NombreGrado = (string)reader["NombreGrado"],
                                NivelEducacional = (string)reader["NivelEducacional"]
                            };
                            grades.Add(grade);
                        }
                    }
                }
            }
            return grades;
        }

        public bool IsGradeNameDuplicate(string nombre)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Grados WHERE NombreGrado = @NombreGrado";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreGrado", nombre);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        public Grade GetGradeById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Grados WHERE ID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Grade
                            {
                                ID = (int)reader["ID"],
                                NombreGrado = (string)reader["NombreGrado"],
                                NivelEducacional = (string)reader["NivelEducacional"]
                            };
                        }
                    }
                }
            }
            return null;
        }


        public Grade GetGradeByName(string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Grados WHERE NombreGrado = @NombreGrado";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NombreGrado", name);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Grade
                            {
                                ID = (int)reader["ID"],
                                NombreGrado = (string)reader["NombreGrado"],
                                NivelEducacional = (string)reader["NivelEducacional"]
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}