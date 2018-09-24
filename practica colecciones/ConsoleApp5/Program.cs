using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            Stack miPila = new Stack();//lo carga al reves
            miPila.Push("hola");
            miPila.Push("mundo");
            miPila.Push("!");

            for(int i=0;i<3;i++)
            {
                palabra = (string)miPila.Pop();
                Console.WriteLine(palabra);
                Console.ReadKey();
            }

            Console.WriteLine("-----------------------");
            Queue miCola = new Queue();//lo carga en ese orden
            miCola.Enqueue("hola");//Enqueue para ingresar un dato
            miCola.Enqueue("mundo");
            miCola.Enqueue("!");

            for (int i = 0; i < 3; i++)
            {
                palabra = (string)miCola.Dequeue();//Dequeue lee el dato
                Console.WriteLine(palabra);
                Console.ReadKey();
            }

            ArrayList miLista = new ArrayList();
            miLista.Add("hola");
            miLista.Add("mundo");
            miLista.Add("!");

        }

    }
}
