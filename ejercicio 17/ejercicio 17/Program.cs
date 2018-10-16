using System;


namespace ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 17";
            int opcion = 0;
            int eleccion = 0;
            Boligrafo azul = new Boligrafo(100,ConsoleColor.Blue);
            Boligrafo rojo = new Boligrafo(50,ConsoleColor.Red);

            Console.WriteLine("------Menu------");
            opcion=Convert.ToInt16( Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Eliga que boligrafo usara: \nBoligrafo 1\nBoligrafo 2");
                    eleccion = Convert.ToInt16( Console.ReadLine());
                    if(eleccion==1)
                    {
                        Console.WriteLine(azul.GetColor());
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;

            }
            
           

        }
    }
}

