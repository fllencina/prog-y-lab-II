using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Equipo
    {
        public static short cantidadDeJugadores;
        public List<Jugador> jugadores;
        public string nombre;

        //constructor
        private Equipo()
        {
            List<Jugador> jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre) : this()
        {
            Equipo.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        //sobrecarga
        public static bool operator +(Equipo e, Jugador j)
        {
            e = new Equipo();

            foreach (Jugador k in e.jugadores)
            {
                if (k == j)
                {
                    return true;
                }

                e.jugadores.Add(j);
                return true;

            }

            return false;
        }

    }
}
