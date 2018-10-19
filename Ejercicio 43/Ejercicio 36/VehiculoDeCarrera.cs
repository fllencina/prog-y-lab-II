using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    public class VehiculoDeCarrera
    {
        public short cantidadCombustible;
        public bool enCompetencia;
        public string escuderia;
        public short numero;
        public short vueltasRestantes;

        #region "constructor"
        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            EnCompetencia = false;
            CantidadCombustible = 0;
            VueltasRestantes=0;
        }
        #endregion
        #region "Propiedades"
        public short Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }
        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }
            set
            {
                this.escuderia = value;
            }
        }
        public short  CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }
        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }
        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }
        #endregion
        #region "Metodos"
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Numero: {0}\nEscuderia: {1}\nCantidad de combustible: {2}\nVueltas restantes: {3}\nEn competencia: {4}\n",Numero, Escuderia, CantidadCombustible, VueltasRestantes, EnCompetencia);
            return sb.ToString();
        }
        #endregion

    }
}
