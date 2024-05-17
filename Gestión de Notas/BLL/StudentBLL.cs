using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

public class StudentBLL
{
    private readonly StudentDAL studentDAL;

    public StudentBLL(string connectionString)
    {
        studentDAL = new StudentDAL(connectionString);
    }
    public List<Student> ObtenerTodosLosEstudiantes()
    {
        return studentDAL.ObtenerTodosLosEstudiantes();
    }

    public List<Student> ConsultarEstudiantesPorGrado(int grado)
    {
        return studentDAL.ObtenerEstudiantesPorGrado(grado);
    }
    public void CrearEstudiante(Student estudiante)
    {
        studentDAL.CrearEstudiante(estudiante);
    }

    public void EditarEstudiante(Student estudiante)
    {
        studentDAL.EditarEstudiante(estudiante);
    }

    public void EliminarEstudiante(int id)
    {
        studentDAL.EliminarEstudiante(id);
    }
}
