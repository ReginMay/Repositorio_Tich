using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritmeticas
{
    public struct OperacionesAritmetica
    {
        public OperacionesAritmetica(decimal operando1, decimal operando2,tipoOperacion tipoOperacion)
        {
            this.operando1 = operando1;
            this.operando2 = operando2;
            this.tipoOperacion = tipoOperacion;
        }
        public decimal operando1{ get; set; }
        public decimal operando2 { get; set; }
        public tipoOperacion tipoOperacion { get; set; }
    }
}
