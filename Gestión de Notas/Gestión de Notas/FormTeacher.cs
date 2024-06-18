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
using System.Text.RegularExpressions;

namespace Gestión_de_Notas
{
    public partial class FormTeacher : Form
    {
        private readonly TeacherBLL teacherBLL;
        private readonly string connectionString = "Data Source=sql.hmdevs.com; Initial Catalog=SantiagoDB; User ID=santiagohernandez; Password=Holamundo123*";

        public FormTeacher()
        {
            InitializeComponent();
            teacherBLL = new TeacherBLL(connectionString);
            InitializeDataGridView();
            this.Load += FormTeacher_Load;
        }

        private void InitializeDataGridView()
        {
            dtg_Teacher.Columns.Clear();
            dtg_Teacher.Columns.Add("ID", "ID");
            dtg_Teacher.Columns.Add("NombreCompleto", "Nombre Completo");
            dtg_Teacher.Columns.Add("Identificacion", "Identificación");
            dtg_Teacher.Columns.Add("Direccion", "Dirección");
            dtg_Teacher.Columns.Add("TelefonoContacto", "Teléfono de Contacto");
            dtg_Teacher.Columns.Add("CorreoElectronico", "Correo Electrónico");
            dtg_Teacher.Columns.Add("Especialidad", "Especialidad");
        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            RefreshTeacherGrid();
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Validación más rigurosa utilizando expresión regular
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool IsIdentificationDuplicate()
        {
            if (teacherBLL.IsIdentificationDuplicate(txt_DNI.Text))
            {
                MessageBox.Show("Ya existe un docente con esta identificación.");
                return false;
            }
            return true;
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txt_Fullname.Text) ||
                string.IsNullOrWhiteSpace(txt_DNI.Text) ||
                string.IsNullOrWhiteSpace(txt_Adress.Text) ||
                string.IsNullOrWhiteSpace(txt_Tel.Text) ||
                string.IsNullOrWhiteSpace(txt_Email.Text) ||
                string.IsNullOrWhiteSpace(txt_Specialty.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return false;
            }

            if (!int.TryParse(txt_DNI.Text, out _))
            {
                MessageBox.Show("La identificación debe ser un número.");
                return false;
            }

            if (!txt_Tel.Text.StartsWith("3") || txt_Tel.Text.Length != 10)
            {
                MessageBox.Show("Error al agregar Docente. El número de contacto es inválido.");
                return false;
            }

            string emailToValidate = txt_Email.Text.Trim();
            MessageBox.Show($"Validando correo: '{emailToValidate}'");

            if (!IsValidEmail(emailToValidate))
            {
                MessageBox.Show($"El correo electrónico '{emailToValidate}' no es válido.");
                return false;
            }

            return true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields()) return;
                if (!IsIdentificationDuplicate()) return;

                var teacher = new Teacher
                {
                    NombreCompleto = txt_Fullname.Text,
                    Identificacion = txt_DNI.Text,
                    Direccion = txt_Adress.Text,
                    TelefonoContacto = txt_Tel.Text,
                    CorreoElectronico = txt_Email.Text,
                    Especialidad = txt_Specialty.Text
                };

                teacherBLL.AddTeacher(teacher);
                RefreshTeacherGrid();
                ClearFields();
                MessageBox.Show("Docente agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar docente: " + ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields()) return;

                var teacher = new Teacher
                {
                    NombreCompleto = txt_Fullname.Text,
                    Identificacion = txt_DNI.Text,
                    Direccion = txt_Adress.Text,
                    TelefonoContacto = txt_Tel.Text,
                    CorreoElectronico = txt_Email.Text,
                    Especialidad = txt_Specialty.Text
                };

                teacherBLL.UpdateTeacher(teacher);
                RefreshTeacherGrid();
                ClearFields();
                MessageBox.Show("Docente actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar docente: " + ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_DNI.Text))
                {
                    MessageBox.Show("Por favor, seleccione un docente para eliminar.");
                    return;
                }

                string teacherId = txt_DNI.Text;
                var result = MessageBox.Show("¿Está seguro de que desea eliminar este docente?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    teacherBLL.DeleteTeacher(teacherId);
                    RefreshTeacherGrid();
                    ClearFields();
                    MessageBox.Show("Docente eliminado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar docente: " + ex.Message);
            }
        }

        private void dtgTeachers_SelectionChanged(object sender, EventArgs e)
        {
            if (dtg_Teacher.SelectedRows.Count > 0)
            {
                var row = dtg_Teacher.SelectedRows[0];
                txt_Fullname.Text = row.Cells["NombreCompleto"].Value.ToString();
                txt_DNI.Text = row.Cells["Identificacion"].Value.ToString();
                txt_Adress.Text = row.Cells["Direccion"].Value.ToString();
                txt_Tel.Text = row.Cells["TelefonoContacto"].Value.ToString();
                txt_Email.Text = row.Cells["CorreoElectronico"].Value.ToString();
                txt_Specialty.Text = row.Cells["Especialidad"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txt_Fullname.Clear();
            txt_DNI.Clear();
            txt_Adress.Clear();
            txt_Tel.Clear();
            txt_Email.Clear();
            txt_Specialty.Clear();
        }

        private void RefreshTeacherGrid()
        {
            try
            {
                dtg_Teacher.Rows.Clear();
                List<Teacher> teachers = teacherBLL.GetAllTeachers();

                if (teachers != null && teachers.Count > 0)
                {
                    foreach (Teacher teacher in teachers)
                    {
                        dtg_Teacher.Rows.Add(teacher.ID, teacher.NombreCompleto, teacher.Identificacion, teacher.Direccion, teacher.TelefonoContacto, teacher.CorreoElectronico, teacher.Especialidad);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron docentes en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los docentes: " + ex.Message);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}