using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstados
{
    internal struct Estado
    {
        //public Estado()
        //{
        //}

        public Estado(int id, string nombre)
        {
            this.Id = id;
            this.nombre = nombre;
        }

        public int Id { get; set; }
        public string nombre { get; set; }
    }
    
    }
