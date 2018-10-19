using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_42
{
    class UnaExcepcion: Exception
    {
        public UnaExcepcion(string mensaje, Exception inner):base(mensaje,inner)
        {
        }
        public UnaExcepcion(string mensaje) : base(mensaje)
        {
        }
    }
}
