using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Presentacion
    {
        public static string Saludo()
        {
            //Rafael Alberto Amaya Sanchea
            string nombre;

            Console.WriteLine("Cual es tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola como estas " + nombre + "?");
            
            
            return nombre;
        }
    }
}
