using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
    public class Persona
    {
        public long dni;
        public string nombre;

        public Persona(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public long GetDni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }
        public string GetNombre
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
        
        public string MostrarDatos()
        {
            StringBuilder DatosPersona = new StringBuilder();
            DatosPersona.AppendLine("Nombre: " + GetNombre + "Dni: " + GetDni);
            return DatosPersona.ToString();
        }
    }
}
