using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TeacherBLL
    {
        private readonly TeacherDAL teacherDAL;

        public TeacherBLL(string connectionString)
        {
            teacherDAL = new TeacherDAL(connectionString);
        }

        public Teacher GetTeacherById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El ID del docente debe ser un número positivo.");
            }
            return teacherDAL.GetTeacherById(id);
        }

        public List<Teacher> GetTeachersBySpecialty(string specialty)
        {
            if (string.IsNullOrEmpty(specialty))
            {
                throw new ArgumentException("La especialidad no puede estar vacía.");
            }
            return teacherDAL.GetTeachersBySpecialty(specialty);
        }

        public Teacher GetTeacherByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("El nombre del docente no puede estar vacío.");
            }
            return teacherDAL.GetTeacherByName(name);
        }

        public void AddTeacher(Teacher teacher)
        {
            ValidateTeacher(teacher);
            teacherDAL.AddTeacher(teacher);
        }

        public void UpdateTeacher(Teacher teacher)
        {
            ValidateTeacher(teacher);
            teacherDAL.UpdateTeacher(teacher);
        }

        public void DeleteTeacher(string identificacion)
        {
            if (string.IsNullOrEmpty(identificacion))
            {
                throw new ArgumentException("La identificación no puede estar vacía.");
            }
            teacherDAL.DeleteTeacher(identificacion);
        }

        public List<Teacher> GetAllTeachers()
        {
            return teacherDAL.GetAllTeachers();
        }

        public List<Teacher> GetBasicInfoTeachers()
        {
            return teacherDAL.GetBasicInfoTeachers();
        }

        public bool IsIdentificationDuplicate(string identification)
        {
            return teacherDAL.IsIdentificationDuplicate(identification);
        }

        private void ValidateTeacher(Teacher teacher)
        {
            if (string.IsNullOrEmpty(teacher.NombreCompleto))
            {
                throw new ArgumentException("El nombre completo no puede estar vacío.");
            }

            if (string.IsNullOrEmpty(teacher.Identificacion))
            {
                throw new ArgumentException("La identificación no puede estar vacía.");
            }

            if (string.IsNullOrEmpty(teacher.Especialidad))
            {
                throw new ArgumentException("La especialidad no puede estar vacía.");
            }
        }
    }
}