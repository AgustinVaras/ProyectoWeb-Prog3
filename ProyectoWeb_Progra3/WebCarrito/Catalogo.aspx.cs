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
                if (ListaArticulo != null)
                {
                    List<Articulo> ListaSinRepetidos = articulo.removeDuplicadosArticulo(ListaArticulo);
                    repArticulos.DataSource = ListaSinRepetidos;
                    repArticulos.DataBind();
                }
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

                if (ListaImagen != null)
                {
                    List<Imagen> ListaSinRepetidos = imagen.removeDuplicadosImagen(ListaImagen); 
                    Repeater repImagenes = (Repeater)e.Item.FindControl("repImagenes");

                    repImagenes.DataSource = ListaSinRepetidos;
                    repImagenes.DataBind();
                }
            }
        }

        
        protected void btnAgregarACarrito_Click(object sender, EventArgs e)
        {
            string codigo = ((Button)sender).CommandArgument;

            DatosDeArticulos articulos = new DatosDeArticulos();
            ListaArticulo = articulos.Buscar(codigo, "Codigo");

            List<Articulo> ListaSinRepetidos = articulos.removeDuplicadosArticulo(ListaArticulo);

            Session.Add("articuloAgregado", ListaSinRepetidos);
        }
    }
}