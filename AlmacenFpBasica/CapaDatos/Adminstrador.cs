using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class Adminstrador : IEquatable<Adminstrador>
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

        public override bool Equals(object obj)
        {
            return obj is Adminstrador adminstrador &&
                   nombre.ToUpper() == adminstrador.nombre.ToUpper() &&
                   password == adminstrador.password;
        }

        public override int GetHashCode()
        {
            var hashCode = -686875592;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nombre);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(password);
            return hashCode;
        }

        public bool Equals(Adminstrador other)
        {
            throw new NotImplementedException(); // TODO Esto provooca un error de ejecución
        }
    }
}
