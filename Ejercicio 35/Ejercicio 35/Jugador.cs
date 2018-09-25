using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
    public class Jugador:Persona
    {
        public int partidosJugados;
        public int totalGoles;
        //constructores
       
        
        public Jugador(int dni, string nombre,int totalGoles,int totalPartidos) :base(dni,nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        public Jugador(int dni, string nombre):base(dni,nombre)
        {
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
        public new string MostrarDatos()
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
