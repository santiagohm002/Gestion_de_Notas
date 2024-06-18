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
        private readonly string connectionString = "Data Source=sql.hmdevs.com; Initial Catalog=SantiagoDB; User ID=santiagohernandez; Password=Holamundo123*";
        public FormStudent()
        {
            InitializeComponent();
            studentBLL = new StudentBLL(connectionString);
            InitializeDataGridView();
            this.Load += FormStudent_Load;
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            // Llama al método para actualizar el DataGridView con los estudiantes
            RefreshStudentGrid();
        }

        private void InitializeDataGridView()
        {
            // Limpia las columnas existentes (si las hay)
            dtg_Student.Columns.Clear();

            // Define las columnas del DataGridView
            dtg_Student.Columns.Add("ID", "ID");
            dtg_Student.Columns.Add("NombreCompleto", "Nombre Completo");
            dtg_Student.Columns.Add("Identificacion", "Identificación");
            dtg_Student.Columns.Add("FechaNacimiento", "Fecha de Nacimiento");
            dtg_Student.Columns.Add("Edad", "Edad");
            dtg_Student.Columns.Add("Direccion", "Dirección");
            dtg_Student.Columns.Add("TelefonoContacto", "Teléfono de Contacto");
            dtg_Student.Columns.Add("CorreoElectronico", "Correo Electrónico");
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
            try
            {
                // Limpia las filas existentes
                dtg_Student.Rows.Clear();

                // Obtén todos los estudiantes
                List<Student> students = studentBLL.GetAllStudents();

                // Verifica si se obtuvieron datos de la base de datos
                if (students != null && students.Count > 0)
                {
                    // Agrega cada estudiante como una fila en el DataGridView
                    foreach (Student student in students)
                    {
                        // Calcula la edad del estudiante
                        int age = CalculateAge(student.FechaNacimiento);

                        // Formatea la fecha como una cadena corta
                        string shortDate = student.FechaNacimiento.ToShortDateString();

                        // Agrega el estudiante como una fila en el DataGridView, incluyendo la edad y la fecha formateada
                        dtg_Student.Rows.Add(student.ID, student.NombreCompleto, student.Identificacion, shortDate, age, student.Direccion, student.TelefonoContacto, student.CorreoElectronico);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron estudiantes en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los estudiantes: " + ex.Message);
            }
        }

        // Método para calcular la edad a partir de la fecha de nacimiento
        private int CalculateAge(DateTime birthdate)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - birthdate.Year;
            if (now < birthdate.AddYears(age))
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