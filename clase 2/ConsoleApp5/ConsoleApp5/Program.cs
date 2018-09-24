using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*11. Ingresar 10 números enteros que pueden estar dentro de un rango de entre -100 y 100.
Para ello realizar una clase llamada Validacion que posea un método estático llamado Validar, que
posea la siguiente firma: bool Validar(int valor, int min, int max):
a. valor: dato a validar
b. min y max: rango en el cual deberá estar la variable valor.
Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
Nota: Utilizar variables escalares, NO utilizar vectores.*/
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 11";
            int numero;
            int min=-100;
            int max=100;
            int ingresoMax=int.MinValue;
            int ingresoMin=int.MaxValue;
            int acumulador=0;
            int i;
            int promedio;
            
            for(i=0;i<10;i++)
            {
                Console.WriteLine("Ingrese un numero");
                numero =Convert.ToInt32( Console.ReadLine());
                if(Validacion.Validar(numero,min,max))
                {
                    acumulador = acumulador + numero;
                    if (i == 0)
                    {
                        ingresoMax = numero;
                        ingresoMin = numero;
                    }
                    else
                    {
                        if (ingresoMin > numero)
                        {
                            ingresoMin = numero;
                        }
                        if (ingresoMax < numero)
                        {
                            ingresoMax = numero;
                        }
                    }
                
                }
                else
                {
                    i--;
                }
            }
            promedio = acumulador / 10;
            Console.WriteLine("minimo: " + ingresoMin);
            Console.WriteLine("maximo: " + ingresoMax);
            Console.WriteLine("promedio: " + promedio);
            Console.ReadKey();
        }
    }
}
