using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Ejercicio_64
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();
            Negocio negocio = new Negocio(caja1,caja2);
            negocio.Clientes.Add("Leonardo");
            negocio.Clientes.Add("Liliana");
            negocio.Clientes.Add("Monica");
            negocio.Clientes.Add("Florencia");
            negocio.Clientes.Add("Laura");
            negocio.Clientes.Add("Felipe");
            negocio.Clientes.Add("Pedro");
            negocio.Clientes.Add("Ana");
            negocio.Clientes.Add("Maria");
            negocio.Clientes.Add("Rocio");

            Thread primerHilo = new Thread(negocio.AsignarCaja);
            Thread segundoHilo = new Thread(caja1.AtenderCliente);
            segundoHilo.Name = "Caja 1";
            Thread tercerHilo = new Thread(caja2.AtenderCliente);
            tercerHilo.Name = "Caja 2";

            primerHilo.Start();
            primerHilo.Join();
            segundoHilo.Start();
            tercerHilo.Start();
            segundoHilo.Join();
            tercerHilo.Join();

            Console.WriteLine("Todos los clientes han sido atendidos, presione una tecla");
            Console.ReadKey();

        }
    }
}
