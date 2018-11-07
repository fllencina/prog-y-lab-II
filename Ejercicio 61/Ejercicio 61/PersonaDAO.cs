using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ejercicio_61
{
    class PersonaDAO
    {
        static SqlConnection conexion;
        static SqlCommand comando;
        static SqlDataReader reader;
        static PersonaDAO()
        {
            conexion = new SqlConnection(@"Data Source=.\alpha2000;Initial Catalog=Persona;integrated Security=true");
        }

        public static bool Guardar(Persona p)
        {
             conexion = new SqlConnection();
             comando = new SqlCommand();
            bool retorno = false;
            try
            {
                conexion.Open();
                comando = new SqlCommand("INSERT INTO Persona(Nombre,Apellido) VALUES ('" + p.Nombre + "','" + p.Apellido + "')", conexion);
                comando.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception ex)
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
        public static List<Persona> Leer()
        {
            List<Persona> lista = new List<Persona>();
            try
            {
                conexion.Open();
                comando = new SqlCommand("SELECT Nombre, Apellido, ID FROM Persona", conexion);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Persona p = new Persona((int)reader["ID"],reader["Nombre"].ToString(), reader["Apellido"].ToString() );
                    lista.Add(p);
                }
            }
            catch (Exception ex)
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

            return lista;
        }

        public static Persona LeerPorID(string ID)
        {
            Persona persona = null;
            try
            {
                conexion.Open();
                comando = new SqlCommand("SELECT (Nombre, Apellido) FROM Persona WHERE ID = " + ID, conexion);
                reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    persona = new Persona((int)reader["ID"],reader["Nombre"].ToString(), reader["Apellido"].ToString());
                }
            }
            catch (Exception ex)
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

            return persona;
        }

        public static bool Modificar(string ID, string nombre, string apellido)
        {
            bool retorno = false;
            try
            {
                conexion.Open();
                comando = new SqlCommand("UPDATE Persona SET Nombre = '" + nombre + "',Apellido = '" + apellido + "' WHERE ID = " + ID, conexion);
                comando.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception ex)
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

        public static bool Borrar(string ID)
        {
            bool retorno = false;
            try
            {
                conexion.Open();
                comando = new SqlCommand("DELETE FROM Persona WHERE ID = " + ID, conexion);
                comando.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception ex)
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
