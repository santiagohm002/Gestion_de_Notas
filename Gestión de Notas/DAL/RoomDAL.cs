using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    namespace DAL
    {
        public class RoomDAL
        {
            private readonly string connectionString;

            public RoomDAL(string connectionString)
            {
                this.connectionString = connectionString;
            }

            public void AddRoom(Room room)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Salones (NombreSalon, IDGrado) VALUES (@NombreSalon, @IDGrado)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NombreSalon", room.NombreSalon);
                        command.Parameters.AddWithValue("@IDGrado", room.IDGrado);
                        command.ExecuteNonQuery();
                    }
                }
            }

            public void DeleteRoomByName(string name)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Salones WHERE NombreSalon = @NombreSalon";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NombreSalon", name);
                        command.ExecuteNonQuery();
                    }
                }
            }

            public Room GetRoomById(int id)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Salones WHERE ID = @ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Room
                                {
                                    ID = (int)reader["ID"],
                                    NombreSalon = (string)reader["NombreSalon"],
                                    IDGrado = (int)reader["IDGrado"]
                                };
                            }
                        }
                    }
                }
                return null;
            }

            public Room GetRoomByName(string nombreSalon)
            {
                Room room = null;

                // Query SQL para obtener el salón por su nombre
                string query = "SELECT ID, NombreSalon, IDGrado FROM Salones WHERE NombreSalon = @NombreSalon";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NombreSalon", nombreSalon);

                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                // Si se encontró el salón, crea un objeto Room con los datos de la fila
                                room = new Room
                                {
                                    ID = Convert.ToInt32(reader["ID"]),
                                    NombreSalon = reader["NombreSalon"].ToString(),
                                    IDGrado = Convert.ToInt32(reader["IDGrado"])
                                };
                            }

                            reader.Close();
                        }
                        catch (Exception ex)
                        {
                            // Manejo de excepciones
                            Console.WriteLine("Error: " + ex.Message);
                        }
                    }
                }

                return room;
            }

            public List<Room> GetAllRooms()
            {
                List<Room> rooms = new List<Room>();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Salones";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Room room = new Room
                                {
                                    ID = (int)reader["ID"],
                                    NombreSalon = (string)reader["NombreSalon"],
                                    IDGrado = (int)reader["IDGrado"]
                                };
                                rooms.Add(room);
                            }
                        }
                    }
                }
                return rooms;
            }

            public List<Subject> GetSubjectsByRoom(string roomName)
            {
                List<Subject> subjects = new List<Subject>();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                    SELECT 
                        s.ID,
                        s.NombreMateria,
                        t.NombreCompleto AS DocenteEncargado,
                        r.NombreSalon AS SalonAsignado,
                        s.DocenteEncargadoID,
                        s.SalonAsignadoID
                    FROM Materias s
                    JOIN Docentes t ON s.DocenteEncargadoID = t.ID
                    JOIN Salones r ON s.SalonAsignadoID = r.ID
                    WHERE r.NombreSalon = @RoomName";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoomName", roomName);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                subjects.Add(new Subject
                                {
                                    ID = (int)reader["ID"],
                                    NombreMateria = reader["NombreMateria"].ToString(),
                                    DocenteEncargado = reader["DocenteEncargado"].ToString(),
                                    SalonAsignado = reader["SalonAsignado"].ToString(),
                                    DocenteEncargadoID = (int)reader["DocenteEncargadoID"],
                                    SalonAsignadoID = (int)reader["SalonAsignadoID"]
                                });
                            }
                        }
                    }
                }
                return subjects;
            }
        }
    }
}