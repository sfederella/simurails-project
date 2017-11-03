using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuRails.Models
{
    public class AgrupacionCoche
    {
        public virtual Coche Coche { get; set; }
        public virtual int Cantidad { get; set; }

        public AgrupacionCoche()
        {
            this.Cantidad = 0;
        }

        public AgrupacionCoche(Coche coche, int cantidad): this()
        {    
            this.Coche = coche;
            this.Cantidad = cantidad;
        }

        public static IDictionary<Coche, int> ToDictionary(List<AgrupacionCoche> agrupaciones)
        {
            return agrupaciones.ToDictionary(agrupacion => agrupacion.Coche, agrupacion => agrupacion.Cantidad);
        }

        public static List<AgrupacionCoche> From(IDictionary<Coche, int> diccionario)
        {
            return diccionario.Select(claveValor => new AgrupacionCoche(claveValor.Key, claveValor.Value)).ToList();
        }

        public AgrupacionCoche crearCopia()
        {
            return new AgrupacionCoche(Coche, Cantidad);
        }

        internal void limpiar()
        {
            this.Coche = null;
            this.Cantidad = 0;
        }
    }
}
