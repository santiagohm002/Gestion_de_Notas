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
        private readonly string connectionString = "Data Source= sql.holamundodevs.com; Initial Catalog= Santiago_DB ;User ID= santiagohernandez ;Password= Holamundo123*";
        public FormStudent()
        {
            InitializeComponent();
            studentBLL = new StudentBLL(connectionString);
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            // Validar que el número de identificación no esté duplicado
            int identification;
            if (!int.TryParse(txt_DNI.Text, out identification))
            {
                MessageBox.Show("El número de identificación debe ser un valor numérico.");
                return;
            }

            if (studentBLL.IsIdentificationDuplicate(identification))
            {
                MessageBox.Show("Error al agregar estudiante. El número de identificación ya está registrado.");
                return;
            }

            // Validar el formato del correo electrónico
            if (!IsValidEmail(txt_Email.Text))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.");
                return;
            }

            // Validar que el número de contacto empiece con 3 y tenga 10 dígitos
            if (!txt_Tel.Text.StartsWith("3") || txt_Tel.Text.Length != 10)
            {
                MessageBox.Show("Error al agregar estudiante. El número de contacto es inválido.");
                return;
            }

            // Crear el objeto Estudiante con los datos del formulario
            Student student = new Student
            {
                Identificacion = identification,
                NombreCompleto = txt_Fullname.Text,
                FechaNacimiento = dt_Birthdate.Value,
                Direccion = txt_Adress.Text,
                TelefonoContacto = txt_Tel.Text,
                CorreoElectronico = txt_Email.Text
            };

            // Agregar el estudiante a la base de datos
            studentBLL.AddStudent(student);

            // Limpiar los campos del formulario
            ClearFields();

            // Actualizar la tabla de estudiantes
            RefreshStudentGrid();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {

            // Validar el formato del correo electrónico
            if (!IsValidEmail(txt_Email.Text))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.");
                return;
            }

            // Validar que el número de contacto empiece con 3 y tenga 10 dígitos
            if (!txt_Tel.Text.StartsWith("3") || txt_Tel.Text.Length != 10)
            {
                MessageBox.Show("Error al modificar estudiante. El número de contacto es inválido.");
                return;
            }

            // Crear el objeto Estudiante con los datos del formulario
            Student student = new Student
            {
                Identificacion = Convert.ToInt32(txt_DNI.Text),
                NombreCompleto = txt_Fullname.Text,
                FechaNacimiento = dt_Birthdate.Value,
                Direccion = txt_Adress.Text,
                TelefonoContacto = txt_Tel.Text,
                CorreoElectronico = txt_Email.Text
            };

            // Actualizar el estudiante en la base de datos
            studentBLL.UpdateStudent(student);

            // Limpiar los campos del formulario
            ClearFields();

            // Actualizar la tabla de estudiantes
            RefreshStudentGrid();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            // Verificamos si se ingresó un número de identificación válido
            if (!int.TryParse(txt_DNI.Text, out int identification))
            {
                MessageBox.Show("Por favor ingrese un número de identificación válido.");
                return;
            }

            // Confirmamos con el usuario si realmente desea eliminar el estudiante
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este estudiante?", "Confirmación de eliminación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Eliminamos el estudiante de la base de datos utilizando su número de identificación
                studentBLL.DeleteStudent(identification);

                // Limpiamos los campos del formulario
                ClearFields();

                // Actualizamos la tabla de estudiantes
                RefreshStudentGrid();

                MessageBox.Show("Estudiante eliminado correctamente.");
            }
        }

        private void btn_Consult_Click(object sender, EventArgs e)
        {
            // Verificamos si se ingresó un número de identificación válido
            if (!int.TryParse(txt_DNI.Text, out int identification))
            {
                MessageBox.Show("Por favor ingrese un número de identificación válido.");
                return;
            }

            // Buscamos el estudiante en la base de datos utilizando su número de identificación
            Student student = studentBLL.GetStudentById(identification);

            // Verificamos si se encontró un estudiante con el número de identificación proporcionado
            if (student != null)
            {
                // Mostramos los detalles del estudiante en los campos correspondientes del formulario
                txt_Fullname.Text = student.NombreCompleto;
                dt_Birthdate.Value = student.FechaNacimiento;
                txt_Adress.Text = student.Direccion;
                txt_Tel.Text = student.TelefonoContacto;
                txt_Email.Text = student.CorreoElectronico;

                MessageBox.Show("Estudiante encontrado.");
            }
            else
            {
                MessageBox.Show("No se encontró ningún estudiante con el número de identificación proporcionado.");
            }
        }

        private void ClearFields()
        {
            txt_DNI.Clear();
            txt_Fullname.Clear();
            dt_Birthdate.Value = DateTime.Now;
            txt_Adress.Clear();
            txt_Tel.Clear();
            txt_Email.Clear();
        }

        // Método para actualizar la tabla de estudiantes
        private void RefreshStudentGrid()
        {
            List<Student> students = studentBLL.GetAllStudents();

            // Limpiar el DataGridView antes de agregar nuevos datos
            dtg_Student.Rows.Clear();

            foreach (Student student in students)
            {
                // Calcular la edad del estudiante
                int age = CalculateAge(student.FechaNacimiento);

                // Agregar una nueva fila al DataGridView con los datos del estudiante
                dtg_Student.Rows.Add(student.ID, student.NombreCompleto, student.Identificacion, student.FechaNacimiento, age, student.Direccion, student.TelefonoContacto, student.CorreoElectronico);
            }
        }

        private int CalculateAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;
            if (dateOfBirth > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}