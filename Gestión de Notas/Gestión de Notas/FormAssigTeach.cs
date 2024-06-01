using BLL;
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
    public partial class FormAssigTeach : Form
    {
        private readonly AssignmentBLL assignmentBLL;
        private readonly string connectionString = @"Data Source=SANTIAGO\MSSQLSERVER01;Initial Catalog=Colegio;Integrated Security=True";

        public FormAssigTeach()
        {
            InitializeComponent();
            assignmentBLL = new AssignmentBLL(connectionString);

            FillComboBoxes();
            RefreshDataGridView();
        }

        private void FillComboBoxes()
        {
            try
            {
                var teachers = assignmentBLL.GetAllTeachers();
                cbx_Teacher.DataSource = teachers;
                cbx_Teacher.DisplayMember = "Nombre";
                cbx_Teacher.ValueMember = "DocenteID";

                var subjects = assignmentBLL.GetAllSubjects();
                cbx_Subject.DataSource = subjects;
                cbx_Subject.DisplayMember = "Nombre";
                cbx_Subject.ValueMember = "MateriaID";

                var grades = assignmentBLL.GetAllGrades();
                cbx_Grade.DataSource = grades;
                cbx_Grade.DisplayMember = "Numero";
                cbx_Grade.ValueMember = "GradoID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lista desplegables: " + ex.Message);
            }
        }
        private void RefreshDataGridView()
        {
            try
            {
                var assignments = assignmentBLL.GetAllAssignments();

                var displayAssignments = new List<DisplayAssignment>();

                foreach (var assignment in assignments)
                {
                    string teacherName = assignmentBLL.GetTeacherNameById(assignment.ProfesorID);

                    string subjectName = assignmentBLL.GetSubjectNameById(assignment.MateriaID);

                    int gradeValue = assignmentBLL.GetGradeValueById(assignment.GradoID);

                    displayAssignments.Add(new DisplayAssignment
                    {
                        AsigID = assignment.AsigID,
                        NombreDocente = teacherName,
                        NombreMateria = subjectName,
                        Grado = gradeValue
                    });
                }

                dtg_Assignments.DataSource = displayAssignments;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la tabla de asignaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbx_Teacher.SelectedValue != null && cbx_Subject.SelectedValue != null && cbx_Grade.SelectedValue != null)
                {
                    int teacherId = Convert.ToInt32(cbx_Teacher.SelectedValue);
                    int subjectId = Convert.ToInt32(cbx_Subject.SelectedValue);
                    int gradeId = Convert.ToInt32(cbx_Grade.SelectedValue);

                    assignmentBLL.AssignSubjectToTeacher(subjectId, teacherId, gradeId);
                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione valores válidos en todos los ComboBoxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la asignación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Consult_Click(object sender, EventArgs e)
        {
            try
            {
                int gradeId = (int)cbx_Grade.SelectedValue;
                var assignmentsByGrade = assignmentBLL.GetAssignmentsByGrade(gradeId);
                dtg_Assignments.DataSource = assignmentsByGrade;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar las asignaciones por grado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_Assignments.SelectedRows.Count > 0)
                {
                    int assignmentId = (int)dtg_Assignments.SelectedRows[0].Cells["AsigID"].Value;

                    Assignment selectedAssignment = assignmentBLL.GetAssignmentById(assignmentId);
                    string teacherName = assignmentBLL.GetTeacherNameById(selectedAssignment.ProfesorID);
                    string subjectName = assignmentBLL.GetSubjectNameById(selectedAssignment.MateriaID);
                    int gradeValue = assignmentBLL.GetGradeValueById(selectedAssignment.GradoID);

                    MessageBox.Show($"Se eliminará la asignación: Docente: {teacherName}, Materia: {subjectName}, Grado: {gradeValue}", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    assignmentBLL.DeleteAssignment(assignmentId);

                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una asignación para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la asignación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}