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
        }
        private void btn_Student_Click(object sender, EventArgs e)
        {
            openChildform(new FormStudent());
        }
        private void btn_Teacher_Click(object sender, EventArgs e)
        {
            openChildform(new FormTeacher());
        }
        private void btn_Period_Click(object sender, EventArgs e)
        {

        }
        private void btn_Notes_Click(object sender, EventArgs e)
        {
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
