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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panel_Submenu_Student.Visible = false;
            panel_Submenu_Teacher.Visible = false;
            panel_Submenu_Grades.Visible = false;
            panel_Submenu_Period.Visible = false;
            panel_Submenu_Subject.Visible = false;
            panel_Submenu_User.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panel_Submenu_Student.Visible == true)
                panel_Submenu_Student.Visible = false;
            if (panel_Submenu_Teacher.Visible == true)
                panel_Submenu_Teacher.Visible = false;
            if (panel_Submenu_Grades.Visible == true)
                panel_Submenu_Grades.Visible = false;
            if (panel_Submenu_Period.Visible == true)
                panel_Submenu_Period.Visible = false;
            if (panel_Submenu_Subject.Visible == true)
                panel_Submenu_Subject.Visible = false;
            if (panel_Submenu_User.Visible == true)
                panel_Submenu_User.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
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
            showSubMenu(panel_Submenu_Student);
        }

        private void btn_ConsultStud_Click(object sender, EventArgs e)
        {
            //Codigo
            hideSubMenu();
        }

        private void btn_UpListStud_Click(object sender, EventArgs e)
        {
            //Codigo
            hideSubMenu();
        }

        private void btn_EditStud_Click(object sender, EventArgs e)
        {
            //Codigo
            hideSubMenu();
        }

        private void btn_Teacher_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_Submenu_Teacher);
        }

        private void btn_ConsultTeach_Click(object sender, EventArgs e)
        {
            //Codigo
            hideSubMenu();
        }

        private void btn_UpListTeach_Click(object sender, EventArgs e)
        {
            //Codigo
            hideSubMenu();
        }

        private void btn_EditTeach_Click(object sender, EventArgs e)
        {
            //Codigo
            hideSubMenu();
        }

        private void btn_Grades_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_Submenu_Grades);
        }

        private void btn_ConsultRoom_Click(object sender, EventArgs e)
        {
            //Codigo
            hideSubMenu();
        }

        private void btn_EditListRoom_Click(object sender, EventArgs e)
        {
            //Codigo
            hideSubMenu();
        }

        private void btn_Period_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_Submenu_Period);
        }

        private void btn_UpPeriod_Click(object sender, EventArgs e)
        {
            //Codigo
            hideSubMenu();
        }

        private void btn_Subjects_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_Submenu_Subject);
        }

        private void btn_EditSubject_Click(object sender, EventArgs e)
        {
            //Codigo
            hideSubMenu();
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_Submenu_User);
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            //Codigo
            hideSubMenu();
        }

        private void btn_Profiel_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {

        }
    }
}
