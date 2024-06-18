using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace Gestion_de_Notas
{
    public partial class FormSchoolYear : Form
    {
        private readonly SchoolYearBLL schoolYearBLL;

        public FormSchoolYear()
        {
            InitializeComponent();

            string connectionString = "Data Source=sql.hmdevs.com; Initial Catalog=SantiagoDB; User ID=santiagohernandez; Password=Holamundo123*";
            schoolYearBLL = new SchoolYearBLL(connectionString);

            LoadData();
        }

        private void LoadData()
        {
            dtg_SchoolYears.DataSource = schoolYearBLL.GetAllSchoolYears();

            dtg_SchoolYears.Columns["Ano"].HeaderText = "Año Escolar";
            dtg_SchoolYears.Columns["FechadeInicio"].HeaderText = "Fecha de Inicio";
            dtg_SchoolYears.Columns["FechadeFin"].HeaderText = "Fecha de Fin";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                var año = txt_Year.Text;
                var fechadeInicio = dtp_FechadeInicio.Value;
                var fechadeFin = dtp_FechadeFin.Value;

                if (string.IsNullOrWhiteSpace(año))
                {
                    MessageBox.Show("El campo 'Año' no puede estar vacío.");
                    return;
                }

                if (fechadeInicio >= fechadeFin)
                {
                    MessageBox.Show("La fecha de inicio debe ser anterior a la fecha de fin.");
                    return;
                }

                // Validar duplicados
                var existingSchoolYears = schoolYearBLL.GetAllSchoolYears();
                if (existingSchoolYears.Any(s => s.Ano == año))
                {
                    MessageBox.Show("El año escolar especificado ya existe.");
                    return;
                }

                var schoolYear = new SchoolYear
                {
                    Ano = año,
                    FechadeInicio = fechadeInicio,
                    FechadeFin = fechadeFin
                };

                schoolYearBLL.AddSchoolYear(schoolYear);
                LoadData();
                MessageBox.Show("Año escolar agregado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el año escolar: " + ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                var año = txt_Year.Text;
                var fechadeInicio = dtp_FechadeInicio.Value;
                var fechadeFin = dtp_FechadeFin.Value;

                if (string.IsNullOrWhiteSpace(año))
                {
                    MessageBox.Show("El campo 'Año' no puede estar vacío.");
                    return;
                }

                if (fechadeInicio >= fechadeFin)
                {
                    MessageBox.Show("La fecha de inicio debe ser anterior a la fecha de fin.");
                    return;
                }

                // Buscar el año escolar existente
                var existingSchoolYears = schoolYearBLL.GetAllSchoolYears();
                var schoolYear = existingSchoolYears.FirstOrDefault(s => s.Ano == año);

                if (schoolYear == null)
                {
                    MessageBox.Show("El año escolar especificado no existe.");
                    return;
                }

                // Validar duplicados
                var duplicateSchoolYear = existingSchoolYears.FirstOrDefault(s => s.Ano == año && s.ID != schoolYear.ID);
                if (duplicateSchoolYear != null)
                {
                    MessageBox.Show("El año escolar especificado ya existe.");
                    return;
                }

                // Actualizar los detalles
                schoolYear.FechadeInicio = fechadeInicio;
                schoolYear.FechadeFin = fechadeFin;

                schoolYearBLL.UpdateSchoolYear(schoolYear);
                LoadData();
                MessageBox.Show("Año escolar actualizado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el año escolar: " + ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var año = txt_Year.Text;

                // Buscar el año escolar existente
                var existingSchoolYears = schoolYearBLL.GetAllSchoolYears();
                var schoolYear = existingSchoolYears.FirstOrDefault(s => s.Ano == año);

                if (schoolYear == null)
                {
                    MessageBox.Show("El año escolar especificado no existe.");
                    return;
                }

                // Confirmar eliminación
                var result = MessageBox.Show("¿Está seguro de que desea eliminar este año escolar?", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    schoolYearBLL.DeleteSchoolYear(schoolYear.ID);
                    LoadData();
                    MessageBox.Show("Año escolar eliminado exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el año escolar: " + ex.Message);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}