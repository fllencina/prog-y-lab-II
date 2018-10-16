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

        public new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Numero: {0}\nEscuderia: {1}\nCantidad de combustible: {2}\nVueltas restantes: {3}\nEn competencia: {4}\n", this.numero, this.escuderia, this.cantidadCombustible, this.vueltasRestantes, this.enCompetencia);
            return sb.ToString();
        }
        
        #region "sobrecargas"
        public static bool operator ==(AutoF1 a1,AutoF1 a2)
        {
            if(a1.numero==a2.numero && a1.escuderia == a2.escuderia)
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
