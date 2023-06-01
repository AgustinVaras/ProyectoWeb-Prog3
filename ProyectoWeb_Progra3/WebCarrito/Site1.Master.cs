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
        public Carrito Carro { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Articulo art = new Articulo();
                art.Descripcion = "prueba";
                art.Nombre = "prueba_Art";
                art.Precio = 500;
                art.Codigo = "pr1";

                Carro = new Carrito();
                Carro.Articulos.Add(art);
            }
        }


    }
}