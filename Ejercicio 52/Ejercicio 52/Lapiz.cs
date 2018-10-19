using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    class Lapiz
    {
        float tamanioMina;

        public ConsoleColor Color
        {
            get
            {
                return this.Color;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public float UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }
        public Lapiz(int unidades)
        {
            this.UnidadesDeEscritura = unidades;
        }
        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

    }
}
