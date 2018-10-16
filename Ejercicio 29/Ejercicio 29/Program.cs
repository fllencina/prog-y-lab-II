using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo nuevoEquipo = new Equipo(10, "miEquipo");
            Jugador j1 = new Jugador(34984075, "fernanda", 1, 20);
            Jugador j2 = new Jugador(34984076, "pedro", 5, 1);
            Jugador j3 = new Jugador(34984077, "felipe", 3, 12);

            Console.WriteLine(j1.MostrarDatos());
            Console.WriteLine(j2.MostrarDatos());
            Console.WriteLine(j3.MostrarDatos());
            Console.ReadKey();

            bool retrno = nuevoEquipo + j1;

            foreach (Jugador j in nuevoEquipo.jugadores)
            {
                Console.WriteLine(j.MostrarDatos());
            }

            Console.ReadKey();


        }
    }
}
