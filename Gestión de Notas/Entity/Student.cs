using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Student
    {
        private int _edad;

        public int ID { get; set; }
        public string NombreCompleto { get; set; }
        public int Identificacion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string TelefonoContacto { get; set; }
        public string CorreoElectronico { get; set; }
        public int Edad
        {
            get
            {
                // Si la edad es 0, calcularla
                if (_edad == 0)
                {
                    DateTime now = DateTime.Today;
                    int age = now.Year - FechaNacimiento.Year;
                    if (now < FechaNacimiento.AddYears(age))
                    {
                        age--;
                    }
                    _edad = age;
                }
                return _edad;
            }
            set
            {
                // Permitir establecer la edad
                _edad = value;
            }
        }
    }
}