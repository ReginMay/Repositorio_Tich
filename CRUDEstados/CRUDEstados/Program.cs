using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstados
{
    internal class Program
    {
        static Crud _objCRUDEstados = new Crud();
        static int _id = 0;
        static Estado _estado = new Estado();
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el numero de la opcion a elegir");
            int contador = 1;

            do
            {

                Console.WriteLine("\n1. Consultar Estados");
                Console.WriteLine("2. Consultar solo uno");
                Console.WriteLine("3. Agregar");
                Console.WriteLine("4. Actualizar");
                Console.WriteLine("5. Eliminar");
                Console.WriteLine("F para salir");


                Console.WriteLine("\nSeleccione una Opcion");
                string opcionElegida = Console.ReadLine();

                //Esta coversion ayuda a detectar los datos de tipo string si se pueden co0nvertir a de tipo INT
                int num;
                bool valido = int.TryParse(opcionElegida, out num);
                try
                {
                    //------------------------------------------------------------------------------------//
                    if (opcionElegida.Equals("F"))
                    {

                        break;
                    }
                    else if (opcionElegida.Equals(""))
                    {

                        Console.WriteLine("\nNo ha seleccionado ninguna opcion");
                        Console.WriteLine("\nPresione cualquier tecla para continuar");
                        Console.ReadKey();
                    }

                    else
                    {
                        switch (int.Parse(opcionElegida))
                        {
                            case 1:
                                Dictionary<int, Estado> _DiccionariyEstados = _objCRUDEstados.consultarTodos();
                                foreach (KeyValuePair<int, Estado> kvp in _DiccionariyEstados)
                                {
                                    Console.WriteLine("key={0}, Value={1}", kvp.Key, kvp.Value.nombre);
                                }
                                break;
                            case 2:
                                Console.WriteLine("\nIngresa el id del estado a consultar");
                                _id = Convert.ToInt32(Console.ReadLine());
                                _estado = _objCRUDEstados.consultarUno(_id);
                                Console.WriteLine($"id: {_estado.Id} nombre: {_estado.nombre}");


                                break;

                            case 3:
                                //_estado = new Estado();
                                Console.WriteLine("Ingreesa el id del estado a agregar");
                                _estado.Id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el nombre del estado a agregar");
                                _estado.nombre = Console.ReadLine();
                                _objCRUDEstados.Agregar(_estado);
                                Console.WriteLine();
                                
                                break;

                            case 4:
                                //Estado estado2 = new Estado();
                                Console.WriteLine("Ingreesa el id del estado a actualizar");
                                _estado.Id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el nombre del estado a actualizar");
                                _estado.nombre = Console.ReadLine();
                                _objCRUDEstados.Actualizar(_estado);
                                break;
                            case 5:
                                Console.WriteLine("Ingresa el id del estado a eliminar");
                                _id = Convert.ToInt32(Console.ReadLine());
                                _objCRUDEstados.Eliminar(_id);
                                break;

                            default:
                                Console.WriteLine("\nOpcion no valida");
                                break;


                        }
                        Console.WriteLine("\nPresione cualquier tecla para continuar");
                        Console.ReadKey();

                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nOpcion no valida");
                    Console.WriteLine("\nPresione cualquier tecla para continuar");
                    Console.ReadKey();
                }


            } while (contador > 0);



        
        }
    }
}
