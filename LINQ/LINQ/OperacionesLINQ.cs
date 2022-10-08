using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace LINQ
{
    internal class OperacionesLINQ
    {
       // public Alumno _alum = new Alumno();
       public List<Estado> _TablaEstados = new List<Estado>();


        public void CargarList()
        {

            string archivo = @"C:\Users\Tichs\Documents\Introducción C#\Estados.json";//Archivo json
            StreamReader jsonStream = new StreamReader(archivo);
            var json = jsonStream.ReadToEnd();
            jsonStream.Close();
            List<Estado> _estados = JsonConvert.DeserializeObject<List<Estado>>(json);

            Console.WriteLine("Estado con el id = 5");

            var ConsulEstado = from nombre in _estados
                               where nombre.id == 5
                               select nombre;
            foreach (Estado estado in ConsulEstado)
            {
                Console.WriteLine($"{estado.id} {estado.nombre} ");
            }

            archivo = @"C:\Users\Tichs\Documents\Introducción C#\Alumnos.json";// Archivo json
            jsonStream = new StreamReader(archivo);
            json = jsonStream.ReadToEnd();
            jsonStream.Close();

            List<Alumno> _alumnos = JsonConvert.DeserializeObject<List<Alumno>>(json);

            Console.WriteLine("\nConsulta de alumnos donde su IdEstado = 29 o 13 ");

            var ConsulAlumnos = from alumno in _alumnos
                                where alumno.idEstado == 29 || alumno.idEstado == 13
                                orderby alumno.nombre
                                select alumno;

            foreach (Alumno alumn in ConsulAlumnos)
            {
                Console.WriteLine($"{alumn.id} {alumn.nombre} {alumn.calificacion} {alumn.idEstado} {alumn.idEstatus} ");
            }

            Console.WriteLine("\nConsulta de alumnos donde su IdEstado = 19 o 20 y su id Estatus = 4 o 5");

            var ConsulAlumnos2 = from alumno in _alumnos
                                 where alumno.idEstado == 29 || alumno.idEstado == 13
                                 && alumno.idEstatus == 2 || alumno.idEstatus == 5
                                 orderby alumno.nombre
                                 select alumno;

            foreach (Alumno alumn in ConsulAlumnos2)
            {
                Console.WriteLine($"{alumn.id} {alumn.nombre} {alumn.calificacion} {alumn.idEstado} {alumn.idEstatus} ");
            }

            Console.WriteLine("\nConsulta de alumnos que tienen una calificion aprobatoria mayor a 6");

            var ConsulAlumnos3 = from alumno in _alumnos
                                 where alumno.calificacion > 6
                                 orderby alumno.calificacion descending
                                 select alumno;

            foreach (Alumno alumn in ConsulAlumnos3)
            {
                Console.WriteLine($"{alumn.nombre} {alumn.calificacion} ");
            }

            Console.WriteLine("\nConsulta del promedio de los alumnos");

            var ConsulAlumnos4 = from alumno in _alumnos
                                 select alumno.calificacion;

            Console.WriteLine($"{ConsulAlumnos4.Average()} ");

            Console.WriteLine("\nConsulta de los alumnos que tengan calificacion(sumar 1 punto o 2 puntos)");

            var ConsulAlumnos5 = from alumno in _alumnos
                                 select alumno;

            bool any10 = _alumnos.All(x => x.calificacion == 10);

            if (any10 == true)
            {
                foreach (Alumno alumn in ConsulAlumnos5)
                {


                    if (alumn.calificacion >= 8)
                    {
                        Console.WriteLine($"{alumn.nombre} {alumn.calificacion + 1} ");

                    }
                    if (alumn.calificacion == 6 || alumn.calificacion == 7)
                    {
                        Console.WriteLine($"{alumn.nombre} {alumn.calificacion + 2} ");
                    }

                }

            }
            else
            {
                Console.WriteLine("\nExiste un alumno con calificacion de 10");
            }
  
            archivo = @"C:\Users\Tichs\Documents\Introducción C#\Estatus.json";//Archivo json
            jsonStream = new StreamReader(archivo);
            json = jsonStream.ReadToEnd();
            jsonStream.Close();

            List<Estado> _estadoss = JsonConvert.DeserializeObject<List<Estado>>(json);

            Console.WriteLine("\nConsulta de alumnos donde su idEstatus = 3");

            var ConsulAlumnos6 = from alumno in _alumnos
                                 join estad in _estadoss on
                                 alumno.idEstado equals estad.id
                                 where alumno.idEstatus == 3
                                 orderby alumno.nombre
                                 select new
                                 {
                                     idNombre = alumno.id,
                                     nombreAlumno = alumno.nombre,
                                     statusNombre = estad.nombre,
                                     idestatu = alumno.idEstatus
                                 };

            foreach (var alumn in ConsulAlumnos6)
            {
                Console.WriteLine($"{alumn.idNombre} {alumn.nombreAlumno} {alumn.statusNombre} {alumn.idestatu}");
            }


            //List<Estatus> _estatus = JsonConvert.DeserializeObject<List<Estatus>>(json);

            //Console.WriteLine("\nConsulta de alumnos donde su idEstatus = 2");

            //var ConsulAlumnos7 = from alumno in _alumnos
            //                     join estatu in _estatus on
            //                     alumno.idEstatus equals estatu.id
            //                     where alumno.idEstatus == 2
            //                     orderby alumno.nombre
            //                     select new {idNombre = alumno.id,nombreAlumno = alumno.nombre, 
            //                     statusNombre = estatu.nombre, idestatu = alumno.idEstatus};

            //foreach (var alumn in ConsulAlumnos7)
            //{
            //    Console.WriteLine($"{alumn.idNombre} {alumn.nombreAlumno} {alumn.statusNombre} {alumn.idestatu}");
            //}


            Console.ReadKey();


            
                               




            //XmlSerializer serializer = new XmlSerializer(typeof(List<Alumno>), new XmlRootAttribute("Alumnos"));
            //Stream reader = new FileStream(@"C:\Users\Tichs\Documents\Introducción C#\Alumnos.json", FileMode.Open);
            //listAlumnos = (List<Alumno>) serializer.Deserialize(reader);
            //reader.Close();



        }

        public void Consultas()
        {
            




        }
    }
}
