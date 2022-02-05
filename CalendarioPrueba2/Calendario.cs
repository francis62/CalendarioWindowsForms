using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.IO;

namespace CalendarioPrueba2
{
    public partial class Calendario : Form
    {
        public String usuarioEnSesion = " ";

        public Calendario()
        {
            InitializeComponent();
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login formularioLogin = new Login();
            formularioLogin.Show();
        }

        private void Calendario_Load(object sender, EventArgs e)
        {
            this.labelUsuarioSesionNombre.Text = usuarioEnSesion;  

            for (int contadorMinutos = 0; contadorMinutos <= 95; contadorMinutos++)
            {
                dataGridViewCalendario.Rows.Add();                
            }

            cargarFecha();                                          
        }

        private void cargarFecha()
        {     
            //guardamos la fecha que se selecciono en el MonthCalendar
            DateTime fechaElegida = mostradorDeCalendario.SelectionStart;

            //actualizamos el label para mostrar la fecha seleccionada
            labelFechaSeleccionada.Text = "Fecha seleccionada: " + fechaElegida.ToString("dd/MM/yyyy");
      
            String fecha = fechaElegida.Year.ToString() + fechaElegida.Month.ToString() + fechaElegida.Day.ToString();
                                                        
            //checkeamos si el archivo con ese nombre no existe y accedemos al if
            if (!File.Exists(usuarioEnSesion + "-" + fecha))
            {
                StreamWriter archivo = new StreamWriter(usuarioEnSesion + "-" + fecha);
                DateTime horario = DateTime.Today;

                for (int i = 0; i <= 95; i++)
                {
                    archivo.WriteLine(horario.ToString("HH:mm"));
                    archivo.WriteLine("");
                    horario = horario.AddMinutes(15);
                }

                archivo.Close();
            }

            //
            StreamReader archivo2 = new StreamReader(usuarioEnSesion + "-" + fecha);
            int x = 0;

            while (archivo2.EndOfStream == false)
            {
                string linea1 = archivo2.ReadLine();
                string linea2 = archivo2.ReadLine();

                dataGridViewCalendario.Rows[x].Cells[0].Value = linea1;
                dataGridViewCalendario.Rows[x].Cells[1].Value = linea2;
                x++;
            }

            archivo2.Close();
            
        }

        private void mostradorDeCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            cargarFecha();
        }

        private void dataGridViewCalendario_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DateTime fechaElegida = mostradorDeCalendario.SelectionStart;
            String fecha = fechaElegida.Year.ToString() + fechaElegida.Month.ToString() + fechaElegida.Day.ToString();

            StreamWriter archivo = new StreamWriter(usuarioEnSesion + "-" + fecha);

            for (int i = 0; i < dataGridViewCalendario.Rows.Count; i++)
            {
                String hora;

                hora = dataGridViewCalendario.Rows[i].Cells[0].Value.ToString();

                archivo.WriteLine(hora);

                if (dataGridViewCalendario.Rows[i].Cells[1].Value != null)
                {
                    archivo.WriteLine(dataGridViewCalendario.Rows[i].Cells[1].Value.ToString());
                }
                else
                {
                    archivo.WriteLine("");
                }

            }

            archivo.Close();  
        }
    }       
}