using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
    sealed public  class Profesor : Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;

        #region "Constructor"
        public Profesor()
        { }
        static Profesor()
        {
            random = new Random();
        }
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases(); //Asigna dos clases al azar a la lista de clases del profesor. 
        }
        #endregion

        #region "Metodos"
        private void _randomClases()
        {
            this.clasesDelDia.Enqueue((Universidad.EClases)Profesor.random.Next(0, 4));
            this.clasesDelDia.Enqueue((Universidad.EClases)Profesor.random.Next(0, 4));
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\n{1}", base.MostrarDatos(), ParticiparEnClase());
            return sb.ToString();
        }
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASES DEL DÍA:");
            if (this.clasesDelDia != null)
            {
                foreach (Universidad.EClases c in this.clasesDelDia)
                {
                    
                    sb.AppendFormat("{0}\n",c);
                }
            }
            return sb.ToString();
        }
        #endregion

        #region "Sobrecarga"
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            foreach (Universidad.EClases c in i.clasesDelDia)
            {
                if (clase == c)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Profesor i,Universidad.EClases clase)
        {
            return !(i == clase);
        }
        #endregion
    }
}
