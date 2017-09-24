using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuRails.Models
{
    public class Coche
    {
        public Coche() { }

        public virtual int Id { get; set; }
        public virtual string Modelo { get; set; }
        public virtual bool EsLocomotora { get; set; }
        public virtual string TipoDeConsumo { get; set; } //TODO: Ver si es un enum. <- Si es un enum 
        public virtual int ConsumoMovimiento { get; set; }
        public virtual int ConsumoParado { get; set; }
        public virtual int MaximoLegalPasajeros { get; set; }
        public virtual int CapacidadMaximaPasajeros { get; set; }
    }
}
