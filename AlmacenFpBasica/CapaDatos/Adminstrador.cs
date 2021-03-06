﻿using System;
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
            return Equals(obj as Adminstrador);
        }

        public bool Equals(Adminstrador other)
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
