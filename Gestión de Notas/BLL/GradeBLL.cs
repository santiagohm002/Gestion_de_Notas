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

        public List<Grade> GetAllGrades()
        {
            return gradeDAL.GetAllGrades();
        }

        public bool IsGradeNameDuplicate(string gradeName)
        {
            return gradeDAL.IsGradeNameDuplicate(gradeName);
        }

        public void DeleteGradeByName(string gradeName)
        {
            gradeDAL.DeleteGradeByName(gradeName);
        }
    }
}