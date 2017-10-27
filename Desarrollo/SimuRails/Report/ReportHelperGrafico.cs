using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuRails.Report
{
    class ReportHelperGrafico
    {
        public string Nombre { get; set; }
        public double Valor { get; set; }
        public ReportHelperGrafico(string nombre, double valor)
        {
            Nombre = nombre;
            Valor = valor;
        }

    }
}

