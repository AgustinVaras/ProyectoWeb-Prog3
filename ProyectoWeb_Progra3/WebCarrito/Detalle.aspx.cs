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

        public List<Articulo> ListaCarrito = new List<Articulo>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.AllKeys.Contains("cod"))
            {
                string codigo = Request.QueryString["cod"].ToString();

                DatosDeArticulos articulo = new DatosDeArticulos();
                ListaArticulo = articulo.Buscar(codigo, "Codigo");
                ImagenesDatos imagen = new ImagenesDatos();
                ListaImagen = imagen.Listar();
            }
            else
            {
                Response.Redirect("/");
            }
        }

        protected void btnAgregarACarrito_Click(object sender, EventArgs e)
        {
            string codigo = Request.QueryString["cod"];

            DatosDeArticulos articulos = new DatosDeArticulos();
            ListaArticulo = articulos.Buscar(codigo, "Codigo");

            if (ListaArticulo != null)
            {
                if (Session["articulosAgregados"] == null)
                {
                    ListaCarrito.Add(ListaArticulo.First());
                    Session.Add("articulosAgregados", ListaCarrito);
                }
                else
                {
                    ListaCarrito = (List<Articulo>)Session["articulosAgregados"];
                    ListaCarrito.Add(ListaArticulo.First());
                    Session.Add("articulosAgregados", ListaCarrito);
                }
            }
        }
    }
}