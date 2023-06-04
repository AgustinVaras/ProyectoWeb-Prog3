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
                    List<Articulo> ListaSinRepetidos = removeDuplicatesArticulo(ListaArticulo);
                    repArticulos.DataSource = ListaSinRepetidos;
                    repArticulos.DataBind();
                }
            }
        }

        protected void btnAgregarACarrito_Click(object sender, EventArgs e)
        {
            string id = ((Button)sender).CommandArgument;
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
                    List<Imagen> ListaSinRepetidos = removeDuplicatesImagen(ListaImagen); 
                    Repeater repImagenes = (Repeater)e.Item.FindControl("repImagenes");

                    repImagenes.DataSource = ListaSinRepetidos;
                    repImagenes.DataBind();
                }



            }
        }

        private List<Articulo> removeDuplicatesArticulo(List<Articulo> inputList)
        {
            Dictionary<string, string> uniqueStore = new Dictionary<string, string>();
            List<Articulo> finalList = new List<Articulo>();
            foreach (Articulo art in inputList)
            {
                if (!uniqueStore.ContainsKey(art.Codigo))
                {
                    uniqueStore.Add(art.Codigo, "0");
                    finalList.Add(art);
                }
            }
            return finalList;
        }


        private List<Imagen> removeDuplicatesImagen(List<Imagen> inputList)
        {
            Dictionary<string, string> uniqueStore = new Dictionary<string, string>();
            List<Imagen> finalList = new List<Imagen>();
            foreach (Imagen img in inputList)
            {
                if (!uniqueStore.ContainsKey(img.ImagenUrl))
                {
                    uniqueStore.Add(img.ImagenUrl, "0");
                    finalList.Add(img);
                }
            }
            return finalList;
        }
    }
}