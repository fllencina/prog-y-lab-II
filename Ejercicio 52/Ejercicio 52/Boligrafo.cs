using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    class Boligrafo
    {
        ConsoleColor colorTinta;
        float tinta;

        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }
        public float Tinta
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }
        public bool Recargar(int unidades)
        {
            
        }
    }
}
