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
    public partial class FormRoom : Form
    {
        private readonly RoomBLL roomBLL;
        private readonly GradeBLL gradeBLL;
        private readonly Dictionary<string, string> gradePrefixes = new Dictionary<string, string>
        {
            { "Primero", "1" }, { "Segundo", "2" }, { "Tercero", "3" },
            { "Cuarto", "4" }, { "Quinto", "5" }, { "Sexto", "6" },
            { "Séptimo", "7" }, { "Octavo", "8" }, { "Noveno", "9" },
            { "Décimo", "10" }, { "Once", "11" }
        };

        public FormRoom()
        {
            InitializeComponent();
            string connectionString = "Data Source=108.181.184.38; Initial Catalog=SantiagoDB; User ID=santiagohernandez; Password=Holamundo123*";
            roomBLL = new RoomBLL(connectionString);
            gradeBLL = new GradeBLL(connectionString);
            InitializeDataGridViews();
            RefreshGradeGrid();
            RefreshRoomGrid();
            txt_LevelEd.Enabled = false; // Deshabilitar el campo de texto de nivel educativo

            // Vincular el evento TextChanged al método txt_Grades_TextChanged
            txt_Grades.TextChanged += txt_Grades_TextChanged;
        }

        private void InitializeDataGridViews()
        {
            // Initialize dtg_Grades
            dtg_Grades.Columns.Clear();
            dtg_Grades.Columns.Add("ID", "ID");
            dtg_Grades.Columns.Add("NombreGrado", "Nombre del Grado");
            dtg_Grades.Columns.Add("NivelEducacional", "Nivel Educativo");

            // Initialize dtg_Room
            dtg_Room.Columns.Clear();
            dtg_Room.Columns.Add("ID", "ID");
            dtg_Room.Columns.Add("Nombre", "Nombre del Salón");
            dtg_Room.Columns.Add("Grado", "Grado");
        }

        private void RefreshGradeGrid()
        {
            dtg_Grades.Rows.Clear();
            List<Grade> grades = gradeBLL.GetAllGrades();
            foreach (Grade grade in grades)
            {
                dtg_Grades.Rows.Add(grade.ID, grade.NombreGrado, grade.NivelEducacional);
            }
        }

        private void RefreshRoomGrid()
        {
            dtg_Room.Rows.Clear();
            List<Room> rooms = roomBLL.GetAllRooms();
            foreach (Room room in rooms)
            {
                Grade grade = gradeBLL.GetGradeById(room.IDGrado);
                dtg_Room.Rows.Add(room.ID, room.NombreSalon, grade?.NombreGrado);
            }
        }

        private void txt_Grades_TextChanged(object sender, EventArgs e)
        {
            string nombreGrado = txt_Grades.Text.Trim();

            if (gradePrefixes.ContainsKey(nombreGrado))
            {
                txt_LevelEd.Text = DetermineNivelEducativo(nombreGrado);
            }
            else
            {
                txt_LevelEd.Text = string.Empty;
            }
        }

        private string DetermineNivelEducativo(string nombreGrado)
        {
            if (nombreGrado == "Primero" || nombreGrado == "Segundo" || nombreGrado == "Tercero" ||
                nombreGrado == "Cuarto" || nombreGrado == "Quinto")
            {
                return "Primaria";
            }
            else if (nombreGrado == "Sexto" || nombreGrado == "Séptimo" || nombreGrado == "Octavo" ||
                     nombreGrado == "Noveno" || nombreGrado == "Décimo" || nombreGrado == "Once")
            {
                return "Bachillerato";
            }
            return string.Empty;
        }

        private bool IsValidRoomName(string nombreSalon, string nombreGrado)
        {
            if (!gradePrefixes.ContainsKey(nombreGrado))
            {
                return false;
            }

            string prefix = gradePrefixes[nombreGrado];
            string pattern = $"^{prefix}[A-Za-z]$";
            return System.Text.RegularExpressions.Regex.IsMatch(nombreSalon, pattern);
        }

        private void btn_AddRoom_Click(object sender, EventArgs e)
        {
            string nombreSalon = txt_Room.Text.Trim();
            string nombreGrado = txt_Grades.Text.Trim();

            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(nombreSalon) || string.IsNullOrEmpty(nombreGrado))
            {
                MessageBox.Show("Error, Digite Nombre del Salón y Nombre del Grado para agregar.");
                return;
            }

            // Validar que el nombre del grado sea uno de los permitidos
            if (!gradePrefixes.ContainsKey(nombreGrado))
            {
                MessageBox.Show("Nombre de grado no permitido. Solo se permiten: " + string.Join(", ", gradePrefixes.Keys));
                return;
            }

            // Validar que el nombre del salón sea válido
            if (!IsValidRoomName(nombreSalon, nombreGrado))
            {
                MessageBox.Show($"El nombre del salón debe empezar con {gradePrefixes[nombreGrado]} seguido de una letra.");
                return;
            }

            // Validar que el nombre del salón no exista
            if (roomBLL.GetRoomByName(nombreSalon) != null)
            {
                MessageBox.Show("El nombre del salón ya existe.");
                return;
            }

            Grade grade = gradeBLL.GetGradeByName(nombreGrado);
            if (grade == null)
            {
                MessageBox.Show("El grado especificado no existe.");
                return;
            }

            Room room = new Room { NombreSalon = nombreSalon, IDGrado = grade.ID };
            roomBLL.AddRoom(room);

            RefreshRoomGrid();
            txt_Room.Clear();
            txt_Grades.Clear();
            txt_LevelEd.Clear();
        }

        private void btn_DeleteRoom_Click(object sender, EventArgs e)
        {
            string nombreSalon = txt_Room.Text.Trim();

            // Validar que el campo no esté vacío
            if (string.IsNullOrEmpty(nombreSalon))
            {
                MessageBox.Show("Error, Digite Nombre del Salón para eliminar.");
                return;
            }

            // Verificar si el nombre del salón existe en la base de datos
            Room room = roomBLL.GetRoomByName(nombreSalon);
            if (room == null)
            {
                MessageBox.Show("El salón especificado no existe.");
                return;
            }

            // Confirmar la eliminación
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este salón?", "Confirmación de eliminación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Eliminar el salón
                roomBLL.DeleteRoomByName(nombreSalon);
                RefreshRoomGrid();
                txt_Room.Clear();
                txt_Grades.Clear();
                txt_LevelEd.Clear();
                MessageBox.Show("Salón eliminado correctamente.");
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}