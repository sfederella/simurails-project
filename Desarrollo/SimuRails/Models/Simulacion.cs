using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuRails.Models
{
    public class Simulacion
    {
        public Simulacion() { }

        // Persistentes
        public virtual int Id { get; set; }
        public virtual string Nombre { get; set; }
        public virtual long Duracion { get; set; }
        public virtual Traza TrazaSimulada { get; set; }

        //Este no lo persisto
        public virtual IMetodoSimulacion Metodo { get; set; }

        public virtual bool Ejecutar(BackgroundWorker backgroundWorker)
        {
            if (Metodo == null) Metodo = new TiempoComprometido();
            return Metodo.EjecutarSimulacion(TrazaSimulada,Duracion, backgroundWorker);
        }
    }
}
