using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_de_Notas
{
    public partial class FormAdmin : Form
    {
        private readonly AdminBLL adminBLL;
        private readonly string connectionString = "Data Source=sql.hmdevs.com; Initial Catalog=SantiagoDB; User ID=santiagohernandez; Password=Holamundo123*";

        public FormAdmin()
        {
            InitializeComponent();
            adminBLL = new AdminBLL(connectionString);
            InitializeDataGridView();
            this.Load += FormTeacher_Load;
        }

        private void InitializeDataGridView()
        {
            dtg_Admin.Columns.Clear();
            dtg_Admin.Columns.Add("ID", "ID");
            dtg_Admin.Columns.Add("NombreCompleto", "Nombre Completo");
            dtg_Admin.Columns.Add("Identificacion", "Identificación");
            dtg_Admin.Columns.Add("Direccion", "Dirección");
            dtg_Admin.Columns.Add("TelefonoContacto", "Teléfono de Contacto");
            dtg_Admin.Columns.Add("CorreoElectronico", "Correo Electrónico");
            dtg_Admin.Columns.Add("Cargo", "Cargo");
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
            if (adminBLL.IsIdentificationDuplicate(txt_DNI.Text))
            {
                MessageBox.Show("Ya existe un administrador con esta identificación.");
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
                MessageBox.Show("Error al agregar Administrador. El número de contacto es inválido.");
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

                var admin = new Admin
                {
                    NombreCompleto = txt_Fullname.Text,
                    Identificacion = txt_DNI.Text,
                    Direccion = txt_Adress.Text,
                    TelefonoContacto = txt_Tel.Text,
                    CorreoElectronico = txt_Email.Text,
                    Cargo = txt_Specialty.Text
                };

                adminBLL.AddAdmin(admin);
                RefreshTeacherGrid();
                ClearFields();
                MessageBox.Show("Administrador agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar administrador: " + ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields()) return;

                var admin = new Admin
                {
                    NombreCompleto = txt_Fullname.Text,
                    Identificacion = txt_DNI.Text,
                    Direccion = txt_Adress.Text,
                    TelefonoContacto = txt_Tel.Text,
                    CorreoElectronico = txt_Email.Text,
                    Cargo = txt_Specialty.Text
                };

                adminBLL.UpdateAdmin(admin);
                RefreshTeacherGrid();
                ClearFields();
                MessageBox.Show("Administrador actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar administrador: " + ex.Message);
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

                string adminId = txt_DNI.Text;
                var result = MessageBox.Show("¿Está seguro de que desea eliminar este administrador?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    adminBLL.DeleteAdmin(adminId);
                    RefreshTeacherGrid();
                    ClearFields();
                    MessageBox.Show("Administrador eliminado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar administrador: " + ex.Message);
            }
        }

        private void dtgTeachers_SelectionChanged(object sender, EventArgs e)
        {
            if (dtg_Admin.SelectedRows.Count > 0)
            {
                var row = dtg_Admin.SelectedRows[0];
                txt_Fullname.Text = row.Cells["NombreCompleto"].Value.ToString();
                txt_DNI.Text = row.Cells["Identificacion"].Value.ToString();
                txt_Adress.Text = row.Cells["Direccion"].Value.ToString();
                txt_Tel.Text = row.Cells["TelefonoContacto"].Value.ToString();
                txt_Email.Text = row.Cells["CorreoElectronico"].Value.ToString();
                txt_Specialty.Text = row.Cells["Cargo"].Value.ToString();
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
                dtg_Admin.Rows.Clear();
                List<Admin> admins = adminBLL.GetAllAdmins();

                if (admins != null && admins.Count > 0)
                {
                    foreach (Admin admin in admins)
                    {
                        dtg_Admin.Rows.Add(admin.ID, admin.NombreCompleto, admin.Identificacion, admin.Direccion, admin.TelefonoContacto, admin.CorreoElectronico, admin.Cargo);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron administrador en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los administrador: " + ex.Message);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
