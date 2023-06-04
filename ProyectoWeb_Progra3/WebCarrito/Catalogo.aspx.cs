using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Conexiones;
using Clases;

namespace WebCarrito
{
    public partial class Catalogo : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulo { get; set; }
        public List<Imagen> ListaImagen { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            DatosDeArticulos articulo = new DatosDeArticulos();
            ListaArticulo = articulo.listar();

            if (!IsPostBack)
            {
                repArticulos.DataSource = ListaArticulo;
                repArticulos.DataBind();
            }
        }

        protected void btnAgregarACarrito_Click(object sender, EventArgs e)
        {
            string id = ((Button)sender).CommandArgument;
        }
    }
}