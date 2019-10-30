using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class Adminstrador
    {
        public string nombre { get; set; }
        public string password { get; set; }


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
