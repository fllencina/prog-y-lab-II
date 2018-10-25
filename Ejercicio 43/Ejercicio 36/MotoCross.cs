using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
   public  class MotoCross:VehiculoDeCarrera
    {
        public short cilindrada;

        #region "constructor"
        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {
        }
        public MotoCross(short numero, string escuderia, short caballosDeFuerza) : base(numero, escuderia)
        {

        }
        #endregion

        #region "Propiedades"
        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                this.cilindrada = value;
            }
        }
        #endregion

        #region "Metodo"
        public new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.MostrarDatos());
            return sb.ToString();
        }
        #endregion

        #region "sobrecargas"
        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            if (a1.cilindrada == a2.cilindrada)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }
        #endregion
    }
}
