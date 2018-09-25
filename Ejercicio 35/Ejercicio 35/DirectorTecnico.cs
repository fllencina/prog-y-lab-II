using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
    public class DirectorTecnico : Persona
    {
        public DateTime fechaNacimiento = new DateTime();

        public DirectorTecnico(string nombre) : base(nombre)
        {
        }
        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : base(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public DateTime GetFechaNacimiento
        {
            get
            {
                return this.fechaNacimiento;
            }
        }
        public new string MostrarDatos()
        {
            StringBuilder DatosDirector = new StringBuilder();
            DatosDirector.AppendLine("Nombre: " + GetNombre + "Dni: " + GetDni+ "Fecha de nacimiento: "+ GetFechaNacimiento);
            return DatosDirector.ToString();
        }

        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {
            if (d1.nombre == d2.nombre && d1.fechaNacimiento == d2.fechaNacimiento)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            return !(d1 == d2);
        }
    }
}
