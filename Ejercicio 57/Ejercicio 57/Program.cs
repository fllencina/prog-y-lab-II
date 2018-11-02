using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio_57
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona unaPersona= new Persona("Fernanda", "Lencina");
            Persona OtraPersona = null;
            try
            {
                Persona.Guardar(unaPersona, @"D:\VisualStudio\fernanda\prog-y-lab-II-master\Ejercicio 57\Archivo.xml");
            }
            catch (System.UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                OtraPersona = Persona.Leer(@"D:\VisualStudio\fernanda\prog-y-lab-II-master\Ejercicio 57\Archivo.xml");
                Console.WriteLine(OtraPersona.ToString());
            }
            catch (System.UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            //OtraPersona =Persona.Leer(@"D:\VisualStudio\fernanda\prog-y-lab-II-master\Ejercicio 57\Archivo.xml");

            Console.ReadKey();
        }

    }
   
    
}
