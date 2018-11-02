using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    class PuntoDat : Archivo
    {
        private string contenido;

        public string Contenido
        {
            get
            {
                return this.contenido;
            }
            set
            {
                this.contenido = value;
            }
        }
        //Public bool Guarda(PuntoDat ruta){}
        //Public PuntoDat Leer(string ruta){}
        protected  bool ValidarArchivo(string ruta) { }
    }
}
