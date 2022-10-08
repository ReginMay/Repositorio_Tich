using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public class Articulo
    {
        public Articulo()
        {
        }

        public Articulo(int id, string nombre, decimal precio, int tipo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Tipo = tipo;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Tipo { get; set; }
    }
    
}
