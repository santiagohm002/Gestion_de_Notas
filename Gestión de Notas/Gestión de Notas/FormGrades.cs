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

namespace Gestión_de_Notas
{
    public partial class FormGrades : Form
    {
        private readonly StudentBLL studentBLL;
        private readonly string connectionString = @"Data Source=SANTIAGO\MSSQLSERVER01;Initial Catalog=Colegio;Integrated Security=True";
        public FormGrades()
        {
            InitializeComponent();
            studentBLL = new StudentBLL(connectionString);
            RefreshDataGridView();
        }

        private void btn_Consult_Click(object sender, EventArgs e)
        {
            int grado = Convert.ToInt32(txt_Grades.Text);  

            RefreshDataGridView(studentBLL.ConsultarEstudiantesPorGrado(grado));
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
