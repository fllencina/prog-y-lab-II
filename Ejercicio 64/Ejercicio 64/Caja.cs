using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_64
{
    class Caja
    {
        List<string> filaClientes;

        public Caja()
        {
            filaClientes = new List<string>();
        }

        public List<string> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
        }
        public void AtenderCliente()
        {
            foreach(string s in filaClientes)
            {
                Console.WriteLine(s);
            }
        }
    }
}
