using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuRails.Models
{
    public class AgrupacionFormacion
    {
        public virtual Formacion Formacion { get; set; }
        public virtual int Cantidad { get; set; }

        public AgrupacionFormacion()
        {
            this.Cantidad = 0;
        }

        public AgrupacionFormacion(Formacion formacion, int cantidad): this()
        {
            this.Formacion = formacion;
            this.Cantidad = cantidad;
        }

        public static IDictionary<Formacion, int> ToDictionary(List<AgrupacionFormacion> agrupaciones)
        {
            return agrupaciones.ToDictionary(agrupacion => agrupacion.Formacion, agrupacion => agrupacion.Cantidad);
        }

        public static List<AgrupacionFormacion> From(IDictionary<Formacion, int> diccionario)
        {
            return diccionario.Select(claveValor => new AgrupacionFormacion(claveValor.Key, claveValor.Value)).ToList();
        }
    }
}
