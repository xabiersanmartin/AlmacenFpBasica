using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class Subcategoria : IEquatable<Subcategoria>
    {
        public int codSubCategoria { get; set; }
        public string nombreSubCategoria { get; set; }

        public Subcategoria(int codSubCategoria, string nombreSubCategoria)
        {
            this.codSubCategoria = codSubCategoria;
            this.nombreSubCategoria = nombreSubCategoria;
        }
        public Subcategoria(string nombreSubCategoria)
        {
            this.nombreSubCategoria = nombreSubCategoria;
        }
        public Subcategoria()
        {
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Subcategoria);
        }

        public bool Equals(Subcategoria other)
        {
            return other != null &&
                   codSubCategoria == other.codSubCategoria;
        }

        public override int GetHashCode()
        {
            return 1681949756 + codSubCategoria.GetHashCode();
        }
    }
}
