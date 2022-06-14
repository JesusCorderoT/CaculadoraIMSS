using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraIMSS2
{
    public struct Aportaciones
    {
        public Aportaciones(decimal EnfermedadMaternidad, decimal InvalidezVida, decimal Retiro, decimal Cesantia, decimal Infonavit)
        {

            EM = EnfermedadMaternidad;
            IV = InvalidezVida;
            RT = Retiro;
            CS = Cesantia;
            IN = Infonavit;
        }

        public decimal EM { get; set; }
        public decimal IV { get; set; }
        public decimal RT { get; set; }
        public decimal CS { get; set; }
        public decimal IN { get; set; }

    }
}
