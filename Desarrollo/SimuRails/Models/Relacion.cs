using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuRails.Models
{
    public class Relacion
    {
        public Relacion() { }

        public virtual int Id { get; protected set; }
        public virtual int Distancia { get; set; }
        public virtual int VelocidadPromedio { get; set; }
        public virtual int TiempoViaje { get; set; }
    }
}
