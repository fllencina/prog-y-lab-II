using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_48;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura f1 = new Factura(1);
            Factura f2 = new Factura(2);
            Factura f3 = new Factura(3);
            Factura f4 = new Factura(4);
            Recibo r1 = new Recibo(5);
            Recibo r2 = new Recibo(6);
            Recibo r3 = new Recibo(7);
            Recibo r4 = new Recibo(8);

            Contabilidad<Factura,Recibo> contabilidad = new Contabilidad<Factura,Recibo>();
            contabilidad += f1;
            contabilidad += f2;
            contabilidad += f3;
            contabilidad += f4;
            contabilidad += r1;
            contabilidad += r2;
            contabilidad += r3;
            contabilidad += r4;

            Console.WriteLine(contabilidad.Mostrar(contabilidad));
            Console.ReadKey();


        }
    }
}
