using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    public struct PolizaResultado
    {
        public PolizaResultado(DateTime fecha, decimal prima)
        {
            this.fecha = fecha;
            this.prima = prima;
        }


        public DateTime fecha { get; set; }
        public decimal prima { get; set; }
        }
}
