using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario:Persona
    {
        protected int legajo;

        #region "Constructores"
        public Universitario()
        { }
        public Universitario(int legajo,string nombre, string apellido, string dni,ENacionalidad nacionalidad):base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region "Metodos"
        //protegido y abstracto
        protected abstract string ParticiparEnClase();
        //protegido y virtual
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} \nLEGAJO NÚMERO: {1}\n", base.ToString(), this.legajo);
            return sb.ToString();
        }
        #endregion

        #region "Sobrecargas"
        public static bool operator==(Universitario pg1, Universitario pg2)
        {
            return (pg1.Equals(pg2));
        }
        public static bool operator!=(Universitario pg1,Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        public override bool Equals(object obj)
        {
            if(obj is Universitario && obj !=null)
            {
                Universitario unUniversitario = (Universitario)obj;
                if (unUniversitario.legajo == this.legajo && unUniversitario.DNI == this.DNI)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
