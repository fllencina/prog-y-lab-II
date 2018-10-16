using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class AutoF1
    {
        short cantidadCombustible;
        bool enCompetencia;
        string escuderia;
        short numero;
        short vueltasRestantes;

        #region "constructor"
        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            SetEnCompetencia(false);
            SetCantidadCombustible(0);
            SetVueltasRestantes(0);
        }
        #endregion
        
        public bool SetCantidadCombustible(short cantidadCombustible)
        {
            if (cantidadCombustible > 0)
            {
                this.cantidadCombustible = cantidadCombustible;
                return true;
            }
            return false;
        }
        public void SetEnCompetencia(bool enCompetencia)
        {
           this.enCompetencia = enCompetencia;     
        }
        public void SetVueltasRestantes(short vueltasRestantes)
        {          
             this.vueltasRestantes = vueltasRestantes;    
        } 
        public short GetCantidadCombustible()
        {
            return this.cantidadCombustible;
        }
        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }
        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }
        
        public string MostrarDatos()
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
