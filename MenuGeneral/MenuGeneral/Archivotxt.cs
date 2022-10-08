using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class Archivotxt
    {

        public static void Presentacion()
        {
            Console.WriteLine("\nEscribe el nombre del archivo .txt");
            string Ruta = Console.ReadLine();
            MostrarTxt(Ruta);

            Console.WriteLine("\nEscribe el nombre del archivo .csv");
            string Ruta2 = Console.ReadLine();
            MostrarTxt(Ruta2);


        }
        public static void MostrarTxt(string nombreArchivo)
        {
            nombreArchivo = nombreArchivo.Trim();

            string linea;

            StreamReader archivo = new StreamReader(@"C:\Users\Tichs\Documents\Introducción C#\"+nombreArchivo);
            linea = archivo.ReadToEnd();
            Console.WriteLine(linea);
            archivo.Close();
            Console.ReadKey();

        }

        public static void MostrarCsv(string nombreArchivo)
        {
            nombreArchivo = nombreArchivo.Trim();

            string linea;

            StreamReader archivo = new StreamReader(@"C:\Users\Tichs\Documents\Introducción C#\" + nombreArchivo);


            Console.WriteLine("---Tabla del archivo .csv-- ");

            do{

                linea = archivo.ReadLine();
                Console.WriteLine(linea);

            } while (linea != null) ;

            archivo.Close();

            Console.ReadKey();

        }

        public static void EscribirTxt(string nombreDeRuta, string esNuevo,string codigo)
        {
            nombreDeRuta = nombreDeRuta.Trim();
            esNuevo = esNuevo.Trim();
            codigo = codigo.Trim();

            bool existe = true;

            Encoding codig = Encoding.ASCII;

            if (codigo.Equals("UTF7"))
            {
                codig = Encoding.UTF7;
            }
            if (codigo.Equals("UTF8"))
            {
                codig = Encoding.UTF8;
            }
            if (codigo.Equals("Unicod"))
            {
                codig = Encoding.Unicode;
            }
            if (codigo.Equals("UTF32"))
            {
                codig = Encoding.UTF32;
            }
            if (codigo.Equals("ASCII"))
            {
                codig = Encoding.ASCII;
            }

            if (esNuevo.Equals("no")) { existe = false; }

            //if (File.Exists(nombreDeRuta))
            //{
            //   Console.WriteLine("El archivo {0} ya existe", nombreDeRuta);
            //   StreamWriter archivo = new StreamWriter(@nombreDeRuta,true);
            //}
            //else
            //{}
            StreamWriter archivo = new StreamWriter(@nombreDeRuta,existe,codig);
            

            bool siOno = true;
            
            do
            {
                
                Console.WriteLine("\nEscribir el nombre del Alumno");
                string nombreAlum = Console.ReadLine();
                Console.WriteLine("Escribir el Primer Apelldo");
                string primerApe = Console.ReadLine();
                Console.WriteLine("Escribir el Segundo Apellido");
                string segunApe = Console.ReadLine();
                Console.WriteLine("Escribir la edad");
                string edad = Console.ReadLine();
                Console.WriteLine("Escribir el estado");
                string estado = Console.ReadLine();
                archivo.WriteLine(nombreAlum + "," + primerApe + "," + segunApe + "," + edad + "," + estado);
                Console.WriteLine("\n¿Desea agregar otro registro?");
                string otro = Console.ReadLine();

                if (otro.Equals("no")) { siOno = false; }
                    
            } while (siOno == true);

            Console.WriteLine("\nRegistro Exitoso");

            archivo.Close();
            Console.ReadKey();

        }
    }
}
