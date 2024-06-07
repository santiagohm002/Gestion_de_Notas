using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAL;
using Entity;

namespace BLL
{
    public class RoomBLL
    {
        private readonly RoomDAL roomDAL;

        public RoomBLL(string connectionString)
        {
            roomDAL = new RoomDAL(connectionString);
        }

        // Método para agregar un salón
        public void AddRoom(Room room)
        {
            roomDAL.AddRoom(room);
        }

        // Método para eliminar un salón por su nombre
        public void DeleteRoomByName(string nombreSalon)
        {
            roomDAL.DeleteRoomByName(nombreSalon);
        }

        // Método para obtener todos los salones
        public List<Room> GetAllRooms()
        {
            return roomDAL.GetAllRooms();
        }

        // Método para obtener un salón por su nombre
        public Room GetRoomByName(string nombreSalon)
        {
            return roomDAL.GetRoomByName(nombreSalon);
        }
    }
}