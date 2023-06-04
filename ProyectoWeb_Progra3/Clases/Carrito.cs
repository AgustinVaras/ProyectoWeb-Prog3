using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Carrito
    {
        public Carrito(List<Articulo> lista) { articulos = lista; }

        public Carrito() { articulos = new List<Articulo>(); }

        private List <Articulo> articulos;
        private decimal monto;

        public List<Articulo> Articulos
        {
            set { articulos = value; }
            get { return articulos; }
        }
        public decimal Monto
        {
            set { monto = value; }
            get { return monto;  }
        }

        public decimal CalcularMonto()
        {
            monto = 0;
            foreach (Articulo art in articulos)
            {
                monto += art.Precio;
            }
            return monto;
        }

        public bool QuitarArticulo(int id)
        {
            foreach (Articulo art in articulos)
            {
                if (art.Id == id) articulos.Remove(art);
                return true;
            }
            return false;
        }

        ~Carrito()
        {
            articulos.Clear();
        }
    }
}
