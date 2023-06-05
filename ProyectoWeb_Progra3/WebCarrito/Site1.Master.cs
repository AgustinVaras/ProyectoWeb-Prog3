using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;
using Conexiones;

namespace WebCarrito
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public Carrito Carro { get; private set; }
        public List<Imagen> ListaImagen { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            CategoriaDatos categoriaDatos = new CategoriaDatos();
            MarcaDatos marcaDatos = new MarcaDatos();
            if(!IsPostBack)
            {
                repCategorias.DataSource = categoriaDatos.removeDuplicadosCategoria(categoriaDatos.Listar());
                repCategorias.DataBind();
                repMarcas.DataSource = marcaDatos.removeDuplicadosMarca(marcaDatos.Listar());
                repMarcas.DataBind();
            }


            Carro = new Carrito();
            if (Session["articulosAgregados"] != null)
            {
                Carro.Articulos = (List<Articulo>)Session["articulosAgregados"];
                ImagenesDatos imagen = new ImagenesDatos();
                ListaImagen = imagen.Listar();
            }
        }
    }
}