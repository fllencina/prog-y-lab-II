using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador: Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        #region "Propiedades"
        public float Altura
        {
            get
            {
                return this.altura;
            }
        }
        public float Peso
        {
            get
            {
                return this.peso;
            }
        }
        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }
        #endregion
        #region "Cosntructor"
        public Jugador(string nombre, string apellido, int edad, int dni, float peso,float altura,Posicion posicion):base(nombre,apellido,edad,dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }
        #endregion
        #region "Metodos"
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} Altura: {1}Peso: {2}Posicion: {3}\n", base.Mostrar(),Altura,Peso,Posicion);
            return sb.ToString();
        }
        public bool ValidarEstadoFisico()
        {
            float IMC = Peso / (Altura * Altura);
            if(IMC <25 && IMC>18.5)
            {
                return true;
            }
            return false;
        }
        public override bool ValidarAptitud()
        {
            if(Edad <40 && ValidarEstadoFisico())
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
