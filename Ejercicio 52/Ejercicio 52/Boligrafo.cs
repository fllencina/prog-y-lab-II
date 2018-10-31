using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public class Boligrafo: IAcciones
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
        public float UnidadesDeEscritura
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
        public Boligrafo(int unidades,ConsoleColor color)
        {
            Color = color;
           UnidadesDeEscritura = unidades;
        }
        public bool Recargar(int unidades)
        {
            if(unidades>0)
            {
               UnidadesDeEscritura = unidades;
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Color de tinta: {1}\nNivel de tinta: {0}", UnidadesDeEscritura, Color);
            return sb.ToString();
        }
        public EscrituraWrapper Escribir(string texto)
        {
            int length = texto.Length;
            UnidadesDeEscritura = UnidadesDeEscritura - 0.3f * length;
            EscrituraWrapper escrito = new EscrituraWrapper(Color,texto);
            return escrito;
        }
    }
}
