using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_39
{
   public  class SobreSobreescrito : Sobreescrito
   {
        public override string MiPropiedad()
        {
                return this.miAtributo;     
        }

        //metodos
        public override string MiMetodo()
        {
            return this.MiPropiedad();
        }
    }
}
