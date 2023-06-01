using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Conexiones;

namespace WebCarrito
{
    public partial class Catalogo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatosDeArticulos articulo = new DatosDeArticulos();
            dgvCatalogo.DataSource = articulo.listar();
            dgvCatalogo.DataBind();
        }
    }
}