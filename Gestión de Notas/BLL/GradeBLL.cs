using System.Collections.Generic;
using DAL;
using Entity;

namespace BLL
{
    public class GradeBLL
    {
        private readonly GradeDAL gradeDAL;

        public GradeBLL(string connectionString)
        {
            gradeDAL = new GradeDAL(connectionString);
        }

        public void AddGrade(Grade grade)
        {
            gradeDAL.AddGrade(grade);
        }

        public void DeleteGradeByName(string name)
        {
            gradeDAL.DeleteGradeByName(name);
        }

        public void UpdateGrade(Grade grade)
        {
            gradeDAL.UpdateGrade(grade);
        }

        public List<Grade> GetAllGrades()
        {
            return gradeDAL.GetAllGrades();
        }

        public bool IsGradeNameDuplicate(string gradeName)
        {
            return gradeDAL.IsGradeNameDuplicate(gradeName);
        }

        public Grade GetGradeById(int id)
        {
            return gradeDAL.GetGradeById(id);
        }

        public Grade GetGradeByName(string name)
        {
            return gradeDAL.GetGradeByName(name);
        }
    }
}