﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Provincial:Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;

        //propiedades
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        //metodos
        private float CalcularCosto()
        {
            if(this.franjaHoraria==Franja.Franja_1)
            {
                return this.duracion * 0.99f;
            }
            if (this.franjaHoraria == Franja.Franja_2)
            {
                return this.duracion *1.25f;
            }        
            return this.duracion * 0.66f;
        }
        public new string Mostrar()
        {
            string retorno = this.Mostrar();
            StringBuilder provincia = new StringBuilder();
            provincia.AppendFormat("Llamada: {0}, Costo Llamada: {1},Franja Horaria: {2}", retorno, this.CostoLlamada,this.franjaHoraria);
            return provincia.ToString();
        }
        public Provincial(Franja minFranja,Llamada llamada):base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.franjaHoraria = minFranja;
        }
        public Provincial(string origen,Franja miFranja,float duracion,string destino) : this(miFranja,new Llamada(duracion, destino, origen))
        { }

    }
}
