using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorreoTP4
{
    public enum EEstado
    {
        Ingresado,
        EnViaje,
        Entregado
    }
    public delegate void DelegadoEstado(object sender, EventArgs e);

    public class Paquete
    {
        public string DireccionEntrega
        {
            get
            {
                
            }
        }


    }
}
