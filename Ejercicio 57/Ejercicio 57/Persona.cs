using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio_57
{
    [Serializable]
    public class Persona
    {
         private string nombre;
         private string apellido;

        public Persona()
        { }
        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
           Apellido = apellido;
        }
        //Me armo propiedades para poder serializarlo, solo es posible en artibutos publicos
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public static void Guardar(Persona p, string ruta)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Persona));
            XmlWriter writer = new XmlTextWriter(ruta, null);
            ser.Serialize(writer, p);
            writer.Close();
        }
        public static Persona Leer(string ruta)
        {
            Persona aux = new Persona(null, null);
            XmlTextReader reader = new XmlTextReader(ruta);
            XmlSerializer ser = new XmlSerializer(typeof(Persona));

            aux = (Persona)ser.Deserialize(reader);

            reader.Close();
            return aux;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre Completo: {1},{0}",Nombre,Apellido);
            return sb.ToString();

        }
    }
}
