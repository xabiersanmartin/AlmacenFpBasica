using CapaAcceso;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaGestion
{
    public class Gestor
    {
        Acceso nuevoacces = new Acceso();

        string mensaje { get; set; }

        public bool IniciarSesion(Adminstrador admin, out string mensaje)
        {
            return nuevoacces.IniciarSesion(admin, out mensaje);
        }
        public string ModificarPassAdmin(string nuevaPass)
        {
            return nuevoacces.ModificarPassAdmin(nuevaPass);
        }

        public List<Tipo> CargarTipos(out string mensaje)
        {
            return nuevoacces.CargarTipos(out mensaje);
        }
    }
}
