using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PuntoVenta
{
    internal class Program
    {
        static Item _item = new Item();
        static ItemDescuento _Idescuento = new ItemDescuento();
        static ItemTA _ItemTA = new ItemTA();
        static void Main(string[] args)
        {
            string archivo = @"C:\Users\Tichs\Documents\Introducción C#\Articulos.json";//Archivo json
            StreamReader jsonStream = new StreamReader(archivo);
            var json = jsonStream.ReadToEnd();
            jsonStream.Close();
            List<Articulo> _articulo = JsonConvert.DeserializeObject<List<Articulo>>(json);

            bool success = false;
            while (success == false)
            {
                Console.WriteLine("Ingrese una nueva venta");

                Console.WriteLine("\nIngrese al Id del articulo: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nIngrese la cantidad: ");
                decimal cantidad = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("\nIngrese si es articulo (1), articulo con descuento (2) o Tiempo Aire (3)");
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {

                    var ConsulArticulo = from articulo in _articulo
                                         where articulo.Id == id
                                         select articulo;


                    foreach (Articulo artic in ConsulArticulo)
                    {
                        _item.ID = artic.Id;
                        _item.Cantidad = cantidad;
                        _item.Precio = artic.Precio;
                        _item.Nombre = artic.Nombre;
                        

                        _item.imprimir();
                    }

                }else if(opcion == 2)
                {

                    _Idescuento.ID = id;
                    _Idescuento.Cantidad = cantidad;

                    Console.WriteLine("\nIngrese el Nombre del articulo");
                    _Idescuento.Nombre = Console.ReadLine();

                    Console.WriteLine("\nIngrese el precio del articulo");
                    _Idescuento.Precio = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("\nIngrese el descuento del articulo");
                    _Idescuento.descuento = decimal.Parse(Console.ReadLine());

                    _Idescuento.imprimir();

                } else if (opcion == 3)
                {
                    _ItemTA.ID = id;
                    _ItemTA.Cantidad = cantidad;

                    Console.WriteLine("\nIngrese el nombre de la compañia telefonica");
                    _ItemTA.Compania = Console.ReadLine();

                    Console.WriteLine("\nIngrese el numero telefonico");
                    _ItemTA.Telefono = Console.ReadLine();

                    Console.WriteLine("\nIngrese el precio de la recarga");
                    _ItemTA.Precio = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("\nIngrese la comision");
                    _ItemTA.Comision = decimal.Parse(Console.ReadLine());

                    _ItemTA.imprimir();


                }



                    Console.WriteLine("\n¿Desea Realizar una nueva venta? (V) (T)");
                string NewVenta = Console.ReadLine();

                if (NewVenta.Equals("T"))
                {
                    success = true;
                }

            }

               

            



        }
    }
}
