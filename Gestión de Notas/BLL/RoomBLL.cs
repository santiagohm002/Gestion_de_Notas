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

        public Room GetRoomById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El ID del salón debe ser un número positivo.");
            }
            return roomDAL.GetRoomById(id);
        }

        public List<Room> GetAllRooms()
        {
            return roomDAL.GetAllRooms();
        }

        public Room GetRoomByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("El nombre del salón no puede estar vacío.");
            }
            return roomDAL.GetRoomByName(name);
        }

        public void AddRoom(Room room)
        {
            ValidateRoom(room);
            roomDAL.AddRoom(room);
        }

        public void DeleteRoomByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("El nombre del salón no puede estar vacío.");
            }
            roomDAL.DeleteRoomByName(name);
        }

        private void ValidateRoom(Room room)
        {
            if (string.IsNullOrEmpty(room.NombreSalon))
            {
                throw new ArgumentException("El nombre del salón no puede estar vacío.");
            }

            if (room.IDGrado <= 0)
            {
                throw new ArgumentException("El ID del grado debe ser un número positivo.");
            }
        }

        public List<Subject> GetSubjectsByRoom(string roomName)
        {
            return roomDAL.GetSubjectsByRoom(roomName);
        }
    }
}