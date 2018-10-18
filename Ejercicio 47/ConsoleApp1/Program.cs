using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaBasquet = new DateTime(2018,10,20);
            DateTime fechaFutbol = new DateTime(2018, 10, 15);
            Torneo<> TorneoBasquet = new Torneo<>("Torneo de basquet");
            Torneo<> TorneoFutbol = new Torneo<>("Torneo de Futbol");

            EquipoBasquet basquet = new EquipoBasquet("Basquet1", fechaBasquet);
            EquipoFutbol futbol = new EquipoFutbol("Futbol1", fechaFutbol);
            EquipoBasquet basquet2 = new EquipoBasquet("Basquet2", fechaBasquet);
            EquipoFutbol futbol2 = new EquipoFutbol("Futbol2", fechaFutbol);
            EquipoBasquet basquet3 = new EquipoBasquet("Basquet3", fechaBasquet);
            EquipoFutbol futbol3 = new EquipoFutbol("Futbol3", fechaFutbol);

            TorneoBasquet += basquet;
            TorneoBasquet += basquet2;
            TorneoBasquet += basquet3;
            TorneoBasquet += basquet;

            TorneoBasquet += futbol;
            TorneoBasquet += futbol2;
            TorneoBasquet += futbol3;
            TorneoBasquet += futbol;

            TorneoFutbol += basquet;
            TorneoFutbol += basquet2;
            TorneoFutbol += basquet3;
            TorneoFutbol += basquet3;

            TorneoFutbol += futbol;
            TorneoFutbol += futbol2;
            TorneoFutbol += futbol3;
            TorneoFutbol += futbol3;

            TorneoBasquet.Mostrar();
            Console.ReadKey();
            TorneoFutbol.Mostrar();
            Console.ReadKey();

            


        }
    }
}
