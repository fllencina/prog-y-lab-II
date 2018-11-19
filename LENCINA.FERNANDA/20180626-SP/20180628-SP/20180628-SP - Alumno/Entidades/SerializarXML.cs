using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;
namespace Entidades
{
    public class SerializarXML<T> : IArchivos<T>
    {
        public bool Guardar(string ruta, T objeto)
        {
            XmlTextWriter xtw = null;
            try
            {
                xtw = new XmlTextWriter(ruta, Encoding.UTF8);
                XmlSerializer ser = new XmlSerializer(typeof(T));
                ser.Serialize(xtw, objeto);
                xtw.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new ErrorArchivoException(ex.Message);
            }
            finally
            {
                if (xtw != null)
                    xtw.Close();
                
            }
            //if (ruta != null && objeto != null)
            //{
            //    XmlSerializer ser = new XmlSerializer(typeof(T));
            //    XmlWriter writer = new XmlTextWriter(ruta, null);
            //    try
            //    {
            //        ser.Serialize(writer, objeto);
            //    }
            //    catch
            //    {
            //        throw new ErrorArchivoException("No fue posible escribir el archivo");
            //    }
            //    writer.Close();
            //    return true;
            //}
            
        }
        public T Leer(string ruta)
        {
            T aux = default(T);
            if (ruta != null)
            {

                XmlTextReader reader = new XmlTextReader(ruta);
                XmlSerializer ser = new XmlSerializer(typeof(T));
                try
                {
                    aux = (T)ser.Deserialize(reader);
                }
                catch
                {
                    throw new ErrorArchivoException("No fue posible leer el archivo");
                }
                reader.Close();
            }
            return aux;
        }
    }
}
