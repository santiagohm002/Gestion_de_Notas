using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Gestión_de_Notas
{
    public partial class FormStudent : Form
    {
        private readonly StudentBLL studentBLL;
        private readonly string connectionString = @"Data Source=SANTIAGO\MSSQLSERVER01;Initial Catalog=Colegio;Integrated Security=True";
        public FormStudent()
        {
            InitializeComponent();
            studentBLL = new StudentBLL(connectionString);
            RefreshDataGridView();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student
            {
                Identificacion = txt_Id.Text,
                Nombre = txt_Name.Text,
                Apellido = txt_Surname.Text,
                Grado = Convert.ToInt32(txt_Grades.SelectedItem)
            };
            studentBLL.CrearEstudiante(newStudent);

            RefreshDataGridView();
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            Student updatedStudent = new Student
            {
                Identificacion = txt_Id.Text,
                Nombre = txt_Name.Text,
                Apellido = txt_Surname.Text,
                Grado = Convert.ToInt32(txt_Grades.SelectedItem)
            };

            studentBLL.EditarEstudiante(updatedStudent);

            RefreshDataGridView();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int identificacion = Convert.ToInt32(txt_Id.Text);

            studentBLL.EliminarEstudiante(identificacion);

            RefreshDataGridView();
        }
        private void btn_Consult_Click(object sender, EventArgs e)
        {
            int grado = Convert.ToInt32(txt_Grades.SelectedItem);

            RefreshDataGridView(studentBLL.ConsultarEstudiantesPorGrado(grado));
        }
        private void RefreshDataGridView(List<Student> estudiantes = null)
        {
            if (estudiantes == null)
            {
                dtg_Student.DataSource = studentBLL.ObtenerTodosLosEstudiantes();
            }
            else
            {
                dtg_Student.DataSource = estudiantes;
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}