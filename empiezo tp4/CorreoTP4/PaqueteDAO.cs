using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace CorreoTP4
{
    public static class PaqueteDAO
    {
        static SqlConnection conexion;
        static SqlCommand comando;
        static SqlDataReader reader;

        static PaqueteDAO()
        {
            conexion = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=correo-sp-2017;integrated Security=true");
        }

        public static bool Insertar(Paquete p)
        {
            comando = new SqlCommand();
            bool retorno = false;
            try
            {
                conexion.Open();
                comando = new SqlCommand("INSERT INTO Paquetes(Id,DireccionEntrega,TrackingId,Alumno) VALUES ('" + p.Id + "','" + p.DireccionEntrega + "','"+p.TrackingId+ "','" + "Lencina.Fernanda" + "')", conexion);
                comando.ExecuteNonQuery();
                retorno = true;
            }
            catch (TrackingIdRepetidoException ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return retorno;
        }

    }
}
