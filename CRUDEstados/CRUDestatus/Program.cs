using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDestatus
{
    internal class Program
    {
        static CRUDAlum _CruAlu = new CRUDAlum();
        static AlumnosStatus _status = new AlumnosStatus();
        static int _id = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el numero de la opcion a elegir");
            int contador = 1;

            do
            {

                Console.WriteLine("\n1. Consultar Estatus");
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
                                List<AlumnosStatus> _listStatus = _CruAlu.consultarTodos();
                                
                                foreach (AlumnosStatus cadena in _listStatus)
                                {
                                    Console.WriteLine($"El id es: {cadena.Id} La calve es: {cadena.clave} El nombre es: {cadena.nombre}");
                                }
                                break;
                            case 2:
                                Console.WriteLine("\nIngresa el id del estado a consultar");
                                _id = Convert.ToInt32(Console.ReadLine());
                                _status = _CruAlu.consultarUno(_id);
                                Console.WriteLine($"id: {_status.Id} clave: {_status.clave} nombre: {_status.nombre}");


                                break;

                            case 3:
                                _status = new AlumnosStatus();
                                Console.WriteLine("Ingreesa el id del status a agregar");
                                _status.Id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingreesa la clave del status a agregar");
                                _status.clave = char.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el nombre del status a agregar");
                                _status.nombre = Console.ReadLine();
                                _CruAlu.Agregar(_status);
                                Console.WriteLine();

                                break;

                            case 4:
                                _status = new AlumnosStatus();
                                Console.WriteLine("Ingreesa el id del estatus a actualizar");
                                _status.Id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingreesa la clave del status a actualizar");
                                _status.clave = char.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese el nombre del status a actualizar");
                                _status.nombre = Console.ReadLine();
                                _CruAlu.Actualizar(_status);
                                break;
                            case 5:
                                Console.WriteLine("Ingresa el id del estado a eliminar");
                                _id = Convert.ToInt32(Console.ReadLine());
                                _CruAlu.Eliminar(_id);
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
