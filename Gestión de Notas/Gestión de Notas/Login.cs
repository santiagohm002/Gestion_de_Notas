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
    public partial class Login : Form
    {
        private string connectionString;

        public Login(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            string username = txt_User.Text;
            string password = txt_Pass.Text;

            UserBLL userBLL = new UserBLL(connectionString);
            int userId = userBLL.ValidateUserLogin(username, password);

            if (userId != -1)
            {
                MessageBox.Show("Inicio de sesión exitoso. Usuario ID: " + userId);
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}