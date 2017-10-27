using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuRails.Report
{
    class ReportHelperValorIdaVuelta
    {
        public string Nombre { get; set; }

        private double pValorIda;
        public double ValorIda
        {
            get
            {
                return pValorIda;
            }
            set
            {
                if (value > 0) { pValorIda = value; } else { pValorIda = 0; }
            }
        }
        private double pValorVuelta;
        public double ValorVuelta
        {
            get
            {
                return pValorVuelta;
            }
            set
            {
                if (value > 0) { pValorVuelta = value; } else { pValorVuelta = 0; }
            }
        }
        public ReportHelperValorIdaVuelta(string nombre, double valorIda, double valorVuelta)
        {
            Nombre = nombre;
            ValorIda = valorIda;
            ValorVuelta = valorVuelta;
        }

    }
}

