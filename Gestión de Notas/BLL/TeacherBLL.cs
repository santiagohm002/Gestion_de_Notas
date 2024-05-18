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
        public List<Teacher> ObtenerTodosLosDocentes()
        {
            return teacherDAL.ObtenerTodosLosDocentes();
        }

        public List<Teacher> ConsultarDocentesPorEspecialidad(string especialidad)
        {
            return teacherDAL.ObtenerDocentesPorEspecialidad(especialidad);
        }
        public void CrearDocente(Teacher docente)
        {
            teacherDAL.CrearDocente(docente);
        }

        public void EditarDocente(Teacher docente)
        {
            teacherDAL.EditarDocente(docente);
        }

        public void EliminarDocente(int id)
        {
            teacherDAL.EliminarDocente(id);
        }
    }
}
