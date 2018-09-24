using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio28
{
   public class Lista
    {
        public static int contador;

        public static void addPalabra(string[] palabra)
        {
            int valor = 1;
            Dictionary<string, int> texto = new Dictionary<string, int>();
            for (int i = 0; i < palabra.Length; i++)
            {
                for (int j = i; j < palabra.Length - 1; j++)
                {
                    if (texto.ContainsKey(palabra[j]))
                    {
                        texto.Add(palabra[i], valor + 1);
                    }
                    else
                    {
                        texto.Add(palabra[i],valor);
                    }
                    valor = 1;
                }
                Lista.contador = +1;
            }
        }
        public static string[] generaArray(string palabras)
        {
            palabras.Replace(",", " ");
            palabras.Replace(".", " ");
            return palabras.Split(' ');//rompe segun caracter que le pase por parametro
        }
    }
}
