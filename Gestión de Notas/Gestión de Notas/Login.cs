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

            bool isValidUser = userBLL.ValidateUserLogin(username, password);

            if (isValidUser)
            {
                if (userBLL.ValidatePassword(username, password))
                {
                    string userType = userBLL.GetUserType(username);
                    MessageBox.Show($"Ha iniciado sesión correctamente como {userType}.");

                    switch (userType)
                    {
                        case "Administrador":
                            this.Hide();

                            FormPortalAdmin v1 = new FormPortalAdmin();
                            v1.Show();
                            break;
                        case "Estudiante":
                            MessageBox.Show("Bienvenido");
                            break;
                        case "Docente":
                            MessageBox.Show("Bienvenido");
                            break;
                        default:
                            MessageBox.Show("Tipo de usuario no reconocido.");
                            return;
                    }

                    txt_User.Text = "";
                    txt_Pass.Text = "";
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta.");
                    txt_Pass.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
                txt_Pass.Text = "";
            }
        }


        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
