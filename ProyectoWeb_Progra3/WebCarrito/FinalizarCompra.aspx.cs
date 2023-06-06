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

        public List<Articulo> ListaArticulo { get; set; }

        public List<Imagen> ListaImagen { get; set; }
        public List<Articulo> ListaCarrito = new List<Articulo>();

        protected void Page_Load(object sender, EventArgs e)
        {

            DatosDeArticulos articulo = new DatosDeArticulos();

            List<Articulo> Lista = (List<Articulo>)Session["articulosAgregados"];
            repArticulos.DataSource = Lista;
            repArticulos.DataBind();

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