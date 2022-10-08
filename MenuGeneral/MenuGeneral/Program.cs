using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el numero de la opcion a elegir");
            int contador = 1;

            do {

                Console.WriteLine("\n1. Invocar metodo Cadenas");
                Console.WriteLine("2. Invocar metodo Enteros");
                Console.WriteLine("3. Invocar metodo ConvierteATipoOracion");
                Console.WriteLine("4. Invocar metodo Poliza");
                Console.WriteLine("5. Invocar metodo ArchivoTXT");
                Console.WriteLine("6. Invocar metodo EscribirTXT");
                Console.WriteLine("7. Invocar metodo el metodo ISR");
                Console.WriteLine("8. Condiciones");
                Console.WriteLine("9. Ciclos");
                Console.WriteLine("F para salir");


                Console.WriteLine("\nSeleccione una Opcion");
                string opcionElegida = Console.ReadLine();

                //Esta coversion ayuda a detectar los datos de tipo string si se pueden co0nvertir a de tipo INT
                int num;
                bool valido = int.TryParse(opcionElegida, out num);
                try
                {
                    //------------------------------------------------------------------------------------//
                    if (opcionElegida.Equals("F")) { 

                    break;
                }
                else if (opcionElegida.Equals("")) { 

                    Console.WriteLine("\nNo ha seleccionado ninguna opcion");
                    Console.WriteLine("\nPresione cualquier tecla para continuar");
                    Console.ReadKey();
                    }

                else 
                { 
                    switch (int.Parse(opcionElegida))
                    {
                        case 1:
                                Console.WriteLine("\nProporciona tu nombre completo");
                                Arreglo.Cadenas(Console.ReadLine());
                                break;
                        case 2:
                                Console.WriteLine("\nEscribe 5 numeros");
                                Console.WriteLine("numero 1: ");
                                string num1 = Console.ReadLine();
                                Console.WriteLine("numero 2: ");
                                string num2 = Console.ReadLine();
                                Console.WriteLine("numero 3: ");
                                string num3 = Console.ReadLine();
                                Console.WriteLine("numero 4: ");
                                string num4 = Console.ReadLine();
                                Console.WriteLine("numero 5: ");
                                string num5 = Console.ReadLine();
                                Arreglo.Enteros(int.Parse(num1), int.Parse(num2), int.Parse(num3), int.Parse(num4), int.Parse(num5));
                                break;

                        case 3:
                                Console.WriteLine("\nEscribe la oración que desees convertir");
                                Arreglo.ConvierteATipoOracion(Console.ReadLine());
                                break;

                        case 4:
                                Console.WriteLine("\nConsultar Poliza");
                                Poliza.Presentacion();
                            break;
                        case 5:
                                Archivotxt.Presentacion();
                                break;
                        case 6:
                                Console.WriteLine("\nEscribe el nombre de la Ruta del archivo .txt");
                                string Ruta3 = Console.ReadLine();
                                Console.WriteLine("\n¿El archivo será nuevo?");
                                string esNew = Console.ReadLine();
                                Console.WriteLine("\n¿En que codigo se quiere escribir? ejem: UTF7,UTF8,Unicod,UTF32, ASCII");
                                string codigo = Console.ReadLine();

                                Archivotxt.EscribirTxt(Ruta3, esNew, codigo);
                                break;
                        case 7:
                                Console.WriteLine("\nAgregar Sueldo al mes");
                                decimal sueldo = decimal.Parse(Console.ReadLine());
                                Console.WriteLine("\nEscribir nombre de la Tabla");
                                string archivo = Console.ReadLine();
                                ISR.CargarTabla(sueldo,archivo);
                            break;
                        case 8:
                                Console.WriteLine("\nFactor");
                                Console.WriteLine("\nSeleccione Edad");
                                string edad = Console.ReadLine();
                                Console.WriteLine("\nSeleccione Genero");
                                string genero = Console.ReadLine();
                                decimal factor =
                                Poliza.arreglofactor(int.Parse(edad), genero);
                                Console.WriteLine(factor.ToString());

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
