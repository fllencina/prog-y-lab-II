using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    public class AutoF1:VehiculoDeCarrera
    {
        short caballosDeFuerza;

        #region "constructor"
        public AutoF1(short numero, string escuderia):base(numero,escuderia)
        {       
        }
        public AutoF1(short numero, string escuderia,short caballosDeFuerza) : base(numero, escuderia)
        {

        }
        #endregion
        #region "Propiedades"
        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
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
        public static bool operator ==(AutoF1 a1,AutoF1 a2)
        {
            if(a1== a2 && a1.caballosDeFuerza== a2.caballosDeFuerza)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2); 
        }
        #endregion
    
    }
}
