using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CalendarioPrueba2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            Boolean loginExitoso = false;

            try
            {
                if (String.IsNullOrEmpty(textBoxUsuario.Text) && String.IsNullOrEmpty(textBoxContraseña.Text))
                {
                    throw new ExcepcionSignInSignUp();
                }
                else
                {
                    using (StreamReader reader = new StreamReader(Application.StartupPath + "\\Users\\" + "usuarios.txt"))
                    {
                        string line;

                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] data = line.Split(';');

                            if (data[0] == textBoxUsuario.Text.Trim() && data[1] == textBoxContraseña.Text.Trim())
                            {
                                Usuario usuarioPorIngresar = new Usuario();
                                usuarioPorIngresar.calendarioDeUsuario = new Calendario();
                                usuarioPorIngresar.calendarioDeUsuario.usuarioEnSesion = this.textBoxUsuario.Text.Trim();

                                this.Hide();

                                usuarioPorIngresar.calendarioDeUsuario.Show();
                                loginExitoso = true;
                                break;
                            }
                            else
                            {
                                loginExitoso = false;
                            }
                        }
                    }

                    if (loginExitoso == false)
                    {                                                                               
                        throw new ExcepcionSignInSignUp();
                    }
                }
            }
            catch (Exception ExcepcionSignInSignUp)
            {
                MessageBox.Show("Usuario o contraseña ingresados de manera incorrecta, por favor ingrese un usuario y contraseña validos");
            }
        }

        private void buttonOcultarContraseña_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxContraseña.PasswordChar == '\0')
            {
                buttonVerContraseña.BringToFront();
                textBoxContraseña.PasswordChar = '*';
            }
        }

        private void buttonVerContraseña_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxContraseña.PasswordChar == '*')
            {
                buttonOcultarContraseña.BringToFront();
                textBoxContraseña.PasswordChar = '\0';
            }
        }

        private void buttonRegistrarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarUsuario formularioNuevoUsuario = new RegistrarUsuario();
            formularioNuevoUsuario.Show();
         }
    }
}
