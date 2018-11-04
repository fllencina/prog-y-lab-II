using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesInstanciables;
using EntidadesAbstractas;
using Archivos;
using Excepciones;

namespace EntidadesInstanciables
{
    
    public class Universidad
    {
        public enum EClases
        {
            Programacion, Laboratorio, Legislacion, SPD
        }

        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

        #region "Constructor"
        public Universidad()
        {
            alumnos = new List<Alumno>();
            jornada = new List<Jornada>();
            profesores = new List<Profesor>();
        }
        #endregion

        #region "Propiedades"
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }
        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }
        public List<Jornada> Jornada
        {
            get
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;
            }
        }
        public Jornada this[int i]
        {
            get
            {
                if (i >= 0 && i < this.jornada.Count)
                    return this.jornada[i];
                else
                    return null;
            }
            set
            {
                if (i >= 0 && i < this.jornada.Count)
                    this.jornada[i] = value;
            }
        }
        #endregion

        #region "Metodos"
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Jornada a in uni.Jornada)
            {
                sb.AppendLine("JORNADA:");
                sb.AppendLine(a.ToString());
            }
            return sb.ToString();
        }
        public override string ToString()
        {
            return MostrarDatos(this);
        }
        public static void Guardar(Universidad uni)
        {
            Xml<Universidad> aux = new Xml<Universidad>();
            try
            {
                aux.Guardar("Universidad.xml", uni);
            }
            catch(Exception e)
            {
                throw new ArchivosException(e.InnerException);
            }
            
        }
        public static Universidad Leer()
        {
            Xml<Universidad> aux = new Xml<Universidad>();
            Universidad universidad = null;
            try
            {
                aux.Leer("Universidad.xml", out  universidad);
            }
            catch (Exception e)
            {
                throw new ArchivosException(e.InnerException);
            }
            return universidad;
        }
        #endregion

        #region "Sobrecarga"
        public static bool operator ==(Universidad g, Alumno a)
        {
            if (g.alumnos.Contains(a))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        public static bool operator ==(Universidad g, Profesor i)
        {
            if (g.profesores.Contains(i))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        public static Profesor operator ==(Universidad u, EClases clase)
        {
            foreach (Profesor i in u.profesores)
            {
                if (i == clase)
                {
                    return i;
                }
            }
            throw new SinProfesorException();
        }
        public static Profesor operator !=(Universidad u, EClases clase)
        {
            foreach (Profesor i in u.profesores)
            {
                if (i != clase)
                {
                    return i;
                }
            }
            throw new SinProfesorException();
        }

        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada nuevaJornada = new Jornada(clase, g == clase);//(g==clase) me retorna el profesor de la clase, el constructor de jornada recibe por parametro la clase y el profesor
            foreach(Alumno a in g.alumnos)
            {
                if(a==clase)//si el alumno toma la clase 
                {
                    nuevaJornada.Alumnos.Add(a);
                }
            }
            g.jornada.Add(nuevaJornada);
            return g;
        }
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if(u!=a)
            {
                foreach (Alumno e in u.alumnos)
                {
                    if (e.DNI == a.DNI)
                    {
                        throw new AlumnoRepetidoException();
                        return u;
                    }    
                }
                u.alumnos.Add(a);
            }         
            return u;    
        }
        public static Universidad operator +(Universidad u, Profesor i)
        {
            if(u!=i)
            {
                u.profesores.Add(i);     
            }
            return u;
        }
        #endregion
    }
}
