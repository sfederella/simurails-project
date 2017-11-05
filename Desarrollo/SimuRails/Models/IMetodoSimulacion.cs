using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuRails.Models
{
    public interface IMetodoSimulacion
    {
        bool EjecutarSimulacion(Traza traza, long tiempoFinal, BackgroundWorker backgroundWorker);
    }
}
