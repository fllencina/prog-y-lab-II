using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico:Persona
    {
        private int añosExperiencia;

        #region "Propiedades"
        public int AñosExperiencia
        {
            get
            {
                return this.añosExperiencia;
            }
            set
            {
                this.añosExperiencia = value;
            }
        }
        #endregion
        #region "Constructor
        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia) :base(nombre,apellido,edad,dni)
        {
            AñosExperiencia = añosExperiencia;
        }
        #endregion
        #region "Metodos"
        public override bool ValidarAptitud()
        {
            if(this.Edad<65 && this.añosExperiencia>=2)
            {
                return true;
            }
            return false;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} Años de experiencia: {1}\n",base.Mostrar(),AñosExperiencia);
            return sb.ToString();
        }
        #endregion
    }
}
