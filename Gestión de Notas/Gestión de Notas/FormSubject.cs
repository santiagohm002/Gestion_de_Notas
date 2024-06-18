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

namespace Gestion_de_Notas
{
    public partial class FormSubject : Form
    {
        private readonly SubjectBLL subjectBLL;
        private readonly TeacherBLL teacherBLL;
        private readonly RoomBLL roomBLL;

        public FormSubject()
        {
            InitializeComponent();

            string connectionString = "Data Source=sql.hmdevs.com; Initial Catalog=SantiagoDB; User ID=santiagohernandez; Password=Holamundo123*";
            teacherBLL = new TeacherBLL(connectionString);
            roomBLL = new RoomBLL(connectionString);
            subjectBLL = new SubjectBLL(connectionString, teacherBLL, roomBLL);

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dtg_Subjects.DataSource = subjectBLL.GetAllSubjectsWithDetails();

                dtg_Subjects.Columns["DocenteEncargadoID"].Visible = false;
                dtg_Subjects.Columns["SalonAsignadoID"].Visible = false;

                dtg_Subjects.Columns["NombreMateria"].HeaderText = "Nombre de la Materia";
                dtg_Subjects.Columns["DocenteEncargado"].HeaderText = "Docente Encargado";
                dtg_Subjects.Columns["SalonAsignado"].HeaderText = "Salón Asignado";

                dtg_Teachers.DataSource = teacherBLL.GetBasicInfoTeachers();

                dtg_Teachers.Columns["TelefonoContacto"].Visible = false;
                dtg_Teachers.Columns["CorreoElectronico"].Visible = false;
                dtg_Teachers.Columns["Direccion"].Visible = false;

                dtg_Teachers.Columns["NombreCompleto"].HeaderText = "Nombre Completo";
                dtg_Teachers.Columns["Identificacion"].HeaderText = "Identificación";

                dtg_Classrooms.DataSource = roomBLL.GetAllRooms();

                dtg_Classrooms.Columns["NombreSalon"].HeaderText = "Nombre del Salón";

                dtg_Classrooms.Columns["IDGrado"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                var subjectName = txt_Subjectname.Text;
                var teacherName = txt_Fullname.Text;
                var roomName = txt_Roomname.Text;

                var teacher = teacherBLL.GetTeacherByName(teacherName);
                var room = roomBLL.GetRoomByName(roomName);

                // Validar si el docente y el salón existen
                if (teacher == null)
                {
                    MessageBox.Show("El docente especificado no existe.");
                    return;
                }

                if (room == null)
                {
                    MessageBox.Show("El salón especificado no existe.");
                    return;
                }

                // Validar si la asignación ya existe
                if (subjectBLL.IsDuplicateAssignment(subjectName, teacher.ID, room.ID))
                {
                    MessageBox.Show("Ya existe una asignación con los mismos detalles.");
                    return;
                }

                var subject = new Subject
                {
                    NombreMateria = subjectName,
                    DocenteEncargadoID = teacher.ID,  // Usar el ID del docente
                    SalonAsignadoID = room.ID  // Usar el ID del salón
                };

                // Validar la materia antes de agregar
                subjectBLL.AddSubject(subject);
                LoadData();
                MessageBox.Show("Materia agregada exitosamente.");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la materia: " + ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                var subjectName = txt_Subjectname.Text;
                var newTeacherName = txt_Fullname.Text;
                var newRoomName = txt_Roomname.Text;

                var subject = subjectBLL.GetSubjectByName(subjectName);
                if (subject == null)
                {
                    MessageBox.Show("La materia especificada no existe.");
                    return;
                }

                var newTeacher = teacherBLL.GetTeacherByName(newTeacherName);
                var newRoom = roomBLL.GetRoomByName(newRoomName);

                if (newTeacher == null || newRoom == null)
                {
                    MessageBox.Show("El docente o el salón especificado no existe.");
                    return;
                }

                subject.DocenteEncargadoID = newTeacher.ID;
                subject.SalonAsignadoID = newRoom.ID;

                subjectBLL.UpdateSubject(subject);
                LoadData();
                MessageBox.Show("Materia actualizada exitosamente.");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la materia: " + ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var subjectName = txt_Subjectname.Text;

                var subject = subjectBLL.GetSubjectByName(subjectName);
                if (subject == null)
                {
                    MessageBox.Show("La materia especificada no existe.");
                    return;
                }

                var result = MessageBox.Show("¿Está seguro de que desea eliminar esta materia?", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    subjectBLL.DeleteSubject(subject.ID);
                    LoadData();
                    MessageBox.Show("Materia eliminada exitosamente.");
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la materia: " + ex.Message);
            }
        }
        private void btn_SearchBySpecialty_Click(object sender, EventArgs e)
        {
            try
            {
                string subjectName = txt_Subjectname.Text;
                if (string.IsNullOrEmpty(subjectName))
                {
                    MessageBox.Show("Por favor ingrese el nombre de la especialidad.");
                    return;
                }

                var teachers = teacherBLL.GetTeachersBySpecialty(subjectName);
                if (teachers == null || teachers.Count == 0)
                {
                    MessageBox.Show("No se encontraron docentes con esa especialidad.");
                    return;
                }

                dtg_Teachers.DataSource = teachers;
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar docentes por especialidad: " + ex.Message);
            }
        }

        private void btn_SearchByRoom_Click(object sender, EventArgs e)
        {
            try
            {
                string roomName = txt_Roomname.Text;
                if (string.IsNullOrEmpty(roomName))
                {
                    MessageBox.Show("Por favor ingrese el nombre del salón.");
                    return;
                }

                var subjects = roomBLL.GetSubjectsByRoom(roomName);
                if (subjects == null || subjects.Count == 0)
                {
                    MessageBox.Show("No se encontraron asignaciones para ese salón.");
                    return;
                }

                dtg_Subjects.DataSource = subjects;
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar asignaciones por salón: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txt_Fullname.Clear();
            txt_Roomname.Clear();
            txt_Subjectname.Clear();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}