using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Clases;

namespace Conexiones
{
    public class DatosDeArticulos
    {
        public List<Articulo> listar() 
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoSQL Datos = new AccesoSQL();

            try
            {
                Datos.Consulta("Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio , C.Id Categoria, M.Id Marca From ARTICULOS A  Inner Join MARCAS M on A.IdMarca = M.Id Inner Join CATEGORIAS C on A.IdCategoria = C.Id");
                Datos.EjecutarLectura();

                while (Datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)Datos.Lector["Id"];
                    aux.IdCategoria = (int)Datos.Lector["Categoria"];
                    aux.IdMarca = (int)Datos.Lector["Marca"];
                    aux.Codigo = (string)Datos.Lector["Codigo"];
                    aux.Nombre = (string)Datos.Lector["Nombre"];
                    aux.Descripcion = (string)Datos.Lector["Descripcion"];
                    aux.Precio = Decimal.Round((decimal)Datos.Lector["Precio"], 2);

                    lista.Add(aux);
                }
                    return lista;
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

        public List<Articulo> listar2(string ID)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoSQL Datos = new AccesoSQL();

            try
            {
                Datos.Consulta("Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio , C.Id Categoria, M.Id Marca From ARTICULOS A  Inner Join MARCAS M on A.IdMarca = M.Id Inner Join CATEGORIAS C on A.IdCategoria = C.Id where a.Id = " + ID);
                Datos.EjecutarLectura();

                while (Datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)Datos.Lector["Id"];
                    aux.IdCategoria = (int)Datos.Lector["Categoria"];
                    aux.IdMarca = (int)Datos.Lector["Marca"];
                    aux.Codigo = (string)Datos.Lector["Codigo"];
                    aux.Nombre = (string)Datos.Lector["Nombre"];
                    aux.Descripcion = (string)Datos.Lector["Descripcion"];
                    aux.Precio = Decimal.Round((decimal)Datos.Lector["Precio"], 2);
                    /*aux.Descripcionm = (string)Datos.Lector["M.Descripcion"];
                    aux.Descripcionc = (string)Datos.Lector["C.Descripcion,"];*/


                    lista.Add(aux);
                }
                return lista;
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

        public void Agregar(Articulo nuevo)
        {
            AccesoSQL datos = new AccesoSQL();

            try
            {
                datos.Consulta("Insert into ARTICULOS(Codigo, Nombre, Descripcion, Precio, IdCategoria, IdMarca) VALUES('" + nuevo.Codigo + "', '" + nuevo.Nombre + "' , '" + nuevo.Descripcion + "' , '" + nuevo.Precio + "' , '"+ nuevo.IdCategoria +"' , '"+ nuevo.IdMarca +"')");
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public int Agregar_getId(Articulo nuevo)
        {
            AccesoSQL datos = new AccesoSQL();
            int id;

            try
            {
                datos.Consulta("Insert into ARTICULOS(Codigo, Nombre, Descripcion, Precio, IdCategoria, IdMarca) output INSERTED.Id VALUES('" + nuevo.Codigo + "', '" + nuevo.Nombre + "' , '" + nuevo.Descripcion + "' , '" + nuevo.Precio + "' , '" + nuevo.IdCategoria + "' , '" + nuevo.IdMarca + "')");
                id = datos.EjecutarScalar();
                
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void Modificar(Articulo modificar)
        {
            AccesoSQL datos = new AccesoSQL();

            try
            {
                datos.Consulta("UPDATE ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, IdCategoria = @Categoria, IdMarca = @Marca Where Id = @Id ");
                
                datos.SetParametros("@Id", modificar.Id);
                
                datos.SetParametros("@Codigo", modificar.Codigo);
                datos.SetParametros("@Nombre", modificar.Nombre);
                datos.SetParametros("@Descripcion", modificar.Descripcion);
                datos.SetParametros("@Precio", modificar.Precio);
                datos.SetParametros("@Categoria", modificar.IdCategoria);
                datos.SetParametros("@Marca", modificar.IdMarca);
                
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public List<Articulo> Buscar(string busqueda, string criterio)
        {
            AccesoSQL Datos = new AccesoSQL();
            List<Articulo> lista = new List<Articulo>();

            try
            {
                criterio = ManejoDeCriterio(criterio);
                Datos.Consulta("Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio , C.Id Categoria, M.Id Marca From ARTICULOS A  Inner Join MARCAS M on A.IdMarca = M.Id Inner Join CATEGORIAS C on A.IdCategoria = C.Id where '" + busqueda + "' like " + criterio);
                Datos.EjecutarLectura();
                while (Datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)Datos.Lector["Id"];
                    aux.IdCategoria = (int)Datos.Lector["Categoria"];
                    aux.IdMarca = (int)Datos.Lector["Marca"];
                    aux.Codigo = (string)Datos.Lector["Codigo"];
                    aux.Nombre = (string)Datos.Lector["Nombre"];
                    aux.Descripcion = (string)Datos.Lector["Descripcion"];
                    aux.Precio = Decimal.Round((decimal)Datos.Lector["Precio"], 2);

                    lista.Add(aux);
                }          
                return lista;
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
            if (criterio == "Marca")
                return "M.Descripcion";
            if (criterio == "Categoria")
                return "C.Descripcion";
            return "A." + criterio;
        }

        public void Eliminar(int Id)
        {
           

            try
            {
                AccesoSQL datos = new AccesoSQL();
                datos.Consulta("DELETE from ARTICULOS where Id = @Id");
                datos.SetParametros("@Id",Id);
                datos.EjecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public List<Articulo> removeDuplicadosArticulo(List<Articulo> inputList)
        {
            Dictionary<string, string> uniqueStore = new Dictionary<string, string>();
            List<Articulo> finalList = new List<Articulo>();
            foreach (Articulo art in inputList)
            {
                if (!uniqueStore.ContainsKey(art.Codigo))
                {
                    uniqueStore.Add(art.Codigo, "0");
                    finalList.Add(art);
                }
            }
            return finalList;
        }
    }
}
