using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_32
{
    public class Equipo
    {
        public static short cantidadDeJugadores;
        public List<Jugador> jugadores;
        public string nombre;

        //constructor
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre) : this()
        {
            Equipo.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        //sobrecarga
        public static bool operator +(Equipo e, Jugador j)
        {
            if (e.jugadores.Count == 0)
            {
                e.jugadores.Add(j);
            }
            else
            {
                foreach (Jugador k in e.jugadores)
                {
                    if (k == j)
                    {
                        return false;
                    }
                    e.jugadores.Add(j);
                    return true;
                }
            }
            return false;
        }
    }
}
