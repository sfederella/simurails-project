using System;
using System.Collections.Generic;

namespace SimuRails.Models
{
    public class Formacion
    {
        public Formacion()
        {
            Coches = new List<Coche>();
        }

        public virtual int Id { get; protected set; }
        public virtual string Nombre { get; set; }
        public virtual IList<Coche> Coches { get; set; }

        public virtual int HoraSalida { get; set; }
        public virtual Servicio Servicio { get; set; }
        public virtual Estacion EstacionActual { get; set; }
        public virtual Estacion EstacionDestino { get; set; }
    }
}