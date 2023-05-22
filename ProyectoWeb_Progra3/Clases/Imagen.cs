using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Imagen
    {
        //Atributos
        private int id;
        private int idArticulo;
        private string imagenUrl;

        //Constructor
        public Imagen(int id, int idArticulo, string imagenUrl)
        {
            this.id = id;
            this.idArticulo = idArticulo;
            this.imagenUrl = imagenUrl; 
        }

        //Constructor vacio
        public Imagen()
        {

        }

        //Sobrecarga ToString();
        public override string ToString()
        {
            return imagenUrl;
        }

        //Propiedades set & get
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int IdArticulo
        { 
            get { return idArticulo; } 
            set { idArticulo = value; } 
        }
        public string ImagenUrl 
        {
            get { return imagenUrl; }
            set { imagenUrl = value; }
        }
    }
}
