using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public abstract class ItemBase
    {
        protected ItemBase()
        {
        }
        protected ItemBase(Articulo articulo, decimal cantidad)
        {
            ID = articulo.Id;
            Nombre = articulo.Nombre;
            Precio = articulo.Precio;
            Cantidad = cantidad;
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public decimal Cantidad { get; set; }

        public decimal Subtotal()
        {
            decimal Sudtotal = Precio * Cantidad;

            return Sudtotal;
        }

        public virtual decimal total()
        {
            decimal total = Precio * Cantidad;

            return total;
        }

        public abstract void imprimir();
    }
}
