using BLL;
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

namespace Gestión_de_Notas
{
    public partial class FormPeriods : Form
    {
        private readonly PeriodBLL periodBLL;
        private readonly SchoolYearBLL schoolYearBLL;

        public FormPeriods()
        {
            InitializeComponent();
            string connectionString = "Data Source=sql.hmdevs.com; Initial Catalog=SantiagoDB; User ID=santiagohernandez; Password=Holamundo123*";
            periodBLL = new PeriodBLL(connectionString);
            schoolYearBLL = new SchoolYearBLL(connectionString);
            LoadData();
        }

        private void LoadData()
        {
            dtg_Periods.DataSource = periodBLL.GetAllPeriodosEscolares();

            dtg_Periods.Columns["AnoEscolarID"].Visible = false;

            dtg_Periods.Columns["Ano"].HeaderText = "Año Escolar";
            dtg_Periods.Columns["FechaInicio"].HeaderText = "Fecha de Inicio";
            dtg_Periods.Columns["FechaFin"].HeaderText = "Fecha de Fin";
            dtg_Periods.Columns["NombrePeriodo"].HeaderText = "Periodo";

            dtg_SchoolYear.DataSource = schoolYearBLL.GetAllSchoolYears();

            dtg_SchoolYear.Columns["Ano"].HeaderText = "Año Escolar";
            dtg_SchoolYear.Columns["FechadeInicio"].HeaderText = "Fecha de Inicio";
            dtg_SchoolYear.Columns["FechadeFin"].HeaderText = "Fecha de Fin";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                var anoEscolar = txt_Year.Text;
                var nombrePeriodo = txt_Period.Text;
                var fechaInicio = dtp_FechaInicio.Value;
                var fechaFin = dtp_FechaFin.Value;

                if (string.IsNullOrWhiteSpace(anoEscolar))
                {
                    MessageBox.Show("El campo 'Año Escolar' no puede estar vacío.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(nombrePeriodo))
                {
                    MessageBox.Show("El campo 'Nombre del Periodo' no puede estar vacío.");
                    return;
                }

                if (fechaInicio >= fechaFin)
                {
                    MessageBox.Show("La fecha de inicio debe ser anterior a la fecha de fin.");
                    return;
                }

                // Obtener el ID del año escolar
                var schoolYear = schoolYearBLL.GetSchoolYearByName(anoEscolar);
                if (schoolYear == null)
                {
                    MessageBox.Show("El año escolar especificado no existe.");
                    return;
                }

                // Validar duplicados
                var existingPeriodos = periodBLL.GetAllPeriodosEscolares();
                if (existingPeriodos.Any(p => p.AnoEscolarID == schoolYear.ID && p.NombrePeriodo == nombrePeriodo))
                {
                    MessageBox.Show("El periodo escolar especificado ya existe para este año.");
                    return;
                }

                var periodo = new Period
                {
                    AnoEscolarID = schoolYear.ID,
                    NombrePeriodo = nombrePeriodo,
                    FechaInicio = fechaInicio,
                    FechaFin = fechaFin
                };

                periodBLL.AddPeriodoEscolar(periodo);
                LoadData();
                MessageBox.Show("Periodo escolar agregado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el periodo escolar: " + ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                var nombrePeriodo = txt_Period.Text;
                var anoEscolar = txt_Year.Text;
                var fechaInicio = dtp_FechaInicio.Value;
                var fechaFin = dtp_FechaFin.Value;

                if (string.IsNullOrWhiteSpace(anoEscolar))
                {
                    MessageBox.Show("El campo 'Año Escolar' no puede estar vacío.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(nombrePeriodo))
                {
                    MessageBox.Show("El campo 'Nombre del Periodo' no puede estar vacío.");
                    return;
                }

                if (fechaInicio >= fechaFin)
                {
                    MessageBox.Show("La fecha de inicio debe ser anterior a la fecha de fin.");
                    return;
                }

                // Obtener el ID del año escolar
                var schoolYear = schoolYearBLL.GetSchoolYearByName(anoEscolar);
                if (schoolYear == null)
                {
                    MessageBox.Show("El año escolar especificado no existe.");
                    return;
                }

                // Obtener el periodo existente
                var existingPeriodos = periodBLL.GetAllPeriodosEscolares();

                // Log de depuración
                Console.WriteLine("Lista de periodos existentes:");
                foreach (var p in existingPeriodos)
                {
                    Console.WriteLine($"ID: {p.ID}, AnoEscolarID: {p.AnoEscolarID}, NombrePeriodo: {p.NombrePeriodo}");
                }

                var periodo = existingPeriodos.FirstOrDefault(p => p.AnoEscolarID == schoolYear.ID && string.Equals(p.NombrePeriodo, nombrePeriodo, StringComparison.OrdinalIgnoreCase));
                if (periodo == null)
                {
                    MessageBox.Show("El periodo escolar especificado no existe.");
                    return;
                }

                periodo.FechaInicio = fechaInicio;
                periodo.FechaFin = fechaFin;

                periodBLL.UpdatePeriodoEscolar(periodo);
                LoadData();
                MessageBox.Show("Periodo escolar actualizado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el periodo escolar: " + ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var nombrePeriodo = txt_Period.Text.Trim();
                var anoEscolar = txt_Year.Text.Trim();

                if (string.IsNullOrWhiteSpace(anoEscolar) || string.IsNullOrWhiteSpace(nombrePeriodo))
                {
                    MessageBox.Show("Por favor, seleccione un periodo escolar para eliminar.");
                    return;
                }

                // Obtener el ID del año escolar
                var schoolYear = schoolYearBLL.GetSchoolYearByName(anoEscolar);
                if (schoolYear == null)
                {
                    MessageBox.Show("El año escolar especificado no existe.");
                    return;
                }

                // Obtener el periodo existente
                var existingPeriodos = periodBLL.GetAllPeriodosEscolares();

                // Log de depuración
                Console.WriteLine("Lista de periodos existentes:");
                foreach (var p in existingPeriodos)
                {
                    Console.WriteLine($"ID: {p.ID}, AnoEscolarID: {p.AnoEscolarID}, NombrePeriodo: {p.NombrePeriodo}");
                }

                var periodo = existingPeriodos.FirstOrDefault(p => p.AnoEscolarID == schoolYear.ID && string.Equals(p.NombrePeriodo, nombrePeriodo, StringComparison.OrdinalIgnoreCase));
                if (periodo == null)
                {
                    MessageBox.Show("El periodo escolar especificado no existe.");
                    return;
                }

                // Confirmar eliminación
                var result = MessageBox.Show("¿Está seguro de que desea eliminar este periodo escolar?", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    periodBLL.DeletePeriodoEscolar(periodo.ID);
                    LoadData();
                    MessageBox.Show("Periodo escolar eliminado exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el periodo escolar: " + ex.Message);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}