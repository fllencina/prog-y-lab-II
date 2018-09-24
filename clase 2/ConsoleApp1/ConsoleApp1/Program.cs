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
            Console.Title = "Ejercicio Nro 05";

            // Variables
            int aumento = 1,
                numero,
                auxiliar,
                i,
                j,
                sumaAtras,
                sumaAdelante;

            // Ingreso de datos
            Console.Write("Ingrese un numero: ");
            if(int.TryParse(Console.ReadLine(), out auxiliar))
            {
                numero = auxiliar;
                // Comienzo del programa
                while (aumento < numero)
                {
                    aumento++;
                    sumaAtras = 0;
                    sumaAdelante = 0;

                    // Calculo para atras
                    for (i = 1; i < aumento; i++)
                    {
                        sumaAtras = sumaAtras + i;
                    }
                    //calculo para adelante
                    for (j = aumento + 1; j <= sumaAtras; j++)
                    {
                        if ((sumaAdelante == sumaAtras) || (sumaAdelante > sumaAtras))
                            break;
                        sumaAdelante = sumaAdelante + j;
                    }

                    // Mostrando en pantalla
                    if (sumaAtras == sumaAdelante)
                        Console.WriteLine("Es centro numerico: {0}", aumento);
                }
                Console.ReadLine();
            }
            
        }
    }
}
    

