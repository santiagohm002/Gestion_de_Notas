using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace BLL
{
    public class AssignedStudentBLL
    {
        private readonly AssignedStudentDAL assignedStudentDAL;

        public AssignedStudentBLL(string connectionString)
        {
            assignedStudentDAL = new AssignedStudentDAL(connectionString);
        }

        public List<AssignedStudent> GetAllAssignedStudents()
        {
            return assignedStudentDAL.GetAllAssignedStudents();
        }

        public AssignedStudent GetAssignedStudentByStudentID(int estudianteID)
        {
            return assignedStudentDAL.GetAssignedStudentByStudentID(estudianteID);
        }

        public List<AssignedStudent> GetAssignedStudentsByRoomID(int salonID)
        {
            return assignedStudentDAL.GetAssignedStudentsByRoomID(salonID);
        }

        public void AddAssignedStudent(int estudianteID, int salonID)
        {
            AssignedStudent existingAssignment = assignedStudentDAL.GetAssignedStudentByStudentID(estudianteID);

            if (existingAssignment != null)
            {
                throw new Exception("El estudiante ya está asignado a un salón.");
            }

            assignedStudentDAL.AddAssignedStudent(estudianteID, salonID);
        }

        public void DeleteAssignedStudent(int id)
        {
            assignedStudentDAL.DeleteAssignedStudent(id);
        }

        public void UpdateAssignedStudent(int id, int newSalonID)
        {
            assignedStudentDAL.UpdateAssignedStudent(id, newSalonID);
        }
    }
}