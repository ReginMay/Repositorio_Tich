using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDestatus
{
    internal class AlumnosStatus
    {
        public AlumnosStatus()
        {
        }
        public AlumnosStatus(int id, string nombre,char clave)
        {
            this.Id = id;
            this.nombre = nombre;
            this.clave = clave;
        }

        public int Id { get; set; }
        public char clave { get; set; }
        public string nombre { get; set; }

    }
}
