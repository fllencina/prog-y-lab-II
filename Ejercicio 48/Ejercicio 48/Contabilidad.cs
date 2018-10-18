using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    public class Contabilidad <T,U> where T : Documento
                             where U : Documento , new()                            
    {
        private List<T> egresos=new List<T>();
        private List<U> ingresos=new List<U>();

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c ,T egresos)
        {
            c.egresos.Add(egresos);
            return c;
        }
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingresos)
        {
            c.ingresos.Add(ingresos);
            return c;
        }
        public  string Mostrar(Contabilidad<T, U> a)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Egresos:");
            foreach ( T e in a.egresos)
            {
                sb.AppendFormat("{0}",e.Mostrar());
            }
            sb.AppendLine("Ingresos:");
            foreach (U e in a.ingresos)
            {
                sb.AppendFormat("{0}", e.Mostrar());
            }

            return sb.ToString();
        }
    }
}
