using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL
{
    public class AssignmentBLL
    {
        private readonly AssignmentDAL assignmentDAL;

        public AssignmentBLL(string connectionString)
        {
            assignmentDAL = new AssignmentDAL(connectionString);
        }

        public List<Teacher> GetAllTeachers()
        {
            try
            {
                return assignmentDAL.GetAllTeachers();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener todos los profesores: " + ex.Message);
            }
        }

        public List<Subject> GetAllSubjects()
        {
            try
            {
                return assignmentDAL.GetAllSubjects();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener todas las materias: " + ex.Message);
            }
        }

        public List<Grade> GetAllGrades()
        {
            try
            {
                return assignmentDAL.GetAllGrades();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener todos los grados: " + ex.Message);
            }
        }

        public string GetTeacherNameById(int teacherId)
        {
            try
            {
                return assignmentDAL.GetTeacherNameById(teacherId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el nombre del docente por ID: " + ex.Message);
            }
        }

        public string GetSubjectNameById(int subjectId)
        {
            try
            {
                return assignmentDAL.GetSubjectNameById(subjectId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el nombre de la materia por ID: " + ex.Message);
            }
        }

        public int GetGradeValueById(int gradeId)
        {
            try
            {
                return assignmentDAL.GetGradeValueById(gradeId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el valor del grado por ID: " + ex.Message);
            }
        }

        public List<Assignment> GetAllAssignments()
        {
            try
            {
                return assignmentDAL.GetAllAssignments();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener todas las asignaciones: " + ex.Message);
            }
        }

        public void AssignSubjectToTeacher(int subjectId, int teacherId, int gradeId)
        {
            try
            {
                assignmentDAL.AssignSubjectToTeacher(subjectId, teacherId, gradeId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al asignar materia a docente: " + ex.Message);
            }
        }

        public Assignment GetAssignmentById(int assignmentId)
        {
            try
            {
                return assignmentDAL.GetAssignmentById(assignmentId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la asignación por ID: " + ex.Message);
            }
        }

        public DataTable GetAssignmentsByGrade(int gradeId)
        {
            try
            {
                return assignmentDAL.GetAssignmentsByGrade(gradeId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las asignaciones por grado: " + ex.Message);
            }
        }

        public void DeleteAssignment(int assignmentId)
        {
            try
            {
                assignmentDAL.DeleteAssignment(assignmentId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la asignación: " + ex.Message);
            }
        }
    }
}