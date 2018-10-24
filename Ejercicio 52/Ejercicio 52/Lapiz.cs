using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public class Lapiz: IAcciones
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
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Color de tinta: {1}\nNivel de tinta: {0}", UnidadesDeEscritura,Color);
            return sb.ToString();
        }
        public EscrituraWrapper Escribir(string texto)
        {
            int length = texto.Length;
            UnidadesDeEscritura = UnidadesDeEscritura - 0.1f * length;
            EscrituraWrapper escrito = new EscrituraWrapper(Color, texto);
            return escrito;
        }
    }
}
