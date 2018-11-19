using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Excepciones;

namespace Entidades
{
    public class DAO<T> :IArchivos<T> where T:Votacion
    {
        public bool Guardar(string ruta, T objeto)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=.\sqlexpress;Inicial Catalog="+ruta+@";Integrated Security=True");
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            
            string insertar="INSERT INTO votaciones (nombreLey,afirmativos,negativos,abstenciones,nombreAlumno) values ('"+ objeto.NombreLey+"','"+objeto.ContadorAfirmativo+ "','"+objeto.ContadorNegativo+ "','"+objeto.ContadorAbstencion+ "', Fernanda Lencina')";
            try
            {
                comando.CommandText = insertar;
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw e;
            }
            conexion.Close();
            return true;
        }
        public T Leer(string ruta)
        {
            throw new NotImplementedException();
        }
    }
}
