using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioPrueba2
{
    class ExcepcionSignInSignUp : Exception
    {
        public ExcepcionSignInSignUp()
        {
        }

        public ExcepcionSignInSignUp(string message) : base(message)
        {
        }
    }
}
