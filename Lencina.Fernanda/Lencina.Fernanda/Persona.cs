using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;

        #region "Propiedades"
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public int Dni
        {
            get
            {
                return this.dni;
            }
        }
        public int Edad
        {
            get
            {
                return this.edad;
            }
        }
        #endregion
        #region "Constructor"
        public Persona(string nombre,string apellido,int edad,int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }
        #endregion
        #region "Metodos"
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nNombre: {0} Apellido: {1} Edad: {2} Dni: {3}\n", Nombre, Apellido, Edad, Dni);
            return sb.ToString();
        }
        public abstract bool ValidarAptitud();
        #endregion
    }
}
