using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    public class Torneo<T> where T : Equipo
    {
        List<T> equipos;
        string nombre;

        public Torneo(string nombre)
        {
            equipos = new List<T>();
            this.nombre = nombre;
        }
        public static bool operator ==(Torneo<T> a, T e)
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
        public static bool operator !=(Torneo<T> a, T e)
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
            return mostrar.ToString();

        }
        private string CalcularPartido(T equipo1, T equipo2)
        {
            int resultado1;
            int resultado2;
           
            Random rd = new Random();
            resultado1= rd.Next(0, 20);
            resultado2 = rd.Next(0, 20);

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} {1} - {2} {3}", equipo1.nombre, resultado1, equipo2.nombre, resultado2);
            return sb.ToString();
        }
        public string JugarPartido(T equipo1, T equipo2)
        {
            return CalcularPartido(equipo1, equipo2);
        }
    }
}
