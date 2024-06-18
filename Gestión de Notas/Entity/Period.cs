using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Period
    {
        public int ID { get; set; }
        public string NombrePeriodo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int AnoEscolarID { get; set; }
         public string Ano { get; set; }
    }
}