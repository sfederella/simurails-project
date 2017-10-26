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
        public double ValorIda { get; set; }
        public double ValorVuelta { get; set; }
        public ReportHelperValorIdaVuelta(string nombre, double valorIda, double valorVuelta)
        {
            Nombre = nombre;
            ValorIda = valorIda;
            ValorVuelta = valorVuelta;
        }

    }
}

