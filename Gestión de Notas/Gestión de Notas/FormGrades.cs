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
    public partial class FormGrades : Form
    {
        private readonly GradeBLL gradeBLL;
        private readonly List<string> validGradeNames = new List<string>
        {
            "Primero", "Segundo", "Tercero", "Cuarto", "Quinto",
            "Sexto", "Séptimo", "Octavo", "Noveno", "Décimo", "Once"
        };

        public FormGrades()
        {
            InitializeComponent();
            string connectionString = "Data Source= 108.181.184.38; Initial Catalog= SantiagoDB ;User ID= santiagohernandez ;Password= Holamundo123*";
            gradeBLL = new GradeBLL(connectionString);
            InitializeDataGridView();
            RefreshGradeGrid();

            txt_Grades.TextChanged += txt_Grades_TextChanged;

            txt_LevelEd.ReadOnly = true;
        }

        private void InitializeDataGridView()
        {
            dtg_Grades.Columns.Clear();
            dtg_Grades.Columns.Add("ID", "ID");
            dtg_Grades.Columns.Add("NombreGrado", "Nombre");
            dtg_Grades.Columns.Add("NivelEducacional", "Nivel Educativo");

            dtg_Grades.SelectionChanged += dtg_Grades_SelectionChanged;
        }

        private void RefreshGradeGrid()
        {
            dtg_Grades.Rows.Clear();
            List<Grade> grades = gradeBLL.GetAllGrades();
            foreach (Grade grade in grades)
            {
                dtg_Grades.Rows.Add(grade.ID, grade.Nombre, grade.NivelEducativo);
            }
        }

        private void btn_AddGrade_Click(object sender, EventArgs e)
        {
            string nombre = txt_Grades.Text.Trim();

            // Validar que el campo no esté vacío
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Error, Digite Nombre de Grado para agregar.");
                return;
            }

            // Validar que el nombre del grado sea uno de los permitidos
            if (!validGradeNames.Contains(nombre))
            {
                MessageBox.Show("Nombre de grado no permitido. Solo se permiten: " + string.Join(", ", validGradeNames));
                return;
            }

            // Validar que el grado no esté duplicado
            if (gradeBLL.IsGradeNameDuplicate(nombre))
            {
                MessageBox.Show("Este grado ya está registrado.");
                return;
            }

            Grade grade = new Grade { Nombre = nombre };
            grade.NivelEducativo = DetermineNivelEducativo(nombre);
            gradeBLL.AddGrade(grade);

            // Actualizar el campo de texto con el nivel educativo
            txt_LevelEd.Text = grade.NivelEducativo;

            RefreshGradeGrid();
            txt_Grades.Clear();
            txt_LevelEd.Clear();
        }

        private string DetermineNivelEducativo(string nombreGrado)
        {
            string nivelEducativo;

            // Determinar el nivel educativo basado en el nombre del grado
            if (nombreGrado == "Primero" || nombreGrado == "Segundo" || nombreGrado == "Tercero" ||
                nombreGrado == "Cuarto" || nombreGrado == "Quinto")
            {
                nivelEducativo = "Primaria";
            }
            else if (nombreGrado == "Sexto" || nombreGrado == "Séptimo" || nombreGrado == "Octavo" ||
                     nombreGrado == "Noveno" || nombreGrado == "Décimo" || nombreGrado == "Once")
            {
                nivelEducativo = "Bachillerato";
            }
            else
            {
                nivelEducativo = string.Empty;
            }

            return nivelEducativo;
        }

        private void txt_Grades_TextChanged(object sender, EventArgs e)
        {
            string nombre = txt_Grades.Text.Trim();
            txt_LevelEd.Text = DetermineNivelEducativo(nombre);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DeleteGrad_Click(object sender, EventArgs e)
        {
            string nombre = txt_Grades.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Error, Digite Nombre de Grado para eliminar.");
                return;
            }

            if (!validGradeNames.Contains(nombre))
            {
                MessageBox.Show("Nombre de grado no permitido. Solo se permiten: " + string.Join(", ", validGradeNames));
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este grado?", "Confirmación de eliminación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                gradeBLL.DeleteGradeByName(nombre);
                RefreshGradeGrid();
                txt_Grades.Clear();
                txt_LevelEd.Clear();
                MessageBox.Show("Grado eliminado correctamente.");
            }
        }

        private void dtg_Grades_SelectionChanged(object sender, EventArgs e)
        {
            if (dtg_Grades.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtg_Grades.SelectedRows[0];
                txt_Grades.Text = selectedRow.Cells["NombreGrado"].Value.ToString();
                txt_LevelEd.Text = selectedRow.Cells["NivelEducacional"].Value.ToString();
            }
        }
    }
}