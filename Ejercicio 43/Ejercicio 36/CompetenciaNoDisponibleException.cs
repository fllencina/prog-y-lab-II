using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    class CompetenciaNoDisponibleException:Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        #region"Propiedades"
        public string NombreClase
        {
            get
            {
               return  this.nombreClase;
            }
        }
        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }
        #endregion
        #region "Constructores"
        public CompetenciaNoDisponibleException(string mensaje,string clase, string metodo):this(mensaje,clase,metodo,null)
        {
            
        }
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException):base(mensaje,innerException)
        {

        }
        #endregion
        #region "Metodo"
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Excepción en el método {0} de la clase {1}: {2}", NombreMetodo, NombreClase, this.Message);
            Exception inner = this.InnerException;
            while (inner != null)
            {
                sb.AppendFormat("\t{0}", inner.Message);
                inner = inner.InnerException;
            }
            return sb.ToString();
        }
        #endregion
    }
}
