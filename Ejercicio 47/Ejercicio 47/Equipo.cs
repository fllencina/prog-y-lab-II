using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    abstract class Equipo
    {
        protected string nombre;
        protected DateTime fechaCreacion;

        public Equipo(string nombre,DateTime fecha)
        {
            this.nombre = nombre;
            this.fechaCreacion = fecha;
        }
        public static bool operator == (Equipo e1, Equipo e2)
        {
            if(e1.nombre== e2.nombre && e1.fechaCreacion == e2.fechaCreacion)
            {
                return true;
            }
            return false;

        }
        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public string Ficha()
        {
            StringBuilder ficha = new StringBuilder();
            ficha.AppendFormat("{0} fundado el {1}", this.nombre, this.fechaCreacion);
            return ficha.ToString();
        }
    }
}
