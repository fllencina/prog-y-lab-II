using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_32
{
    public class Jugador
    {
        public  long dni;
        public string nombre;
        public int partidosJugados;
        public int totalGoles;
        //constructores
        public Jugador()
        {
            this.partidosJugados = 0;
            
            this.totalGoles = 0;
        }
        private Jugador(int dni, string nombre):this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni, string nombre,int totalGoles,int totalPartidos) : this(dni,nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
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
        public int GetPartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }
        public int GetGolesTotales
        {
            get
            {
                return this.totalGoles;
            }
        }
        public float GetPromedioGoles
        {
           get
            {
                if (this.partidosJugados != 0)
                {
                    return (float)this.totalGoles / (float)this.partidosJugados;
                }
                else
                {
                    return 0;
                }

            }
           
        }
        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Nombre: {0},Dni: {1}, \nPartidos Jugados: {2},Goles totales: {3},Promedio de Goles: {4}", GetNombre, GetDni,GetPartidosJugados,GetGolesTotales,GetPromedioGoles);
            return datos.ToString();
        }
        //sobrecarga
        public static bool operator==(Jugador j1,Jugador j2)
        {
            if(j1.dni==j2.dni)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);    
        }

    }
}
