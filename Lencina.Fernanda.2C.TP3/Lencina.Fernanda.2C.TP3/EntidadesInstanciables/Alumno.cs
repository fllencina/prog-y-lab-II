using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesInstanciables;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
    
    sealed public class Alumno:Universitario
    {
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

        Universidad.EClases claseQueToma;
        EEstadoCuenta estadoCuenta;

        #region "Constructores"
        public Alumno()
        { }
        public Alumno(int id,string nombre,string apellido,string dni,ENacionalidad nacionalidad,Universidad.EClases claseQueToma):base(id,nombre,apellido,dni,nacionalidad)
        {
            this.claseQueToma =claseQueToma;
        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad,Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) : this(id, nombre, apellido, dni, nacionalidad,claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        #endregion

        #region "Metodos"
        //sobreescribo metodos
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}", base.MostrarDatos());
            if (this.estadoCuenta == EEstadoCuenta.AlDia)
            {
                sb.AppendLine("ESTADO DE CUENTA: Cuota al día");
            }
            else
            {
                sb.AppendFormat("ESTADO DE CUENTA: {0}\n", this.estadoCuenta);
            }
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("TOMA CLASE DE {0}", this.claseQueToma);
            return sb.ToString();
        }
        //sobreescrito ToString para que haga publicos los datos del alumno
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region "Sobrecarga"
        public static bool operator==(Alumno a,Universidad.EClases clase)
        {
            if(a.estadoCuenta!=EEstadoCuenta.Deudor && a.claseQueToma==clase)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Alumno a,Universidad.EClases clase)
        {
            return !(a == clase);
        }

            #endregion
    }
}
