using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace WebCarrito
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Carro = new Carrito();
            if (Session["articulosAgregados"] != null)
            {
                Carro.Articulos = (List<Articulo>)Session["articulosAgregados"];
            }
        }
    }
}