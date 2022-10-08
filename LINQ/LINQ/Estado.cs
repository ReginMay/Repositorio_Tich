using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Estado
    {
        public Estado()
        {
        }

        public Estado(int id, string nombre)
        {
            id = id;
            nombre = nombre;
        }

        public int id { get; set; }
        public string nombre { get; set; }
   
    }

}
