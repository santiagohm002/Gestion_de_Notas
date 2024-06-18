using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Teacher
    {
        public int ID { get; set; }
        public string NombreCompleto { get; set; }
        public string Identificacion { get; set; }
        public string Direccion { get; set; }
        public string TelefonoContacto { get; set; }
        public string CorreoElectronico { get; set; }
        public string Especialidad { get; set; }
    }
}