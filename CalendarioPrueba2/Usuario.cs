using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioPrueba2
{
    class Usuario : Cliente
    {
        private String nombreDeUsuario;
        private String contraseñaDeUsuario;
        public Calendario calendarioDeUsuario;

        public string NombreDeUsuario { get => nombreDeUsuario; set => nombreDeUsuario = value; }
        public string ContraseñaDeUsuario { get => contraseñaDeUsuario; set => contraseñaDeUsuario = value; }
    }
}
