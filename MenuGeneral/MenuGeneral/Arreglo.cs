using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class Arreglo
    {

        public static void Cadenas(string nombre)
        {
            nombre = nombre.Trim();

            string[] partesNombre = nombre.Split(' ');

            Console.WriteLine("Hola\n");

            //Funcion para que mediante un arreglo las partes de un string se puedan dividir y manipular

            foreach (string parte in partesNombre)
            {
                Console.WriteLine(parte+ "\n");
            }

            char[] letras = partesNombre[2].ToCharArray();

            foreach (char piezas in letras)
            {
                Console.WriteLine(piezas);
            }


        }

        public static void Enteros(int num1, int num2, int num3, int num4, int num5)
        {
            int[] arregloNumeros = { num1, num2, num3, num4, num5 };
            
            
            
                Console.WriteLine("\nEl numero mayor es: ");
                Console.WriteLine(arregloNumeros.Max());

        }
        public static void ConvierteATipoOracion(string oracion)
        {
            oracion = oracion.Trim();

            string[] partesOracion = oracion.Split(' ');

            int i = 0;

            Console.WriteLine("\nLa nueva oracion es: ");
            foreach (string parte in partesOracion)
            {
                //  char.ToUpper(parte[0]);
                Console.Write(char.ToUpper(parte[0]) + parte.Substring(1)+" ");
                i++;
            }

            

        }

    }
}
