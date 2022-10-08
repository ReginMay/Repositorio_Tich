using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class Poliza
    {
        
        public static void Presentacion()
        {
            DateTime fechaInicio;
            decimal sumaAsegurada;
            DateTime fechaNacimiento;
            string genero; 

            Console.WriteLine("Proporciona la fecha de inicio de vigencia:");
            fechaInicio = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Proporciona para cuanto tiempo requieres la Poliza (ejemplo 2 años):");
            string cadena = Console.ReadLine();
            Console.WriteLine("Proporciona la suma asegurada:");
            sumaAsegurada = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Proporciona la fecha de Nacimiento del asegurado:");
            fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Proporciona el género del asegurado:");
            genero = Console.ReadLine();

            //////////////////////////////////

            int espacios = (cadena.Split(' ')).Length;

            string[] generoDias = new string[espacios];
            generoDias = cadena.Split(' ');
            char[] letras = cadena.ToCharArray();
            Console.WriteLine();
            for (int i = 0; i < espacios; i++)
            {
            }
            int Days = int.Parse(generoDias[0]);
            String Meses = generoDias[1];

            decimal periodo = 0;

            string MAY = Meses;
            switch (MAY)
            {
                case "dias":
                    periodo = Days;
                    break;
                case "Mes":
                case "Meses":
                case "mes":
                case "meses":
                    periodo = Days * 30;
                    break;
                case "Año":
                case "Años":
                case "año":
                case "años":
                    periodo = Days * 360;
                    break;
                default:
                    Console.WriteLine($"Un valor inesperado");
                    break;
            }

            /////////////////////////////////

            //sacar la edad mediante la fecha de nacimiento
            decimal edad = DateTime.Today.AddTicks(-fechaNacimiento.Ticks).Year - 1;
            //Console.WriteLine(edad);

            Calcular(fechaInicio,periodo,sumaAsegurada,edad,genero);
        }



        public static void Calcular(DateTime fechaInicioVigencia, decimal periodo,
            decimal sumaAsegurada,decimal edad, string genero
            )
        {


            PolizaResultado polizaResultado = new PolizaResultado();

            polizaResultado.prima = (sumaAsegurada * arreglofactor(edad,genero)*(periodo/360));
            polizaResultado.fecha = fechaInicioVigencia.AddDays(((int)periodo));


            Console.WriteLine("La poliza Vecerá: ");
            Console.WriteLine(polizaResultado.fecha);
            Console.WriteLine("La prima a pagar: ");
            Console.WriteLine(polizaResultado.prima);
        }

        public static decimal arreglofactor(decimal edad, string genero)
        {
            decimal factor = 0;

            decimal[,] tablaFactor = new decimal[,] {
                {0,20,1,0.05m},
                {21,30,1,0.1m},
                {31,40,1,0.4m},
                {41,50,1,0.5m},
                {51,60,1,0.65m},
                {61,120,1,0.85m},
                {0,20,2,0.05m},
                {21,30,2,0.1m},
                {31,40,2,0.4m},
                {41,50,2,0.55m},
                {51,60,2,0.7m},
                {61,120,2,0.9m}
            };

            if (genero.Equals("Femenino")) { 

                if (edad < 21)
                {
                    factor = tablaFactor[0,3];

                }
                else if (edad > 20 && edad < 31)
                {
                    factor = tablaFactor[1, 3];

                }
                else if (edad > 30 && edad < 41)
                {
                    factor = tablaFactor[2, 3];
                }
                else if (edad > 40 && edad < 51)
                {
                    factor = tablaFactor[3, 3];
                }
                else if (edad > 50 && edad < 61)
                {
                    factor = tablaFactor[4, 3];
                }
                else if (edad > 60)
                {
                    factor = tablaFactor[5, 3];
                }

            } else if(genero.Equals("Masculino")) {

                if (edad < 21)
                {
                    factor = tablaFactor[6, 3];

                }
                else if (edad > 20 && edad < 31)
                {
                    factor = tablaFactor[7, 3];

                }
                else if (edad > 30 && edad < 41)
                {
                    factor = tablaFactor[8, 3];
                }
                else if (edad > 40 && edad < 51)
                {
                    factor = tablaFactor[9, 3];
                }
                else if (edad > 50 && edad < 61)
                {
                    factor = tablaFactor[10, 3];
                }
                else if (edad > 60)
                {
                    factor = tablaFactor[11, 3];
                }

            }
            return factor;
        }
    }
}
