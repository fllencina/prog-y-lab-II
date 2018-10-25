using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia com = new Competencia(5, 10, TipoCompetencia.MotoCross);
            AutoF1 a = new AutoF1(0, "lala");
            AutoF1 b = new AutoF1(1, "lala");
            AutoF1 c = new AutoF1(2, "lala");
            AutoF1 d = new AutoF1(4, "lala");
            AutoF1 e = new AutoF1(4, "lala");
            AutoF1 f = new AutoF1(5, "lala");
            AutoF1 g = new AutoF1(6, "lala");
            MotoCross ma = new MotoCross(1, "esa");

            try
            {
                
            }
            catch (CompetenciaNoDisponibleException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //Console.WriteLine(com.MostrarDatos());
            Console.ReadKey();
        }
    }
}
