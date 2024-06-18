using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class StudentBLL
    {
        private readonly StudentDAL studentDAL;

        public StudentBLL(string connectionString)
        {
            studentDAL = new StudentDAL(connectionString);
        }

        public void AddStudent(Student student)
        {
            studentDAL.AddStudent(student);
        }

        public void UpdateStudent(Student student)
        {
            studentDAL.UpdateStudent(student);
        }

        public void DeleteStudent(int identificacion)
        {
            studentDAL.DeleteStudent(identificacion);
        }

        public Student GetStudentById(int identificacion)
        {
            return studentDAL.GetStudentById(identificacion);
        }

        public bool IsIdentificationDuplicate(int identification)
        {
            return studentDAL.IsIdentificationDuplicate(identification);
        }
        public List<Student> GetAllStudents()
        {
            return studentDAL.GetAllStudents();
        }

        public List<Student> GetBasicStudentInfo()
        {
            return studentDAL.GetBasicStudentInfo();
        }

        public Student GetStudentByName(string nombreCompleto)
        {
            return studentDAL.GetStudentByName(nombreCompleto);
        }
    }
}