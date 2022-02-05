using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace CalendarioPrueba2
{
    public partial class RegistrarUsuario : Form
    {
        private string usuario;
        private string contraseña;

        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void buttonVerContraseña_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxRegContraseña.PasswordChar == '*')
            {
                buttonOcultarContraseña.BringToFront();
                textBoxRegContraseña.PasswordChar = '\0';
            }
        }

        private void buttonOcultarContraseña_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxRegContraseña.PasswordChar == '\0')
            {
                buttonVerContraseña.BringToFront();
                textBoxRegContraseña.PasswordChar = '*';
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            usuario = textBoxRegUsuario.Text;
            contraseña = textBoxRegContraseña.Text;

            string[] informacionUsuario = new string[2];
            informacionUsuario[0] = usuario;
            informacionUsuario[1] = contraseña;

            if (!File.Exists(Application.StartupPath + "\\Users\\" + "usuarios.txt"))
            {
                StreamWriter archivoUsuarios = new StreamWriter(Application.StartupPath + "\\Users\\" + "usuarios.txt");
                archivoUsuarios.WriteLine(informacionUsuario[0] + ";" + informacionUsuario[1]);
                archivoUsuarios.Close();

                MessageBox.Show("Usuario: " + informacionUsuario[0] + " añadido con exito");
            }
            else
            {
                try
                {
                    //VERIFICAMOS SI LOS LABEL DEL REGISTRO ESTAN VACIOS
                    if(String.IsNullOrEmpty(textBoxRegUsuario.Text) || String.IsNullOrEmpty(textBoxRegContraseña.Text))
                    {
                        throw new ExcepcionSignInSignUp("Debe ingresar un usuario y una contraseña para poder registrarse");
                    }
                    else
                    {
                        using (StreamReader archivoParaLeer = new StreamReader(Application.StartupPath + "\\Users\\" + "usuarios.txt"))
                        {
                            string line;
                            string lineAux;

                            while ((line = archivoParaLeer.ReadLine()) != null)
                            {
                                string[] data = line.Split(';');

                                if (data[0] == textBoxRegUsuario.Text.Trim())//SI ES IGUAL SIGNIFICA QUE YA EXISTE UN USUARIO CON EL MISMO NOMBRE
                                {
                                    archivoParaLeer.Close();
                                    throw new ExcepcionSignInSignUp("Este usuario ya existe, registra uno diferente");
                                }
                                else
                                {
                                    archivoParaLeer.Close();

                                    System.Collections.Generic.IEnumerable<String> arrayOfData = File.ReadAllLines(Application.StartupPath + "\\Users\\" + "usuarios.txt");

                                    StreamWriter archivoUsuarios = new StreamWriter(Application.StartupPath + "\\Users\\" + "usuarios.txt");

                                    int length = arrayOfData.Count();

                                    archivoUsuarios.WriteLine(informacionUsuario[0] + ";" + informacionUsuario[1]);

                                    foreach (String elements in arrayOfData)
                                    {
                                        archivoUsuarios.WriteLine(elements);
                                    }

                                    MessageBox.Show("Usuario: " + informacionUsuario[0] + " añadido con exito");

                                    archivoUsuarios.Close();
                                    break;
                                }
                            }
                        }

     
                    }

                }
                catch (Exception ExcepcionSignInSignUp)
                {
                    string message = ExcepcionSignInSignUp.Message;

                    MessageBox.Show(message);
                }     
            }

        }

        private void labelVolverLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login formularioLogin = new Login();
            formularioLogin.Show();
        }

        private void labelVolverLogin_MouseEnter(object sender, EventArgs e)
        {
            labelVolverLogin.ForeColor = Color.White;
        }

        private void labelVolverLogin_MouseLeave(object sender, EventArgs e)
        {
            labelVolverLogin.ForeColor = Color.Black;
        }
    }
}
