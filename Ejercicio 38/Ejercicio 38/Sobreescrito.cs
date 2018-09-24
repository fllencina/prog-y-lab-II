using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_38
{
    class Sobreescrito
    {
        public override string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
        }
        public Sobreescrito()
        {

        }
        public override bool Equals(Object objeto)
        {
            if ((objeto == null) || !this.GetType().Equals(objeto.GetType()))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }


    }
}
