﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class Empresa : IEquatable<Empresa>
    {
        private string nombre { get; set; }
        private string logo { get; set; }

        public Empresa(string nombre, string logo)
        {
            this.nombre = nombre;
            this.logo = logo;
        }

        public Empresa()
        {
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Empresa);
        }

        public bool Equals(Empresa other)
        {
            return other != null &&
                   nombre == other.nombre;
        }

        public override int GetHashCode()
        {
            return -1597784800 + EqualityComparer<string>.Default.GetHashCode(nombre);
        }
    }
}
