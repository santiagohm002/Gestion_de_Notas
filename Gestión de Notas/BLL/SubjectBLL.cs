using BLL;
using DAL;
using DAL.DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SubjectBLL
    {
        private readonly SubjectDAL subjectDAL;
        private readonly TeacherBLL teacherBLL;
        private readonly RoomBLL roomBLL;

        public SubjectBLL(string connectionString, TeacherBLL teacherBLL, RoomBLL roomBLL)
        {
            subjectDAL = new SubjectDAL(connectionString);
            this.teacherBLL = teacherBLL;
            this.roomBLL = roomBLL;
        }

        public List<Subject> GetAllSubjectsWithDetails()
        {
            return subjectDAL.GetAllSubjectsWithDetails();
        }

        public void AddSubject(Subject subject)
        {
            ValidateSubject(subject);
            subjectDAL.AddSubject(subject);
        }

        public void UpdateSubject(Subject subject)
        {
            ValidateSubject(subject);
            subjectDAL.UpdateSubject(subject);
        }

        public void DeleteSubject(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El ID de la materia debe ser un número positivo.");
            }
            subjectDAL.DeleteSubject(id);
        }

        public Subject GetSubjectByName(string subjectName)
        {
            if (string.IsNullOrEmpty(subjectName))
            {
                throw new ArgumentException("El nombre de la materia no puede estar vacío.");
            }
            return subjectDAL.GetSubjectByName(subjectName);
        }

        private void ValidateSubject(Subject subject)
        {
            if (string.IsNullOrEmpty(subject.NombreMateria))
            {
                throw new ArgumentException("El nombre de la materia no puede estar vacío.");
            }

            if (subject.DocenteEncargadoID <= 0)
            {
                throw new ArgumentException("El ID del docente encargado debe ser un número positivo.");
            }

            if (subject.SalonAsignadoID <= 0)
            {
                throw new ArgumentException("El ID del salón asignado debe ser un número positivo.");
            }

            var teacher = teacherBLL.GetTeacherById(subject.DocenteEncargadoID);
            if (teacher == null)
            {
                throw new ArgumentException("El docente especificado no existe.");
            }

            var room = roomBLL.GetRoomById(subject.SalonAsignadoID);
            if (room == null)
            {
                throw new ArgumentException("El salón especificado no existe.");
            }
        }

        public bool IsDuplicateAssignment(string nombreMateria, int docenteEncargadoID, int salonAsignadoID)
        {
            return subjectDAL.IsDuplicateAssignment(nombreMateria, docenteEncargadoID, salonAsignadoID);
        }
    }
}