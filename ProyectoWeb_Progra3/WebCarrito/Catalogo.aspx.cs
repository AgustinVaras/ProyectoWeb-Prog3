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
        public List<Articulo> ListaCarrito = new List<Articulo>();

        protected void Page_Load(object sender, EventArgs e)
        {
            DatosDeArticulos articulo = new DatosDeArticulos();

            if(!IsPostBack)
            {
                if (Request.QueryString.AllKeys.Contains("categoriaArt"))
                {
                    string categoria = Request.QueryString["categoriaArt"].ToString();
                    List<Articulo> ListaSinRepetidos = articulo.removeDuplicadosArticulo(articulo.Buscar(categoria, "IdCategoria"));
                    repArticulos.DataSource = ListaSinRepetidos;
                    repArticulos.DataBind();
                }

                if (Request.QueryString.AllKeys.Contains("marcaArt"))
                {
                    string marca = Request.QueryString["marcaArt"].ToString();
                    List<Articulo> ListaSinRepetidos = articulo.removeDuplicadosArticulo(articulo.Buscar(marca, "IdMarca"));
                    repArticulos.DataSource = ListaSinRepetidos;
                    repArticulos.DataBind();
                }           

                if (!Request.QueryString.AllKeys.Contains("marcaArt") && !Request.QueryString.AllKeys.Contains("categoriaArt"))
                {
                    List<Articulo> ListaSinRepetidos = articulo.removeDuplicadosArticulo(articulo.listar());
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

            if(ListaArticulo != null)
            {
                if (Session["articulosAgregados"] == null)
                {                    
                    ListaCarrito.Add(ListaArticulo.First());
                    Session.Add("articulosAgregados", ListaCarrito);                    
                }
                else
                {
                    ListaCarrito = (List <Articulo>)Session["articulosAgregados"];
                    ListaCarrito.Add(ListaArticulo.First());
                    Session.Add("articulosAgregados", ListaCarrito);
                }              
            }
        }
    }
}