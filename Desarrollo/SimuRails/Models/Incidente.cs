using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuRails.Models
{
    public class Incidente
    {
        public Incidente() { }

        // Persistentes
        public virtual int Id { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual double ProbabilidadDeOcurrencia { get; set; }
        public virtual int TiempoDemora { get; set; }
    }
}
