using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuRails.Models
{
    public class Simulacion
    {
        public Simulacion() { }

        public virtual int Id { get; protected set; }
        public virtual string Nombre { get; set; }
        public virtual int FrecuenciaDeSalida { get; set; }
    }
}
