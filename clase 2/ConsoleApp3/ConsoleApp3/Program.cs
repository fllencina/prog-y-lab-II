using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
con DateTime.Now).
Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos.*/
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadDias;
            double cantDias;
            int contador=0;
            int anioInicio;
            int anioHoy;
            int i;

            Console.Title = "Ejercicio Nro 07";
            DateTime fechaNacimiento = new DateTime();
            Console.WriteLine("ingrese fecha de nacimento(Por ejemplo: 04/11/1989)");
            fechaNacimiento = DateTime.Parse(Console.ReadLine());
            DateTime fechaActual = DateTime.Now;//toma la fecha y hora de la pc 
           // string txtfechaActual = fechaActual.ToShortDateString();// tomo solo la fecha saco el tiempo lo guardo como string
            Console.WriteLine("fecha de nacimiento: " + fechaNacimiento);
            Console.WriteLine("fecha actual: " + fechaActual);
            Console.ReadKey();

            TimeSpan tSpan = fechaActual - fechaNacimiento;
            cantidadDias = tSpan.Days;//tSpan.TotalDays devuelve la cantidad de dias totales, contando los bisiestos

            anioInicio = fechaNacimiento.Year;
            anioHoy = fechaActual.Year;
            for(i=anioInicio;i<anioHoy;i++)
            {
                if ((i % 4 == 0) && (i % 100 != 0 || i % 400 == 0))
                {
                    contador++;
                }
            }
            cantidadDias=cantidadDias + contador;
            Console.WriteLine("la cantidad de dias es: " + cantidadDias);
            Console.ReadKey();
            cantDias = tSpan.TotalDays;//pruebo si da igual, 
            Console.WriteLine("la cantidad total de dias es: " + cantDias);
            Console.ReadKey();
        }
    }
}
