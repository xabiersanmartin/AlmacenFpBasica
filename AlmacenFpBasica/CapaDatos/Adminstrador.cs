using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class Adminstrador
    {
        private string nombre { get; set; }
        private string password { get; set; }


        public Adminstrador(string nombre, string password)
        {
            this.nombre = nombre;
            this.password = password;
        }

        public Adminstrador()
        {
        }


    }
}
