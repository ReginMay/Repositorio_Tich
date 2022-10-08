using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public class Item : ItemBase
    {
        public Item()
        {
        }

        public override void imprimir()
        {
            Console.WriteLine($"{ID} {Nombre} \nPrecio: {Precio} \ncantidad: {Cantidad} \nSubtotal: {Subtotal()} \nTotal: {total()}");
        }
    }
}
