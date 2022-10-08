using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public class ItemDescuento : ItemBase
    {
        public ItemDescuento()
        {
        }
        public decimal descuento { get; set; }
        public decimal impDescuento {
            get { return Subtotal() * descuento; } 
        
        }

        public override decimal total()
        {
            decimal total = Subtotal() - impDescuento;

            return total;
        }
        public override void imprimir()
        {
            Console.WriteLine($"\n{ID} {Nombre} \nPrecio: {Precio} \ncantidad: {Cantidad} \nSubtotal: {Subtotal()} " +
                $"\n{descuento} \nTotal: {total()}");
        }
    }
}