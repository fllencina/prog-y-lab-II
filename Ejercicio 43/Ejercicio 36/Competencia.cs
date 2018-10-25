using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    public enum TipoCompetencia
    {
        F1,
        MotoCross
    }
    public class Competencia
    {
        short cantidadCompetidores;
        short cantidadVueltas;
        List<VehiculoDeCarrera> competidores;
        TipoCompetencia tipo;

        #region "constructores"
        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
            this.tipo = tipo;
        }
        #endregion
        #region "Propiedades"
        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }
        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }
        public VehiculoDeCarrera this[int i]
        {
            get
            {
                if (i < this.competidores.Count)
                {
                    return this.competidores[i];
                }
                return null;
            }
        }
        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
        #endregion
        #region "Metodos"
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Tipo de competencia: {0}Cantidad de competidores: {1}\nCantidad de vueltas: {2}", Tipo, this.cantidadCompetidores, this.cantidadVueltas);
            foreach (AutoF1 a in this.competidores)
            {
                sb.AppendFormat("\nAutoF1: {0}", a.MostrarDatos());
            }
            return sb.ToString();
        }
        #endregion
        #region "Sobrecarga"
        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            foreach (VehiculoDeCarrera b in c.competidores)
            {
                switch (c.tipo)
                {
                    case TipoCompetencia.F1:
                        if (b is AutoF1)
                        {
                            try
                            {
                                if ((AutoF1)a == (AutoF1)b)
                                    return true;
                            }
                            catch
                            {
                                throw  new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", "Competencia", "==");
                            }
                        }
                        break;
                    case TipoCompetencia.MotoCross:
                        if (b is MotoCross)
                        {
                            try
                            {
                                if ((MotoCross)a == (MotoCross)b)
                                    return true;
                            }
                            catch
                            {
                                throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", "Competencia", "==");
                            }
                        }
                        break;
                }               
            }
            return false;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }
        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            Random random = new Random();

            if (c.cantidadCompetidores > c.competidores.Count)
            {
                try
                {
                    if (!(c == a))
                    {
                        a.EnCompetencia = true;
                        a.VueltasRestantes = (c.cantidadVueltas);
                        a.CantidadCombustible = ((short)random.Next(15, 100));
                        c.competidores.Add(a);
                        return true;
                    }
                }
                catch (CompetenciaNoDisponibleException e)
                {
                    throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia", "+", e.InnerException);
                }
            }
            return false;
        }
        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            if (c == a)
            {
                c.competidores.Remove(a);
                return true;
            }
            return false;
        }

        #endregion
    }
}