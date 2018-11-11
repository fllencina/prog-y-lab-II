using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace WindowsFormsApp1
{

    class Temporizador
    {
        public delegate void DelegadoTemporizador();
        public event DelegadoTemporizador miEventoTemporizador;

        private Thread hilo;
        private int intervalo;

        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }
        public Temporizador(int intervalo)
        {
            Intervalo = intervalo;
        }
        private void Corriendo()
        {
            while (true)
            {
                miEventoTemporizador();
                Thread.Sleep(Intervalo);
            }
        }
        public bool Activo
        {
            get
            {
                bool retorno = false; //Si es null o si no está vivo
                if (hilo != null && hilo.IsAlive == true)
                {
                    retorno = true;
                }
                return retorno;
            }
            set
            {
                if ((value == true && hilo == null) || (value == true && hilo != null && hilo.IsAlive == false))
                {
                    hilo = new Thread(Corriendo);
                    hilo.Start();
                }
                else if (value == false && hilo != null && hilo.IsAlive == true)
                {
                    hilo.Abort();
                }
            }
        }
    }
}