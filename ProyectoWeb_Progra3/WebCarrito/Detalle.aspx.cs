using Clases;
using Conexiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCarrito
{
    public partial class Detalle : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulo { get; set; }
        public List<Imagen> ListaImagen { get; set; }
       

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["cod"] != null)
            {
                string codigo = Request.QueryString["cod"].ToString();

                DatosDeArticulos articulo = new DatosDeArticulos();
                ListaArticulo = articulo.Buscar(codigo, "Codigo");
                ImagenesDatos imagen = new ImagenesDatos();
                ListaImagen = imagen.Listar();

                /*DatosDeArticulos articulo = new DatosDeArticulos();
                Producto = articulo.listarArticulo(ID);
                ImagenesDatos imagen = new ImagenesDatos();
                ListaImagen = imagen.Listar();*/
            }
        }
    }
}