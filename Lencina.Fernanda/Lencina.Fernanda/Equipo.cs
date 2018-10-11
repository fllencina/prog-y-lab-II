using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        #region "Propiedades"
        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if (value.ValidarAptitud())
                {
                    this.directorTecnico = value;
                }

            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        #endregion
        #region "Constructor"
        public Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }
        #endregion
        #region "Metodos"
        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}\n", e.Nombre);
            if (e.directorTecnico!=null)
            {
                sb.AppendFormat("Director Tecnico: {0}  {1}", e.directorTecnico.Nombre,e.directorTecnico.Apellido);
            }
            else
            {
                sb.AppendFormat("Sin DT adignado");
            }
            foreach (Jugador a in e.jugadores)
            {
                sb.AppendFormat("{0}", a.Mostrar());
            }
            return sb.ToString();
        }
        public static bool operator ==(Equipo e, Jugador j)
        {
            foreach (Jugador a in e.jugadores)
            {
                if (a.Dni == j.Dni)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }
        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j && cantidadMaximaJugadores > e.jugadores.Count && j.ValidarAptitud())
            {
                e.jugadores.Add(j);
            }
            return e;
        }

        public static bool ValidarEquipo(Equipo e)
        {
            int contadorA = 0;
            int contadorD = 0;
            int contadorC = 0;
            int contadorDel = 0;
            if (e.jugadores.Count == cantidadMaximaJugadores && e.directorTecnico!=null)
            {
                foreach (Jugador a in e.jugadores)
                {
                    switch (a.Posicion)
                    {
                        case Posicion.Arquero:
                            contadorA++;
                            break;
                        case Posicion.Central:
                            contadorC++;
                            break;
                        case Posicion.Defensor:
                            contadorD++;
                            break;
                        default:
                            contadorDel++;
                            break;
                    }
                    if (contadorA == 1 && contadorC > 0 && contadorD > 0 && contadorDel > 0)
                    {
                        return true;
                    }
                }

            }
            return false;
        }
        #endregion
    }
}
