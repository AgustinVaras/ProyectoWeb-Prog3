using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Articulo
    {
        //Constructor
        public Articulo(int id, int idMarca, int idCategoria, decimal precio, string nombre, string descripcion, string descripcionC, string codigo, string descripcionM)
        {
            this.id = id;
            this.idMarca = idMarca;
            this.descripcionM = descripcionM;
            this.idCategoria = idCategoria;
            this.precio = precio;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.codigo = codigo;
            this.descripcionC = descripcionC;
        }
        //Constructor vacio
        public Articulo()
        {

        }
        
        //Propiedades
        private int id;
        private string nombre;
        private string descripcion;
        private decimal precio;
        private int idMarca;
        private int idCategoria;
        private string descripcionM;
        private string codigo;
        private string descripcionC;


        //Propiedades set & get
       
        public string Descripcionm
        {
            get { return descripcionM; } 
            set { descripcionM = value;  }
        }
        
        public string Descripcionc 
        {
            get { return descripcionC;} 
            set { descripcionC = value; } 
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int IdMarca
        {
            get { return idMarca; }
            set { idMarca = value; }
        }
        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }
        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        
        public string Codigo 
        {
            get { return codigo; }
            set { codigo = value; }
        
        }
    }
}
