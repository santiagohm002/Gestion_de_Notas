using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Subject
    {
        public int ID { get; set; }
        public string NombreMateria { get; set; }
        public int DocenteEncargadoID { get; set; }
        public string DocenteEncargado { get; set; }
        public int SalonAsignadoID { get; set; }
        public string SalonAsignado { get; set; }
    }
}