using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    class Torneo<T> where T : Equipo
    {
        List<T> equipos;
        string nombre;

        public Torneo(string nombre)
        {
            equipos = new List<T>();
            this.nombre = nombre;
        }
        public static bool operator ==(Torneo<T> a, Equipo e)
        {
            foreach (Equipo e2 in a.equipos)
            {
                if (e == e2)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Torneo<T> a, Equipo e)
        {
            return !(a == e);
        }
        public static Torneo<T> operator +(Torneo<T> a, T e)
        {
            if(a!=e)
            {
                a.equipos.Add(e);
            }
            return a;
        }
        public string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendFormat("Nombre {0} \n\t", this.nombre);
            foreach(Equipo e in equipos)
            {
                mostrar.AppendFormat("{0}\n\t", e.Ficha());
            }

        }
    }
}
