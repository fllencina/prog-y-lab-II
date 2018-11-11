using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
                Thread.Sleep(2000);
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0}: {1} ", Thread.CurrentThread.Name, s);
                Console.WriteLine(sb.ToString());
                
            }
        }
    }
}
