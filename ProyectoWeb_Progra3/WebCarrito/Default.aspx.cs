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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ImagenesDatos imagen = new ImagenesDatos();
            List<Imagen> ListaSinRepetidos = imagen.removeDuplicadosImagen(imagen.Listar());

            imgCarousel1.ImageUrl = ListaSinRepetidos[0].ImagenUrl;
            imgCarousel2.ImageUrl = ListaSinRepetidos[2].ImagenUrl;
            imgCarousel3.ImageUrl = ListaSinRepetidos[3].ImagenUrl;
            imgCarousel1.DataBind();
        }
    }
}