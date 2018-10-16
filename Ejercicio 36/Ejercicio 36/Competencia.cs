using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    public class Competencia
    {
        short cantidadCompetidores;
        short cantidadVueltas;
        List<AutoF1> competidores;

        #region "constructores"
        private Competencia()
        {
            competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadVueltas,short cantidadCompetidores):this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }
        #endregion
        #region "Metodos"
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Cantidad de competidores: {0}\nCantidad de vueltas: {1}",this.cantidadCompetidores,this.cantidadVueltas);
            foreach(AutoF1 a in this.competidores)
            {
                sb.AppendFormat("\nAutoF1: {0}", a.MostrarDatos());
            }
            return sb.ToString();
        }
        #endregion
        #region "Sobrecarga"
        public static bool operator==(Competencia c, AutoF1 a)
        {
            foreach(AutoF1 b in c.competidores)
            {
                if(b==a)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return!(c == a);        
        }
        public static bool operator +(Competencia c, AutoF1 a)
        {
            Random random = new Random();
            
            if(c.cantidadCompetidores>c.competidores.Count)
            {
                if(!(c==a))
                {
                    a.EnCompetencia = true;
                    a.VueltasRestantes=(c.cantidadVueltas);
                    a.CantidadCombustible=((short)random.Next(15, 100));
              
                    c.competidores.Add(a);
                    return true;
                }
            }
            return false;
        }
        public static bool operator -(Competencia c, AutoF1 a)
        {
            if(c==a)
            {
                c.competidores.Remove(a);
                return true;
            }
            return false;
        }

        #endregion
    }
}