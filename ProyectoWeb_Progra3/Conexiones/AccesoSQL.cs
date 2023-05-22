using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Conexiones
{
    public class AccesoSQL
    {
        private SqlConnection Conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public SqlCommand Comando
        {
            get { return comando; }
        }

        public AccesoSQL()
        {
            Conexion = new SqlConnection("server =.\\SQLEXPRESS; database = CATALOGO_P3_DB; integrated security=true");
            comando = new SqlCommand();
        }

        public void Consulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void EjecutarLectura()
        {
            comando.Connection = Conexion;
            try
            {
                Conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EjecutarAccion()
        {
            comando.Connection = Conexion;
            try
            {
                Conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int EjecutarScalar()
        {
            comando.Connection = Conexion;
            int idEjecucion;
            try
            {
                Conexion.Open();
                idEjecucion =  (int)comando.ExecuteScalar();
                return idEjecucion;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void SetParametros(string Nombre, object Valor)
        {
            comando.Parameters.AddWithValue(Nombre, Valor);
        }

        public void CerrarConexion()
        {
            if (lector != null)
                lector.Close();
            Conexion.Close();
        }

    }
}
