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
    public partial class FormAssignStudent : Form
    {
        private readonly AssignedStudentBLL assignedStudentBLL;
        private readonly StudentBLL studentBLL;
        private readonly RoomBLL roomBLL;

        public FormAssignStudent()
        {
            InitializeComponent();
            string connectionString = "Data Source=108.181.184.38; Initial Catalog=SantiagoDB; User ID=santiagohernandez; Password=Holamundo123*";
            assignedStudentBLL = new AssignedStudentBLL(connectionString);
            studentBLL = new StudentBLL(connectionString);
            roomBLL = new RoomBLL(connectionString);
            InitializeDataGridViews();
            RefreshGrids();
        }

        private void InitializeDataGridViews()
        {
            // Initialize dtg_Room
            dtg_Room.Columns.Clear();
            dtg_Room.Columns.Add("ID", "ID");
            dtg_Room.Columns.Add("NombreSalon", "Nombre del Salón");

            // Initialize dtg_Students
            dtg_Students.Columns.Clear();
            dtg_Students.Columns.Add("ID", "ID");
            dtg_Students.Columns.Add("NombreCompleto", "Nombre Completo");
            dtg_Students.Columns.Add("Identificacion", "Identificación");
            dtg_Students.Columns.Add("Edad", "Edad");

            // Initialize dtg_AssignedStudents
            dtg_AssignedStudents.Columns.Clear();
            dtg_AssignedStudents.Columns.Add("ID", "ID");
            dtg_AssignedStudents.Columns.Add("NombreEstudiante", "Nombre del Estudiante");
            dtg_AssignedStudents.Columns.Add("SalonAsignado", "Salón Asignado");
        }

        private void RefreshGrids()
        {
            RefreshRoomGrid();
            RefreshStudentGrid();
            RefreshAssignedStudentGrid();
        }

        private void RefreshRoomGrid()
        {
            dtg_Room.Rows.Clear();
            List<Room> rooms = roomBLL.GetAllRooms();
            foreach (Room room in rooms)
            {
                dtg_Room.Rows.Add(room.ID, room.NombreSalon);
            }
        }

        private void RefreshStudentGrid()
        {
            dtg_Students.Rows.Clear();
            List<Student> students = studentBLL.GetBasicStudentInfo();
            foreach (Student student in students)
            {
                dtg_Students.Rows.Add(student.ID, student.NombreCompleto, student.Identificacion, student.Edad);
            }
        }

        private void RefreshAssignedStudentGrid()
        {
            dtg_AssignedStudents.Rows.Clear();
            List<AssignedStudent> assignedStudents = assignedStudentBLL.GetAllAssignedStudents();
            foreach (AssignedStudent assignedStudent in assignedStudents)
            {
                dtg_AssignedStudents.Rows.Add(assignedStudent.ID, assignedStudent.NombreEstudiante, assignedStudent.SalonAsignado);
            }
        }

        private void btn_AssignStudent_Click(object sender, EventArgs e)
        {
            string nombreEstudiante = txt_StudentName.Text.Trim();
            string nombreSalon = txt_RoomName.Text.Trim();

            if (string.IsNullOrEmpty(nombreEstudiante) || string.IsNullOrEmpty(nombreSalon))
            {
                MessageBox.Show("Digite el nombre del estudiante y el nombre del salón para asignar.");
                return;
            }

            Student student = studentBLL.GetStudentByName(nombreEstudiante);
            Room room = roomBLL.GetRoomByName(nombreSalon);

            if (student == null)
            {
                MessageBox.Show("El estudiante no está registrado.");
                return;
            }

            if (room == null)
            {
                MessageBox.Show("El salón no está registrado.");
                return;
            }

            try
            {
                assignedStudentBLL.AddAssignedStudent(student.ID, room.ID);
                MessageBox.Show("Estudiante asignado correctamente.");
                RefreshAssignedStudentGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_DeleteAssignment_Click(object sender, EventArgs e)
        {
            string nombreEstudiante = txt_StudentName.Text.Trim();

            if (string.IsNullOrEmpty(nombreEstudiante))
            {
                MessageBox.Show("Digite el nombre del estudiante para eliminar la asignación.");
                return;
            }

            Student student = studentBLL.GetStudentByName(nombreEstudiante);

            if (student == null)
            {
                MessageBox.Show("El estudiante no está registrado.");
                return;
            }

            AssignedStudent assignedStudent = assignedStudentBLL.GetAssignedStudentByStudentID(student.ID);

            if (assignedStudent == null)
            {
                MessageBox.Show("El estudiante no está asignado a ningún salón.");
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta asignación?", "Confirmación de eliminación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                assignedStudentBLL.DeleteAssignedStudent(assignedStudent.ID);
                MessageBox.Show("Asignación eliminada correctamente.");
                RefreshAssignedStudentGrid();
            }
        }

        private void btn_UpdateAssignment_Click(object sender, EventArgs e)
        {
            string nombreEstudiante = txt_StudentName.Text.Trim();
            string nuevoNombreSalon = txt_NewRoomName.Text.Trim();

            if (string.IsNullOrEmpty(nombreEstudiante) || string.IsNullOrEmpty(nuevoNombreSalon))
            {
                MessageBox.Show("Digite el nombre del estudiante y el nuevo nombre del salón para actualizar.");
                return;
            }

            Student student = studentBLL.GetStudentByName(nombreEstudiante);
            Room newRoom = roomBLL.GetRoomByName(nuevoNombreSalon);

            if (student == null)
            {
                MessageBox.Show("El estudiante no está registrado.");
                return;
            }

            if (newRoom == null)
            {
                MessageBox.Show("El nuevo salón no está registrado.");
                return;
            }

            AssignedStudent assignedStudent = assignedStudentBLL.GetAssignedStudentByStudentID(student.ID);

            if (assignedStudent == null)
            {
                MessageBox.Show("El estudiante no está asignado a ningún salón.");
                return;
            }

            assignedStudentBLL.UpdateAssignedStudent(assignedStudent.ID, newRoom.ID);
            MessageBox.Show("Asignación actualizada correctamente.");
            RefreshAssignedStudentGrid();
        }

        private void btn_ViewStudentsInRoom_Click(object sender, EventArgs e)
        {
            string nombreSalon = txt_RoomName.Text.Trim();

            if (string.IsNullOrEmpty(nombreSalon))
            {
                MessageBox.Show("Digite el nombre del salón para ver los estudiantes asignados.");
                return;
            }

            Room room = roomBLL.GetRoomByName(nombreSalon);

            if (room == null)
            {
                MessageBox.Show("El salón no está registrado.");
                return;
            }

            List<AssignedStudent> assignedStudents = assignedStudentBLL.GetAssignedStudentsByRoomID(room.ID);
            dtg_AssignedStudents.Rows.Clear();
            foreach (AssignedStudent assignedStudent in assignedStudents)
            {
                dtg_AssignedStudents.Rows.Add(assignedStudent.ID, assignedStudent.NombreEstudiante, assignedStudent.SalonAsignado);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}