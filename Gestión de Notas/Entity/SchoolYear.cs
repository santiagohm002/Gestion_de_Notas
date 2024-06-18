using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SchoolYear
    {
        public int ID { get; set; }
        public string Ano { get; set; }
        public DateTime FechadeInicio { get; set; }
        public DateTime FechadeFin { get; set; }
    }

}