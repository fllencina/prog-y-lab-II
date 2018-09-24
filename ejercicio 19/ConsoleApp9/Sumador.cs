using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Sumador
    {
        public int cantidadSumas;

        public  Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public Sumador():this(0)
        { }

        public long Sumar(long a, long b)
        {
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            return a + b;
        }

       public static explicit operator int (Sumador s)
       {
            return s.cantidadSumas;
       }


    }
}
