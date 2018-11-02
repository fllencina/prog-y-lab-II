using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace IO
{
    abstract class Archivo
    {
        protected bool ValidarArchivo(string ruta)
        {
            try
            {
                if (System.IO.File.Exists(ruta))
                {
                    return true;
                }
            }
            catch
            {
                throw new FileNotFoundException();
            }
            return false;
        }
    }
}
