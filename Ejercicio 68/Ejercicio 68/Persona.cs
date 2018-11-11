using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_68
{
    public delegate void DelegadoString(string msg);
    
    class Persona
    {
        string nombre;
        string apellido;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
        public string Mostrar()
        {
            string datos = Nombre + " " + Apellido;
            return datos;
        }
    }
}
