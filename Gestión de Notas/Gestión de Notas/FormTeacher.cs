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
    public partial class FormTeacher : Form
    {
        private readonly TeacherBLL teacherBLL;
        private readonly string connectionString = @"Data Source=SANTIAGO\MSSQLSERVER01;Initial Catalog=Colegio;Integrated Security=True";
        public FormTeacher()
        {
            InitializeComponent();
            teacherBLL = new TeacherBLL(connectionString);
            RefreshDataGridView();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Teacher newTeacher = new Teacher
            {
                Identificacion = txt_Id.Text,
                Nombre = txt_Name.Text,
                Apellido = txt_Surname.Text,
                Especialidad = txt_Specialty.Text,
            };
            teacherBLL.CrearDocente(newTeacher);
            MessageBox.Show($"Se ha registrado el docente correctamente");
            txt_Id.Text = "";
            txt_Name.Text = "";
            txt_Surname.Text = "";
            txt_Specialty.Text = "";

            RefreshDataGridView();
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            Teacher newTeacher = new Teacher
            {
                Identificacion = txt_Id.Text,
                Nombre = txt_Name.Text,
                Apellido = txt_Surname.Text,
                Especialidad = txt_Specialty.Text,
            };
            teacherBLL.CrearDocente(newTeacher);
            MessageBox.Show($"Se ha actualizado el docente correctamente");
            txt_Id.Text = "";
            txt_Name.Text = "";
            txt_Surname.Text = "";
            txt_Specialty.Text = "";

            RefreshDataGridView();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int identificacion = Convert.ToInt32(txt_Id.Text);

            teacherBLL.EliminarDocente(identificacion);
            MessageBox.Show($"Se ha eliminado el docente correctamente");
            txt_Id.Text = "";
            txt_Name.Text = "";
            txt_Surname.Text = "";
            txt_Specialty.Text = "";

            RefreshDataGridView();
        }
        private void btn_Consult_Click(object sender, EventArgs e)
        {
            string especialidad = txt_Specialty.Text;

            RefreshDataGridView(teacherBLL.ConsultarDocentesPorEspecialidad(especialidad));
        }
        private void RefreshDataGridView(List<Teacher> docentes = null)
        {
            if (docentes == null)
            {
                dtg_Student.DataSource = teacherBLL.ObtenerTodosLosDocentes();
            }
            else
            {
                dtg_Student.DataSource = docentes;
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}