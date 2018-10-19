using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase aux = new OtraClase();
                aux.MetodoInstancia();
            }
            catch (MiExcepcion e)
            {
                Console.WriteLine(e.Message);

                if (!object.ReferenceEquals(e.InnerException, null))
                {
                    Exception ex = e.InnerException;
                    do
                    {
                        Console.WriteLine(ex.Message);
                        ex = ex.InnerException;
                    } while (!object.ReferenceEquals(ex, null));
                }
            }

            Console.ReadKey();
        }
    }
    class MiClase
    {
        public static void MetodoEstatico()
        {
            try
            {
                int aux = 0;
                int res = 10 / aux;
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
        }
        public MiClase()
        {
            try
            {
                MiClase.MetodoEstatico();
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
        }
        public MiClase(int a)
        {
            try
            {
                new MiClase();
            }
            catch (DivideByZeroException e)
            {
                throw new UnaExcepcion("esta clase lo captura y lugo se muestra lo resgistrado en inner", e);
            }
        }
    }
    public class OtraClase
    {
        public void MetodoInstancia()
        {
            try
            {
                new MiClase(0);
            }
            catch (UnaExcepcion e)
            {
                MiExcepcion ex = new MiExcepcion("esta  clase re-lanza la excepcion", e);
                throw ex;
            }
        }
    }
}

