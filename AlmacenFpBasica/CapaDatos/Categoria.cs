using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Categoria : IEquatable<Categoria>
    {
        private int codCategoria { get; set; }
        private string nombre { get; set; }

        public Categoria(int codCategoria, string nombre)
        {
            this.codCategoria = codCategoria;
            this.nombre = nombre;
        }

        public Categoria()
        {
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Categoria);
        }

        public bool Equals(Categoria other)
        {
            return other != null &&
                   codCategoria == other.codCategoria;
        }

        public override int GetHashCode()
        {
            return -540866772 + codCategoria.GetHashCode();
        }
    }
}
