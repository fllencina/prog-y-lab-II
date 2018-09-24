using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio Nro 01";
            int[] array = new int[5];
            int num=0;
            int cant = 0;
            int acumulador=0;
            int max=int.MinValue;
            int min=int.MaxValue;
            float promedio;

            while (cant < 5)
            {
                Console.WriteLine("Ingrese un numero");
                num = Convert.ToInt32(Console.ReadLine());

                acumulador = acumulador + num;

                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
                if (cant == 4)
                {
                    promedio = acumulador / 5;
                    Console.WriteLine("el promedio es: " + promedio);
                    Console.WriteLine("el minimo es: " + min);
                    Console.WriteLine("el maximo es: " + max);
                    Console.ReadKey();
                }
                cant++;
            }   
            
        }
    }
}
