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
    public partial class FinalizarCompra : System.Web.UI.Page
    {

        public Carrito Carro { get; set; }
        public List<Articulo> ListaArticulo { get; set; }

        public List<Imagen> ListaImagen { get; set; }
        public List<Articulo> ListaCarrito = new List<Articulo>();

        protected void Page_Load(object sender, EventArgs e)
        {
            Carro = new Carrito();
            
            Carro.Articulos = (List<Articulo>)Session["articulosAgregados"];
            repArticulos.DataSource = Carro.Articulos;
            repArticulos.DataBind();

            if(Session["articulosAgregados"] != null)
            {

            decimal Monto = Carro.CalcularMonto();

            PrecioFinal.Text = Monto.ToString();

            }


        }

        protected void repImagenes_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Articulo articulo = (Articulo)e.Item.DataItem;
            
                ImagenesDatos imagen = new ImagenesDatos();
                ListaImagen = imagen.Buscar("IdArticulo", articulo.Id.ToString());
            

                List<Imagen> ListaSinRepetidos = imagen.removeDuplicadosImagen(ListaImagen);
                Repeater repImagenes = (Repeater)e.Item.FindControl("repImagenes");
            
                repImagenes.DataSource = ListaSinRepetidos;
                repImagenes.DataBind();
                
            }

        }
    }
}