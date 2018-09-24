using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Escribir un programa que determine si un año es bisiesto.
 Un año es bisiesto si es múltiplo de 4.Los años múltiplos de 100 no son bisiestos, salvo si ellos
 también son múltiplos de 400.Por ejemplo: el año 2000 es bisiesto pero 1900 no.
 Nota: Utilizar estructuras repetitivas, selectivas y la función módulo(%).*/
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 06";
            double numero;
            double auxiliar;

            Console.WriteLine("ingrese un anio: ");
            if(double.TryParse(Console.ReadLine(),out auxiliar))
            {
                numero = auxiliar;
                if((numero % 4 == 0) && (numero % 100 != 0 || numero % 400 == 0))
                { 
                        Console.WriteLine("el numero es bisiesto");
                        Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("el numero No es bisiesto");
                    Console.ReadKey();
                }


            }
        }
    }
}
