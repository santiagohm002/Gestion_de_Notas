using Gestion_de_Notas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_de_Notas
{
    public partial class FormPortalAdmin : Form
    {
        public FormPortalAdmin()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelStudentSubmenu.Visible = false;
            panelTeacherSubmenu.Visible = false;
            panelAdminSubmenu.Visible = false;
            panelGradesSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelStudentSubmenu.Visible == true)
                panelStudentSubmenu.Visible = false;
            if (panelTeacherSubmenu.Visible == true)
                panelTeacherSubmenu.Visible=false;
            if (panelAdminSubmenu.Visible == true)
                panelAdminSubmenu.Visible = false;
            if (panelGradesSubmenu.Visible == true)
                panelGradesSubmenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btn_Student_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStudentSubmenu);
        }
        private void btn_RegistStud_Click(object sender, EventArgs e)
        {
            openChildform(new FormStudent());
            hideSubMenu();
        }

        private void btn_AssigStud_Click(object sender, EventArgs e)
        {
            openChildform(new FormAssignStudent());
            hideSubMenu();
        }

        private void btn_GrafRoom_Click(object sender, EventArgs e)
        {
            //openChildform(new FormGrafRoom());
            hideSubMenu();
        }

        private void btn_GrafSub_Click(object sender, EventArgs e)
        {
            //openChildform(new FormGrafSub());
            hideSubMenu();
        }

        private void btn_Teacher_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTeacherSubmenu);
        }

        private void btn_RegistTeach_Click(object sender, EventArgs e)
        {
            openChildform(new FormTeacher());
            hideSubMenu();
        }

        private void btn_AssigTeach_Click(object sender, EventArgs e)
        {
            openChildform(new FormSubject());
            hideSubMenu();
        }

        private void btn_Grades_Click(object sender, EventArgs e)
        {
            showSubMenu(panelGradesSubmenu);
        }

        private void btn_UpdGrad_Click(object sender, EventArgs e)
        {
            openChildform(new FormGrades());
            hideSubMenu();
        }

        private void btn_UpdRoom_Click(object sender, EventArgs e)
        {
            openChildform(new FormRoom());
            hideSubMenu();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAdminSubmenu);
        }
        private void btn_RegistAdmin_Click(object sender, EventArgs e)
        {
            openChildform(new FormAdmin());
            hideSubMenu();
        }

        private void btn_Periods_Click(object sender, EventArgs e)
        {
            openChildform(new FormPeriods());
            hideSubMenu();
        }

        private void btn_Notes_Click(object sender, EventArgs e)
        {
            //openChildform(new FormNotesAdmin());
            hideSubMenu();
        }

        private void btn_SchoolYear_Click(object sender, EventArgs e)
        {
            openChildform(new FormSchoolYear());
            hideSubMenu();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildform(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildform.Controls.Add(childForm);
            panelChildform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}