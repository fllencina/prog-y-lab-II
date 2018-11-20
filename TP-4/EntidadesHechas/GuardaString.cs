using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace EntidadesHechas
{
    public static class GuardaString
    {
       public  static bool Guardar(this string texto,string archivo)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + archivo;
            if (File.Exists(archivo))
            {
                StreamWriter sr = new StreamWriter(ruta, true);
                sr.WriteLine(texto);
                sr.Close();
                return true;
            }
            else
            {
                StreamWriter sr = new StreamWriter(ruta);
                sr.WriteLine(texto);
                sr.Close();
                return true;
            }
        }
    }
}
