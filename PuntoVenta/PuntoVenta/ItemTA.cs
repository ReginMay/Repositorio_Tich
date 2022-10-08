using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public class ItemTA : ItemBase
    {
        public ItemTA()
        {
        }
        public string Telefono { get; set; }
        public string Compania { get; set; }
        public decimal Comision { get; set; }

        public override decimal total()
        {
            decimal total = Subtotal() + Comision;

            return total;
        }
        public override void imprimir()
        {
            Console.WriteLine($"\n{ID} \nTiempo Aire \nPrecio: {Precio} \nCantidad: {Cantidad} " +
                $"\nSubtotal: {Subtotal()} \nTelefono: {Telefono} \nCompañia: {Compania} \nComision: {Comision} \nTotal: {total()}");
        }
    }
}