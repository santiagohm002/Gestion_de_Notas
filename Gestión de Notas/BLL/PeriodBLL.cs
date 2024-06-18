using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PeriodBLL
    {
        private readonly PeriodDAL periodDAL;

        public PeriodBLL(string connectionString)
        {
            periodDAL = new PeriodDAL(connectionString);
        }

        public List<Period> GetAllPeriodosEscolares()
        {
            return periodDAL.GetAllPeriodosEscolares();
        }

        public void AddPeriodoEscolar(Period period)
        {
            periodDAL.AddPeriodoEscolar(period);
        }

        public void UpdatePeriodoEscolar(Period period)
        {
            periodDAL.UpdatePeriodoEscolar(period);
        }

        public void DeletePeriodoEscolar(int id)
        {
            periodDAL.DeletePeriodoEscolar(id);
        }
    }
}