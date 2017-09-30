using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuRails.Models
{
    public class ComposicionDeCoches
    {
        public ComposicionDeCoches(Coche coche, int vecesRepetido)
        {
            Coche = coche;
            VecesRepetido = vecesRepetido;
        }

        public ComposicionDeCoches() { }

        public virtual int Id { get; set; }

        public virtual Coche Coche { get; set; }

        public virtual int VecesRepetido { get; set; }

    }
}
