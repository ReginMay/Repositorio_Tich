using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSS
{
    internal class CalculadoraIMSS
    {
        public static Aportaciones Calcular(decimal salario, decimal unidad, int patron)
        {
            Aportaciones Aaportaciones = new Aportaciones();
            if (patron == 1)
            {
                Aaportaciones.EnfermedadMAternidad = (salario - (unidad * 3m)) * 0.011m;
                Aaportaciones.InvalidezVida = salario * 0.0175m;
                Aaportaciones.Retiro = salario * 0.02m;
                Aaportaciones.Cesantia = salario * 0.0315m;
                Aaportaciones.Infonavit = salario * 0.05m;
            }
            else 
            {
                Aaportaciones.EnfermedadMAternidad = (salario - (unidad * 3m)) * 0.004m;
                Aaportaciones.InvalidezVida = salario * 0.00625m;
                Aaportaciones.Retiro = salario * 0.00m;
                Aaportaciones.Cesantia = salario * 0.01125m;
                Aaportaciones.Infonavit = salario * 0.0m;
            }
            return Aaportaciones;
        }
        public static void Presentacion()
        {

            //declaracion de variables
            decimal salario = 0m;
            decimal unidad = 0m;
            int patron = 0;
            Console.WriteLine("Ingrese su salario a Cotizar: ");
            salario = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la UMA: ");
            unidad = decimal.Parse(Console.ReadLine());
            Console.WriteLine(" Seleccione: \n 1.- Patron \n 2.- Empleado");
            patron = int.Parse(Console.ReadLine());

            //instanciando a la estructura aportaciones  y al metodo calcular
            Aportaciones resultado = new Aportaciones();
            resultado = Calcular(salario, unidad, patron);
            Console.WriteLine("El resultado de la Enfermedad es: " + resultado.EnfermedadMAternidad.ToString("C2"));//ToString c2 conversion a moneda
            Console.WriteLine("\nEl resultado de Invalidez es: " + resultado.InvalidezVida.ToString("C2"));
            Console.WriteLine("\nEl resultado de Retiro es: " + resultado.Retiro.ToString("C2"));
            Console.WriteLine("\nEl resultado de Cesantia es: " + resultado.Cesantia.ToString("C2"));
            Console.WriteLine("\nEl resultado del Infonavit es: " + resultado.Infonavit.ToString("C2"));
            Console.WriteLine("\nEl total es: " + (resultado.EnfermedadMAternidad + resultado.InvalidezVida + resultado.Retiro +
            resultado.Cesantia + resultado.Infonavit).ToString("C2"));

            Console.ReadKey();

        }
    }
}
