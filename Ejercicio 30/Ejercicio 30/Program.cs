using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia c = new Competencia(10, 5);
            AutoF1 a1 = new AutoF1(1, "Ferrari");
            AutoF1 a2 = new AutoF1(2, "Mercedes");
            AutoF1 a3 = new AutoF1(3, "McLaren");
            AutoF1 a4 = new AutoF1(4, "Williams");
            bool retorno;
            retorno = c + a1;
            Console.WriteLine( c.MostrarDatos());
            Console.ReadKey();
            retorno = c + a2;
            Console.WriteLine(c.MostrarDatos());
            Console.ReadKey();
            retorno = c + a3;
            Console.WriteLine(c.MostrarDatos());
            Console.ReadKey();
            retorno = c + a4;
            Console.WriteLine(c.MostrarDatos());
            Console.ReadKey();
            retorno = c + a1;
            Console.WriteLine(c.MostrarDatos());
            Console.ReadKey();

        }
    }
}
