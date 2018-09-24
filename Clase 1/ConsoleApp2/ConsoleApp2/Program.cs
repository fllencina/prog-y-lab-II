using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";

            int num;
            int auxNum;
            int cuadrado;
            int cubo;
            int flag = 0;
            do
            {
                Console.WriteLine("Ingrese un numero");
                if (int.TryParse(Console.ReadLine(), out auxNum) && auxNum > 0)
                {
                    flag = 1;
                    num = auxNum;
                    cuadrado = (int)Math.Pow(num, 2);
                    cubo = (int)Math.Pow(num, 3);
                    Console.WriteLine("el numero es: " + num);
                    Console.WriteLine("el cuadrado del numero es: " + cuadrado);
                    Console.WriteLine("el cubo del numero es: " + cubo);
                    Console.ReadKey();
                }

                 else
                {
                    Console.WriteLine("Error! Reingresar un numero");
                    Console.ReadKey();
                }
            } while (flag==0);

            

            
        }
    }
}
