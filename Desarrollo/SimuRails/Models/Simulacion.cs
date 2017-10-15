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

        public virtual int Id { get; set; }
        public virtual string Nombre { get; set; }
        public virtual long Duracion { get; set; }
        public virtual Traza TrazaSimulada { get; set; }
        public virtual IMetodoSimulacion Metodo { get; set; }

        public virtual void Ejecutar()
        {
            Metodo.EjecutarSimulacion(TrazaSimulada,Duracion);
        }
    }
}
