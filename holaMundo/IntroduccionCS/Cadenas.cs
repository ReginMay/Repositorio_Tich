using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCS
{
    internal class Cadenas
    {
        public static string Holamundo()
        {
            //Rafael Alberto Amaya Sanchea
            string nombre;
            string apellido1;
            string apellido2;
            int edad;
            string ruta = "c:\\Documentos\\DiplomadoNet";


            
            Console.WriteLine("Proporciona tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Proporciona tu primer apellido");
            apellido1 = Console.ReadLine();
            Console.WriteLine("Proporciona tu segundo apellido");
            apellido2 = Console.ReadLine();
            Console.WriteLine("Proporciona tu edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Hola " + nombre +" "+ apellido1 +" "+ apellido2);
            Console.WriteLine("{0} {1} {2} Tiene {3} años",
                nombre, apellido1,apellido2, edad);
            Console.WriteLine($"Gusto en conocerte  " +
                $"{nombre.ToUpper()} {apellido1.ToUpper()} {apellido2.ToUpper()}");
            Console.WriteLine("El archivo fue almacenado en: "+ruta+ "\\" + nombre.Trim() + apellido1.Trim() + apellido2.Trim()+".docx");

            string completo = nombre.Trim() +" "+ apellido1.Trim() +" "+ apellido2.Trim()+" "+edad;



            return completo;
        }
    }
}
