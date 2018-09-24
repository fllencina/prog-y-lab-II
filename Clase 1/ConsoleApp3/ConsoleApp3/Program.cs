using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 03";

            int numero;
            int i;
            int j;
            int auxiliar;
            int cont = 0;

            Console.WriteLine("ingrese un numero ");
            if( int.TryParse(Console.ReadLine(),out auxiliar))
            {
                numero = auxiliar;
                for ( i = 2; i <= numero; i++)
                {
                    for (j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            cont = cont + 1;
                        }
                    }
                    if (cont < 3)
                    {
                        Console.WriteLine(i);
                    }
                    cont = 0;
                }
                Console.ReadKey();
            }
        }
    }
}
