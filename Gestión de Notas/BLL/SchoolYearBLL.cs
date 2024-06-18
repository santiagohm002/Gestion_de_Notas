using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class SchoolYearBLL
    {
        private readonly SchoolYearDAL schoolYearDAL;

        public SchoolYearBLL(string connectionString)
        {
            schoolYearDAL = new SchoolYearDAL(connectionString);
        }

        public List<SchoolYear> GetAllSchoolYears()
        {
            return schoolYearDAL.GetAllSchoolYears();
        }

        public void AddSchoolYear(SchoolYear schoolYear)
        {
            schoolYearDAL.AddSchoolYear(schoolYear);
        }

        public void UpdateSchoolYear(SchoolYear schoolYear)
        {
            schoolYearDAL.UpdateSchoolYear(schoolYear);
        }

        public void DeleteSchoolYear(int id)
        {
            schoolYearDAL.DeleteSchoolYear(id);
        }

        public SchoolYear GetSchoolYearByName(string ano)
        {
            return schoolYearDAL.GetSchoolYearByName(ano);
        }
    }
}