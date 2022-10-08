using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSS
{
    public struct Aportaciones
    {
        public Aportaciones(decimal EnfermedadMaternidad, decimal InvalidezVida, decimal Retiro, decimal Cesantia, decimal Infonavit)
        {
            this.EnfermedadMAternidad = EnfermedadMaternidad;
            this.InvalidezVida = InvalidezVida;
            this.Retiro = Retiro;
            this.Cesantia = Cesantia;
            this.Infonavit = Infonavit;
        }
        public decimal EnfermedadMAternidad { get; set; }
        public decimal InvalidezVida { get; set; }
        public decimal Retiro { get; set; }
        public decimal Cesantia { get; set; }
        public decimal Infonavit { get; set; }
    }
}
