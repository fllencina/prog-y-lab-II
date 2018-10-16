using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_17
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima=100;
        ConsoleColor color;
        short tinta;

        public Boligrafo(short tinta,ConsoleColor color )
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
           return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        private void SetTinta(short tinta)
        {
            if (this.tinta + tinta >= 0 && this.tinta + tinta <= 100)
            {
                this.tinta += tinta;
            }
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            int cantidad = this.tinta - gasto;

            if(cantidad>=0)
            {
                SetTinta((short)gasto);
                dibujo = new string('*', cantidad);
                return true;
            }
            else
            {
                dibujo = new string(' ', 1);
                return false;
            }            
        }
    }
}
