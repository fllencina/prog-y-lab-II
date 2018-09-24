using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Jugador
    {
        public long dni;
        public string nombre;
        public int partidosJugados;
        public float promedioGoles;
        public int totalGoles;
        //constructores
        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre):this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni, string nombre,int totalGoles,int totalPartidos) : this(dni,nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        //metodos
        public float GetPromedioGoles()
        {
            if (this.partidosJugados != 0)
            {
                return (float)this.totalGoles/ (float)this.partidosJugados;
            }
            else
            {
                return 0;
            }
        }
        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Nombre: {0},Dni: {1}, \nPartidos Jugados: {2},Goles totales: {3},Promedio de Goles: {4}", this.nombre, this.dni,this.partidosJugados,this.totalGoles,this.GetPromedioGoles());
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
