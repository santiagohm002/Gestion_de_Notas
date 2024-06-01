using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Assignment
    {
        public int AsigID { get; set; }
        public int MateriaID { get; set; }
        public int ProfesorID { get; set; }
        public int GradoID { get; set; }

        public Assignment()
        {

        }

        public Assignment(int asigID, int materiaID, int profesorID, int gradoID)
        {
            AsigID = asigID;
            MateriaID = materiaID;
            ProfesorID = profesorID;
            GradoID = gradoID;
        }
    }
}