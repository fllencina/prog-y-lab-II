using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_61
{
    class Persona
    {
        private int Id;
        private string nombre;
        private string apellido;

        #region "Constructores"
        public Persona(int id, string nombre, string apellido):this(nombre,apellido)
        {
            this.Id = id;
        }
        public Persona( string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        #endregion

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public string Identificacion
        {
            get
            {
                return this.Id.ToString();
            }
        }

    }
}
