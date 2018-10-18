using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    public class Documento
    {
        private int numero;

        public Documento(int numero)
        {
            this.numero = numero;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\n", this.numero);
            return sb.ToString();
        }
    }
}
