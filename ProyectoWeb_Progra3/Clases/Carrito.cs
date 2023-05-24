using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Carrito
    {
        public Carrito(List<Articulo> lista) { articulos = lista; }

        public Carrito() { articulos = new List<Articulo>(); }

        private List <Articulo> articulos;
        private decimal monto;

        public List<Articulo> Articulos
        {
            get { return articulos; }
        }
        public decimal Monto
        {
            set { monto = value; }
            get { return monto;  }
        }

        public void CalcularMonto()
        {
            monto = 0;
            foreach (Articulo art in articulos)
            {
                monto += art.Precio;
            }
        }

        ~Carrito()
        {
            articulos.Clear();
        }
    }
}
