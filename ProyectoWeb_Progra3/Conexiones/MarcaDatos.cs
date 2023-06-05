using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Conexiones
{
    public class MarcaDatos
    {
        public List<Marca> Listar()
        {
            List<Marca> Listar = new List<Marca>();
            AccesoSQL Datos = new AccesoSQL();

            try
            {
                Datos.Consulta("Select Id, Descripcion as Marca From MARCAS");
                Datos.EjecutarLectura();

                while (Datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)Datos.Lector["Id"];
                    aux.Descripcion = (string)Datos.Lector["Marca"];
                    Listar.Add(aux);
                }
                return Listar;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Datos.CerrarConexion();
            }
        }

        public Marca Buscar(string busqueda, string criterio)
        {
            AccesoSQL Datos = new AccesoSQL();
            Marca aux = new Marca();

            try
            {
                if (ManejoDeBusqueda(busqueda, criterio))
                {

                    Datos.Consulta("Select Id, Descripcion From MARCAS where " + busqueda + " like " + criterio);
                    Datos.EjecutarLectura();
                    if (Datos.Lector.Read())
                    {
                        aux.Id = (int)Datos.Lector["Id"];
                        aux.Descripcion = (string)Datos.Lector["Descripcion"];
                    }
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Datos.CerrarConexion();
            }
        }

        private string ManejoDeCriterio(string criterio)
        {
            return "M." + criterio;
        }

        private bool ManejoDeBusqueda(string busqueda, string criterio)
        {
            if (criterio == "Id")
            {
                bool isWrongType = int.TryParse(busqueda, out int id);
                return isWrongType;
            }
            else return true;
        }

        public List<Marca> removeDuplicadosMarca(List<Marca> inputList)
        {
            Dictionary<string, string> uniqueStore = new Dictionary<string, string>();
            List<Marca> finalList = new List<Marca>();
            foreach (Marca mar in inputList)
            {
                if (!uniqueStore.ContainsKey(mar.Descripcion))
                {
                    uniqueStore.Add(mar.Descripcion, "0");
                    finalList.Add(mar);
                }
            }
            return finalList;
        }
    }
}
